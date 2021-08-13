using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamepadController.Helper
{
    /// <summary>
    /// 从Windows的Xbox控制器接收输入
    /// https://docs.microsoft.com/en-us/windows/win32/xinput/getting-started-with-xinput
    /// </summary>
    public class XInputHelper
    {
        /// <summary>
        /// 是否连接控制器
        /// </summary>
        public bool isGetJoystick = false;

        /// <summary>
        /// 连接到的控制器
        /// </summary>
        public Controller controller;

        /// <summary>
        /// 控制器状态捕获计时器
        /// </summary>
        private Timer _timer;

        /// <summary>
        /// 连接控制器
        /// </summary>
        /// <returns></returns>
        public bool ConnectGamepad()
        {
            if (!isGetJoystick && _timer == null)
            {
                controller = new Controller(UserIndex.One);
                if (controller != null)
                {
                    isGetJoystick = true;
                    _timer = new Timer(obj => Update());
                    _timer.Change(0, 1000 / 60);
                }
            }
            return isGetJoystick;
        }

        /// <summary>
        /// 断开控制器
        /// </summary>
        /// <returns></returns>
        public void BreakOffGamepad()
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }
            if (isGetJoystick)
            {
                isGetJoystick = false;
            }
        }

        /// <summary>
        /// 捕获控制器数据
        /// </summary>
        private void Update()
        {
            try
            {
                #region 其他功能
                //// 获取电池电量和电池类型
                //var vGetBatteryInformation = controller.GetBatteryInformation(BatteryDeviceType.Gamepad);
                //// 获取功能按钮和震动马达信息(1)
                //var vGetCapabilities = controller.GetCapabilities(DeviceQueryType.Any);
                //// 获取功能按钮和震动马达信息(2) 
                //Capabilities vCapabilities;
                //var vIsGetCapabilities = controller.GetCapabilities(DeviceQueryType.Any, out vCapabilities);
                //// 获取按键信息
                //Keystroke vKeystroke;
                //var vGetKeystroke = controller.GetKeystroke(DeviceQueryType.Any, out vKeystroke);
                //// 获取状态(1)
                //var vGetState = controller.GetState();
                //// 获取状态(2)
                //State vState;
                //var vIsGetState = controller.GetState(out vState);
                //// 设置震动马达
                ////var vVibration = vGetCapabilities.Vibration;
                ////var vSetVibration = controller.SetVibration(vGetCapabilities.Vibration);
                #endregion

                // 获取状态
                var vGetState = controller.GetState();
            }
            catch (Exception)
            {
                BreakOffGamepad();
            }
        }
    }
}
