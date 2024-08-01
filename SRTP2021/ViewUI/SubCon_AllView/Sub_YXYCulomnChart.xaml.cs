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
    /// Sub_YXYCulomnChart.xaml 的交互逻辑
    /// </summary>
    public partial class Sub_YXYCulomnChart : UserControl
    {
        private double SquareMaxLength = 927.5 - 100 - 180;
        private int[] scale = new int[6] { 0, 100, 200, 300, 400, 500 };
        private double scaleRedundantRate = .255;
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public Sub_YXYCulomnChart()
        {
            InitializeComponent();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            dispatcherTimer.Tick += new EventHandler(timerTask);
            dispatcherTimer.Start();
        }
        private void timerTask(object sender,EventArgs e) {
            BackgroundInvalidate();
            Square1.Width = CalculateSquareLength(V.Distance_FromOther.No1);
            Square2.Width = CalculateSquareLength(V.Distance_FromOther.No2);
            Square3.Width = CalculateSquareLength(V.Distance_FromOther.No3);

            square1Val.Text = V.Distance_FromOther.No1.ToString("0.0")+" m";
            square2Val.Text = V.Distance_FromOther.No2.ToString("0.0") + " m";
            square3Val.Text = V.Distance_FromOther.No3.ToString("0.0") + " m";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void BackgroundInvalidate() {
            double maxVal = Math.Max(Math.Max(V.Distance_FromOther.No1, V.Distance_FromOther.No2), V.Distance_FromOther.No3);
            if (maxVal > scale[4])
            {

                scale1.Text = (scale[1] = (int)((1 + scaleRedundantRate) * maxVal) * 1 / 5 / 100 * 100).ToString();
                scale5.Text = (scale[5] = scale[1] * 5).ToString();
                scale4.Text = (scale[4] = scale[1] * 4).ToString();
                scale3.Text = (scale[3] = scale[1] * 3).ToString();
                scale2.Text = (scale[2] = scale[1] * 2).ToString();
            }
            if (maxVal < scale[3] + 0.75*(scale[4]- scale[3]))
            {

                scale1.Text = (scale[1] = (int)((1 + scaleRedundantRate) * maxVal) * 1 / 5 / 100 * 100).ToString();
                scale5.Text = (scale[5] = scale[1] * 5).ToString();
                scale4.Text = (scale[4] = scale[1] * 4).ToString();
                scale3.Text = (scale[3] = scale[1] * 3).ToString();
                scale2.Text = (scale[2] = scale[1] * 2).ToString();
            }
        }

        private double CalculateSquareLength(double val) {
            return (SquareMaxLength / scale[5]) * val;

        }
    }
}
