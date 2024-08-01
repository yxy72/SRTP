using SRTP2021.ViewCS;
using SRTP2021.ViewUI;
using SRTP2021.ViewUI.SubCon_AllView;
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
using System.Windows.Threading;

namespace SRTP2021
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        int jiaodu = 0;
        public MainView()
        {
            InitializeComponent();
            this.DataContext = new MainCS();
            ToFullscreen();
            btnAll.Focus();


            //string szTmp = "../Html/map.html";

            //baiduView.Navigate(szTmp);

            //baiduView.Navigate(mapUrl);

            ////DispatcherTimer TIMER = new DispatcherTimer();
            // TIMER.Interval = new TimeSpan(0, 0, 1);
            // TIMER.Tick += new EventHandler(TIMERTask);
            // TIMER.Start();

        }
        public enum mn
        { //menuName
            all, gps, speed, environment, radar, settings,
        }
        private void WinMove_LeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
        //菜单改变
        private void MenuModeChaning(int newMenu)
        {
            if (V.MenuMode == newMenu)
                return;

            V.MenuMode = newMenu;
            mainPlatform.Children.Clear();
            switch (newMenu)
            {
                case (int)mn.all:   mainPlatform.Children.Add(new SubCon_AllView()); break;
                case (int)mn.gps:   mainPlatform.Children.Add(new SubCon_GpsView()); break;
                case (int)mn.speed: break;
                case (int)mn.environment: break;
                case (int)mn.radar: break;
                case (int)mn.settings: break;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //subCon_AllView.sub_ChartView.dashboard.dashPoint.RenderTransform = setDashBoardPointRotate(jiaodu+=90);
        }

        private RotateTransform setDashBoardPointRotate(int angle) {
            RotateTransform rotateTransform = new RotateTransform(angle);
            rotateTransform.CenterX = 30;
            rotateTransform.CenterY = 30;
            return rotateTransform;
        }

        /// <summary>
        /// 全屏
        /// </summary>
        public void ToFullscreen()
        {
            this.WindowState = System.Windows.WindowState.Normal;
            this.WindowStyle = System.Windows.WindowStyle.None;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            //this.Topmost = true;

            this.Left = 0.0;
            this.Top = 0.0;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
        }

        private void TIMERTask(object sender, EventArgs e)
        {
            //this.cnm.Text = System.DateTime.Now.ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cnm1.Text = O.HttpGet("http://192.168.1.108:8081/gps/1");
        }

        private void BottomBtn_GPS(object sender, RoutedEventArgs e)
        {
            //mainUIPlatform.Children.Add(new SubCon_GpsView());
            mainPlatform.Children.Clear();
            mainPlatform.Children.Add(new SubCon_GpsView());
        }

       
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
            MenuModeChaning((int)mn.all);
        }

        private void btnSpeed_Click(object sender, RoutedEventArgs e)
        {
            MenuModeChaning((int)mn.speed);
        }

        private void btnGPS_Click(object sender, RoutedEventArgs e)
        {
            MenuModeChaning((int)mn.gps);
        }

        private void btnEnvironment_Click(object sender, RoutedEventArgs e)
        {
            MenuModeChaning((int)mn.environment);
        }

        private void btnRadar_Click(object sender, RoutedEventArgs e)
        {
            MenuModeChaning((int)mn.radar);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            MenuModeChaning((int)mn.settings);
        }
    }
}
