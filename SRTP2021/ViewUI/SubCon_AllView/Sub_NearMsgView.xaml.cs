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
    /// SubCon_NearMsgView.xaml 的交互逻辑
    /// </summary>
    public partial class Sub_NearMsgView : UserControl
    {
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private const double EARTH_RADIUS = 6378137;    //地球半径嘻嘻
        public Sub_NearMsgView()
        {
            InitializeComponent();
            dispatcherTimer.Interval= new TimeSpan(0, 0, 0, 0, 500);
            dispatcherTimer.Tick += new EventHandler(timerTask);
            dispatcherTimer.Start();
        }
        public double a = 1;
        private void timerTask(object sender,EventArgs e )
        {
            V.Distance_FromOther.No1 = calculateDistance(double.Parse(No1_Longitude.Text.Substring(0, No1_Longitude.Text.Length - 1)), double.Parse(No1_Latitude.Text.Substring(0, No1_Latitude.Text.Length - 1)));
            V.Distance_FromOther.No2 = calculateDistance(double.Parse(No2_Longitude.Text.Substring(0, No2_Longitude.Text.Length - 1)), double.Parse(No2_Latitude.Text.Substring(0, No2_Latitude.Text.Length - 1)));
            V.Distance_FromOther.No3 = calculateDistance(double.Parse(No3_Longitude.Text.Substring(0, No3_Longitude.Text.Length - 1)), double.Parse(No3_Latitude.Text.Substring(0, No3_Latitude.Text.Length - 1)));
            
            No1_Distance.Text = V.Distance_FromOther.No1.ToString("0.00") + "m";
            No2_Distance.Text = V.Distance_FromOther.No2.ToString("0.00") + "m";
            No3_Distance.Text = V.Distance_FromOther.No3.ToString("0.00")+"m";
        }
        static double rad(double d) //deg2rad
        {
            return d * Math.PI / 180.0;
        }
        public double calculateDistance(double longitude,double latitude) {
            double radLat1 = rad(latitude);
            double radLat2 = rad(V.GpsIns_latitude);
            double radLong1 = rad(longitude);
            double radLong2 = rad(V.GpsIns_longitude);

            double a = radLat1 - radLat2;
            double b = radLong1 - radLong2;
            double result = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2) + Math.Cos(radLat1) * Math.Cos(radLat2) * Math.Pow(Math.Sin(b / 2), 2))) * EARTH_RADIUS;
            return result;
        }
    }
}
