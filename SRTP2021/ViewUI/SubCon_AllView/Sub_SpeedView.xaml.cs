using SRTP2021.Common;
using SRTP2021.ViewCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SRTP2021.ViewUI.SubCon_AllView
{
    /// <summary>
    /// Sub_SpeedView.xaml 的交互逻辑
    /// </summary>
    public partial class Sub_SpeedView : UserControl
    {
        private static bool mode = false;
        private Sub_SpeedCS sub_SpeedCS = new Sub_SpeedCS();
        public Sub_SpeedView()
        {
            InitializeComponent();
            this.DataContext = sub_SpeedCS;
        }

        public static bool Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mode = !mode;
            if (!mode)
            {
                danwei.Text = "Km/h";danwei.FontSize = 27;
            }
            else
                danwei.Text = "m/s"; danwei.FontSize = 32;

            sub_SpeedCS.GpsIns_speed = V.GpsIns_speed.ToString();

        }

        private void dashboard_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
