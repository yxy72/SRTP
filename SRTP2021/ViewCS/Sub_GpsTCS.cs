using SRTP2021.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SRTP2021.ViewCS
{
    class Sub_GpsTCS : NotifyBase
    {

        public CommandBase DoCommand { set; get; } = new CommandBase();
        private DispatcherTimer TIMER = new DispatcherTimer();

        public Sub_GpsTCS()
        {
            this.DoCommand.DoExecute = new Action<object>((o) => {

            });
            this.DoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            TIMER.Interval = new TimeSpan(0, 0, 1);
            TIMER.Tick += new EventHandler(TIMERTask);
            TIMER.Start();


        }
        private void TIMERTask(object sender, EventArgs e)
        {
            GpsIns_temperature = V.GpsIns_temperature.ToString();
            GpsIns_humidity = V.GpsIns_humidity.ToString();
        }


        public string GpsIns_humidity
        {
            get { return V.GpsIns_humidity.ToString("0.0")+" %"; }
            set { V.GpsIns_humidity = double.Parse(value); this.DoNotify(); }
        }
        public string GpsIns_temperature
        {
            get { return V.GpsIns_temperature.ToString("0.0")+ " °C"; }
            set { V.GpsIns_temperature = double.Parse(value); this.DoNotify(); }
        }
    }
}
