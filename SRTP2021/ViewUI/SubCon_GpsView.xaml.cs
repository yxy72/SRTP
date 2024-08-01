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

namespace SRTP2021.ViewUI
{
    /// <summary>
    /// SubCon_GpsView.xaml 的交互逻辑
    /// </summary>
    public partial class SubCon_GpsView : UserControl
    {


        private DispatcherTimer TIMER = new DispatcherTimer();
        public SubCon_GpsView()
        {
            InitializeComponent();
            string mapUrl = "pack://siteoforigin:,,,/Html/map.html";
            //string szTmp = "../Html/map.html";

            baiduView.Navigate(mapUrl);
            TIMER.Interval = new TimeSpan(0, 0, 1);
            TIMER.Tick += new EventHandler(TIMERTask);
            TIMER.Start();
        }
      


        
    private void TIMERTask(object sender, EventArgs e)
    {
            this.baiduView.InvokeScript("changePoint", V.GpsIns_longitude,V.GpsIns_latitude);
        }
    private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServerAccess.saveServerData();
        }
    }
}
