using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Sub_ChartView.xaml 的交互逻辑
    /// </summary>
    public partial class Sub_ChartView : UserControl
    {
        public double[] temp = new double[30]{10,5,1,0,0,   0,0,0,0,0,   0,0,0,0,0,   0,0,0,0,0,   0,0,0,0,0,   0,0,0,0,0};
        public int cnnn = 14;
        public SeriesCollection SeriesCollection { get; set; } = new SeriesCollection();

        public List<string> Labels { get; set; } = new List<string>();

        public RowSeries mylineseriesCulomn = new RowSeries();

        //Column起始点1/2

        public SeriesCollection SeriesCollectionCulomn { get; set; } = new SeriesCollection();

        public double[] CulomnVal = new double[3] { 10,220,330};
        //Column小结点


        //三图起始点
        public int Index=0;

        public class MeasureModel
        {

            public int Index { get; set; }
            public double Value { get; set; }
        }
        public ChartValues<MeasureModel> ChartTemperatureValue { get; set; } = new ChartValues<MeasureModel>();
        public ChartValues<MeasureModel> ChartHumidityValue { get; set; } = new ChartValues<MeasureModel>();
        public ChartValues<MeasureModel> ChartHeightValue { get; set; } = new ChartValues<MeasureModel>();





        public Sub_ChartView()
        {
            InitializeComponent();


            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.Index)
                .Y(model => model.Value);
            Charting.For<MeasureModel>(mapper);


            //三图结束点


            //column起始点2/2
            //column结束点

            LineSeries mylineseries = new LineSeries();

            //设置折线的标题
            mylineseries.Title = "时速";
            mylineseriesCulomn.Title = "距离";
            //折线图直线形式
            mylineseries.LineSmoothness = 0;

            //折线图的无点样式
            mylineseries.PointGeometry = null;


            //添加折线图的数据
            mylineseries.Values = new ChartValues<double>(temp);

            mylineseriesCulomn.Values = new ChartValues<double>(CulomnVal);
            SeriesCollection.Add(mylineseries);
            SeriesCollectionCulomn.Add(mylineseriesCulomn);



            DataContext = this;

            for(int i = 0; i < 30; i++)
            {
                Labels.Add(DateTime.Now.AddSeconds(-30+i).ToString("T"));
            }
            cnm();
        }

        private void ChartThreeInvalidate() {

            Index++;

            /*
            CulomnVal[0] = V.Distance_FromOther.No1;
            CulomnVal[1] = V.Distance_FromOther.No2;
            CulomnVal[2] = V.Distance_FromOther.No3;
            mylineseriesCulomn.Values = new ChartValues<double>(CulomnVal);
            */


            ChartTemperatureValue.Add(new MeasureModel
            {
                Index = this.Index,
                Value = V.GpsIns_temperature
            });
            ChartHumidityValue.Add(new MeasureModel
            {
                Index = this.Index,
                Value = V.GpsIns_humidity
            });
            ChartHeightValue.Add(new MeasureModel
            {
                Index = this.Index,
                Value = V.GpsIns_height
            });
            if (Index > 30)
            {
                ChartTemperatureValue.RemoveAt(0);
                ChartHeightValue.RemoveAt(0);
                ChartHumidityValue.RemoveAt(0);
            }
            chartTempCurrVal.Text = V.GpsIns_temperature.ToString()+"°C";
            chartHumiCurrVal.Text = V.GpsIns_humidity.ToString() + "%";
            chartHeightCurrVal.Text = V.GpsIns_height.ToString() + "m";
        }


        private void cnm()
        {

            Task.Run(() =>
            {
                var r = new Random();
                while (true)
                {
                    Thread.Sleep(500);
                    //通过Dispatcher在工作线程中更新窗体的UI元素
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        //更新横坐标时间
                        Labels.Add(DateTime.Now.ToString("T"));
                        Labels.RemoveAt(0);
                        //更新纵坐标数据
                        SeriesCollection[0].Values.Add(V.GpsIns_speed);
                        SeriesCollection[0].Values.RemoveAt(0);

                        ChartThreeInvalidate();
                    });
                }
            });
        }

        private void CartesianChart_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
