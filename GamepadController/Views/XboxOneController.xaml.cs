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
    }
}
