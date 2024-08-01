using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// tChart2.xaml 的交互逻辑
    /// </summary>
    public partial class tChart2 : UserControl
    {
        public SeriesCollection seriesCollection { get; set; }
		public List<string> Labels { get; set; }
		private double _trend;
		private double[] temp = { 1, 3, 2, 4,3,6,3,2,2,4,7,4,2, -3, 5, 2, 1,7 };


		public tChart2()
		{
			InitializeComponent();

			//实例化一条折线图
			LineSeries line1 = new LineSeries();
			//设置折线的标题
			line1.Title = "Temp";
			//设置折线的形式
			line1.LineSmoothness = 1;
			//折线图的无点样式
			line1.PointGeometry = null;
			//添加横坐标
			Labels = new List<string>();
			foreach (var item in temp)
			{
				Labels.Add(item.ToString());
			}
				//添加绘图的数据
				line1.Values = new ChartValues<double>(temp);
			seriesCollection = new SeriesCollection();
			seriesCollection.Add(line1);
			_trend = 8;
			lineStart();

			DataContext = this;
			this.sl.Series = seriesCollection;
			slx.Labels = Labels;
		}

		public void lineStart()
		{
			Task.Run(() =>
			{
				Random r = new Random();
				while (true)
				{
					Thread.Sleep(300);
					_trend = r.Next(-10, 10);
					//通过Dispatcher在工作线程中更新窗体的UI元素
					Application.Current.Dispatcher.Invoke(() =>
					{
						//更新横坐标时间
						Labels.Add(DateTime.Now.ToString());
						Labels.RemoveAt(0);
						//更新纵坐标数据
						seriesCollection[0].Values.Add(V.GpsIns_speed);
						seriesCollection[0].Values.RemoveAt(0);
					});
				}
			});
		}



	}
}
	