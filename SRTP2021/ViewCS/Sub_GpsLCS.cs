using SRTP2021.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SRTP2021.ViewCS
{
    class Sub_GpsLCS : NotifyBase
    {

        public CommandBase DoCommand { set; get; } = new CommandBase();
        private DispatcherTimer TIMER = new DispatcherTimer();

        public Sub_GpsLCS() {
            this.DoCommand.DoExecute = new Action<object>((o) => {
            });
            this.DoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            TIMER.Interval = new TimeSpan(0, 0, 1);
            TIMER.Tick += new EventHandler(TIMERTask);
            TIMER.Start();


        }
        private void TIMERTask(object sender, EventArgs e){
            GpsIns_latitude = V.GpsIns_latitude.ToString();
            GpsIns_longitude = V.GpsIns_longitude.ToString();
            GpsIns_height = V.GpsIns_height.ToString();
        }


        public string GpsIns_latitude{
            get { return V.GpsIns_latitude.ToString("0.0000")+"°"; }
            set { V.GpsIns_latitude = double.Parse(value); this.DoNotify(); }
        }
        public string GpsIns_longitude
        {
            get { return V.GpsIns_longitude.ToString("0.0000") + "°"; }
            set { V.GpsIns_longitude = double.Parse(value); this.DoNotify(); }
        }
        public string GpsIns_height
        {
            get { return V.GpsIns_height.ToString("0.0") + " m"; }
            set { V.GpsIns_height = double.Parse(value); this.DoNotify(); }
        }
    }
}
