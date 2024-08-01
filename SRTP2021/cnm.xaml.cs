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

namespace SRTP2021
{
    /// <summary>
    /// cnm.xaml 的交互逻辑
    /// </summary>
    public partial class cnm : Window
    {
        public cnm()
        {
            InitializeComponent();
            string szTmp = "D:/Project_HIGH/C#/SRTP2021/SRTP2021/Assets/web/map.html";
            //string szTmp = "../Html/map.html";

            mWebbrowser.Navigate(szTmp);
        }
    }
}
