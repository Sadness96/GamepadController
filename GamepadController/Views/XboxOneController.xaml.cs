using GamepadController.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GamepadController.Views
{
    /// <summary>
    /// XboxOneController.xaml 的交互逻辑
    /// </summary>
    public partial class XboxOneController : Window
    {
        public XboxOneController()
        {
            InitializeComponent();
            this.Loaded += XboxOneController_Loaded;
            this.MouseDown += XboxOneController_MouseDown; ;
        }

        private XInputHelper xInputHelper;

        private void XboxOneController_Loaded(object sender, RoutedEventArgs e)
        {
            xInputHelper = new XInputHelper();
            xInputHelper.ButtonsChange += XInputHelper_ButtonsChange;
            xInputHelper.LeftTriggerChange += XInputHelper_LeftTriggerChange;
            xInputHelper.RightTriggerChange += XInputHelper_RightTriggerChange;
            xInputHelper.LeftThumbXChange += XInputHelper_LeftThumbXChange;
            xInputHelper.LeftThumbYChange += XInputHelper_LeftThumbYChange;
            xInputHelper.RightThumbXChange += XInputHelper_RightThumbXChange;
            xInputHelper.RightThumbYChange += XInputHelper_RightThumbYChange;
            xInputHelper.ConnectGamepad();
        }

        /// <summary>
        /// 拖动窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XboxOneController_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        /// <summary>
        /// 按键改变时触发
        /// </summary>
        /// <param name="obj"></param>
        private void XInputHelper_ButtonsChange(SharpDX.XInput.GamepadButtonFlags obj)
        {

        }

        /// <summary>
        /// LT 按键变化事件
        /// </summary>
        /// <param name="obj"></param>
        private void XInputHelper_LeftTriggerChange(byte obj)
        {

        }

        /// <summary>
        /// RT 按键变化事件
        /// </summary>
        /// <param name="obj"></param>
        private void XInputHelper_RightTriggerChange(byte obj)
        {

        }

        /// <summary>
        /// 左摇杆 X 变化事件
        /// </summary>
        /// <param name="obj"></param>
        private void XInputHelper_LeftThumbXChange(short obj)
        {

        }

        /// <summary>
        /// 左摇杆 Y 变化事件
        /// </summary>
        /// <param name="obj"></param>
        private void XInputHelper_LeftThumbYChange(short obj)
        {

        }

        /// <summary>
        /// 右摇杆 X 变化事件
        /// </summary>
        /// <param name="obj"></param>
        private void XInputHelper_RightThumbXChange(short obj)
        {

        }

        /// <summary>
        /// 右摇杆 Y 变化事件
        /// </summary>
        /// <param name="obj"></param>
        private void XInputHelper_RightThumbYChange(short obj)
        {

        }
    }
}
