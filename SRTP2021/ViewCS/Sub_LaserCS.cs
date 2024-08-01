using SRTP2021.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SRTP2021.ViewCS
{
    class Sub_LaserCS : NotifyBase
    {
        public CommandBase DoCommand { set; get; } = new CommandBase();

        public Sub_LaserCS()
        {
            this.DoCommand.DoExecute = new Action<object>((o) => {

            });
            this.DoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            TIMER.Interval = new TimeSpan(0, 0, 1);
            TIMER.Tick += new EventHandler(TIMERTask);
            TIMER.Start();


        }
        private DispatcherTimer TIMER = new DispatcherTimer();
        private void TIMERTask(object sender, EventArgs e)
        {
            Laser_distance = V.Laser_distance.ToString();
        }


        public string Laser_distance
        {
            get { return V.Laser_distance.ToString()+" m"; }
            set { V.Laser_distance = double.Parse(value); this.DoNotify(); }
        }
    }
}
