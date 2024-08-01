using SRTP2021.ViewCS;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SRTP2021.ViewUI.SubCon_AllView
{
    /// <summary>
    /// Sub_DashBoard.xaml 的交互逻辑
    /// </summary>
    public partial class Sub_DashBoard : UserControl
    {
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private double angleZero = 151;
        private double angleFull = 402;

        private int valZero = 0;
        private double valFull = 400;

        public Sub_DashBoard()
        {
            InitializeComponent();

            dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,50);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimerTask);
            dispatcherTimer.Start();
        }


        private RotateTransform setDashBoardPointRotate(double angle)
        {
            RotateTransform rotateTransform = new RotateTransform(angle);
            rotateTransform.CenterX = 30;
            rotateTransform.CenterY = 30;
            return rotateTransform;
        }
        private double angleCalculate() {
            double val = V.GpsIns_speed;

            double percentage = val / (valFull - valZero);

            return angleZero + (angleFull - angleZero) * percentage;
        }
        private void dispatcherTimerTask(object sender, EventArgs e) {
            dashPoint.RenderTransform = setDashBoardPointRotate(angleCalculate());

        }
    }
}
