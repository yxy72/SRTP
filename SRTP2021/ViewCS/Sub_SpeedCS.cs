using SRTP2021.Common;
using SRTP2021.ViewUI.SubCon_AllView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SRTP2021.ViewCS
{
    class Sub_SpeedCS : NotifyBase
    {
        public CommandBase DoCommand { set; get; } = new CommandBase();
        private DispatcherTimer TIMER = new DispatcherTimer();

        public Sub_SpeedCS()
        {
            this.DoCommand.DoExecute = new Action<object>((o) => {

            });
            this.DoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            TIMER.Interval = new TimeSpan(0, 0,0,0,50);
            TIMER.Tick += new EventHandler(TIMERTask);
            TIMER.Start();


        }
        private void TIMERTask(object sender, EventArgs e)
        {
            GpsIns_speed = V.GpsIns_speed.ToString();
            GpsIns_speedVal = V.GpsIns_speed;
        }


        public string GpsIns_speed
        {
            get {
                if (!Sub_SpeedView.Mode)
                    return V.GpsIns_speed.ToString("0.0");
                else
                    return (V.GpsIns_speed*3.6).ToString("0.0");
            }
            set { V.GpsIns_speed = double.Parse(value); this.DoNotify(); }
        }
        public double GpsIns_speedVal
        {
            get
            {
                return V.GpsIns_speed;
            }
            set
            {
                V.GpsIns_speed = value; this.DoNotify();
            }
        }
    }
}
