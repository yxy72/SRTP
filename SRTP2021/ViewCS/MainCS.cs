using SRTP2021.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace SRTP2021.ViewCS
{
    class MainCS : NotifyBase
    {
        public CommandBase DoCommand { set; get; } = new CommandBase();
        public CommandBase CmdToPageAll { set; get; } = new CommandBase();
        public CommandBase CmdToPageGPS { set; get; } = new CommandBase();
        public CommandBase CmdToPageSpeed { set; get; } = new CommandBase();
        public CommandBase CmdToPageEnvironment { set; get; } = new CommandBase();
        public CommandBase CmdToPageRadar { set; get; } = new CommandBase();




        private bool testFlagforSpeedval = false;

        private string testData;
        private string dateTime;
        private float testQuanZhongT = .5f;
        private float testQuanZhongH = .5f;

        DispatcherTimer TIMER = new DispatcherTimer();


        public string DateTime
        {
            get { return dateTime; }
            set { dateTime = value; this.DoNotify(); }
        }

        public string TestData
        {
            get { return testData; }
            set { testData = value; this.DoNotify(); }
        }



        public MainCS()
        {


            TestData = "128.75";

            //CommandInit();




            TIMER.Interval = new TimeSpan(0, 0, 0, 0, 100);
            TIMER.Tick += new EventHandler(TIMERTask);
            TIMER.Start();


        }

        /*private void CommandInit() {

            this.DoCommand.DoExecute = new Action<object>((o) => {
                //TestData = (sort++) + O.HttpGet("http://192.168.31.252:8081/gps/1");
                TestData = "asd";

            });
            this.DoCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });



            this.CmdToPageAll.DoExecute = new Action<object>((o) => {
                MenuModeChaning((int)mn.all);
            });
            this.CmdToPageAll.DoCanExecute = new Func<object, bool>((o) => { return true; });



            this.CmdToPageGPS.DoExecute = new Action<object>((o) => {
                MenuModeChaning((int)mn.gps);
            });
            this.CmdToPageGPS.DoCanExecute = new Func<object, bool>((o) => { return true; });



            this.CmdToPageSpeed.DoExecute = new Action<object>((o) => {
                MenuModeChaning((int)mn.speed);
            });
            this.CmdToPageSpeed.DoCanExecute = new Func<object, bool>((o) => { return true; });



            this.CmdToPageEnvironment.DoExecute = new Action<object>((o) => {
                MenuModeChaning((int)mn.environment);
            });
            this.CmdToPageEnvironment.DoCanExecute = new Func<object, bool>((o) => { return true; });



            this.CmdToPageRadar.DoExecute = new Action<object>((o) => {
                MenuModeChaning((int)mn.radar);
            });
            this.CmdToPageRadar.DoCanExecute = new Func<object, bool>((o) => { return true; });

        }*/

        private float functionX = 0;
        private float MaxSpeed = 0.12f;//60 30
        private float minSpeed = 0.03f;
        private float SpeedUpTime = 70;
        private float speedMaxTime = 80;
        private float speedStartDown = 90;
        private float SpeedDownTime = 120;
        private float SpeedEndTime = 180;
        private float functionToSpeed()
        {
            float y;
            float x = functionX;
            if (x < SpeedUpTime){
                y = MaxSpeed / speedMaxTime * x;
            }else if(x>= SpeedUpTime && x < speedMaxTime)
            {
                y = MaxSpeed / speedMaxTime * x;

            }else if (x >= speedMaxTime && x < speedStartDown)
            {
                 y = MaxSpeed;

            }
            else if(x>= speedStartDown && x< SpeedDownTime)
            {
                float xl = (MaxSpeed - minSpeed) / (SpeedDownTime - SpeedUpTime);
                y = -xl * x + (SpeedDownTime * xl) + minSpeed;
            }
            else if(x>=SpeedDownTime && x<SpeedEndTime)
            {
                y = minSpeed;
            }
            else
            {
                y = minSpeed;

            }



            functionX++;
            return y;
        }


        double xx =0;
        private double[] speed = new double[18] { 1.502, 1.495, 1.473, 1.465, 1.254, 1.119, 1.108, 0.991, 0.832, 0.659, 0.633, 0.552, 0.504, 0.508, 0.517, 0.518, 0.512, 0.488 };

        private double functionToDistance()
        {
            //double x = xx;
            //double y;
            //y = -0.052 * x * x + 0.83;
            //xx+=.1;
            //return x<4?y+(0.15*.5):.15*.51; 

            xx += 0.1;
            if (xx >= 17)
            {
                return 0;
            }
            return speed[(int)Math.Floor(xx)];



        }




        private void TIMERTask(object sender,EventArgs e) {
            DateTime = System.DateTime.Now.ToString();
            V.GpsIns_latitude+=0.00002;
            V.GpsIns_longitude+=0.00002;
            V.GpsIns_height+=0.3;
            

            V.Laser_distance += 0.113;
            //V.Laser_distance = Math.Round(functionToDistance(), 3);


            //ctrl K C
            if (V.GpsIns_speed >= 400)
                testFlagforSpeedval = true;
            if (V.GpsIns_speed <= 0)
                testFlagforSpeedval = false;

            if (!testFlagforSpeedval)
            {
                V.GpsIns_speed+= 1;
            }
            else
                V.GpsIns_speed -= 1;
            //V.GpsIns_speed = functionToSpeed();

            if (new Random().NextDouble()>testQuanZhongT)
                V.GpsIns_temperature += new Random().NextDouble()*.5;
            else
                V.GpsIns_temperature -= new Random().NextDouble()*.5;
            if (V.GpsIns_temperature >= 30)
                testQuanZhongT = 0.75F;
            else if(V.GpsIns_temperature <= 20)
                testQuanZhongT = 0.25F;

            if (new Random().NextDouble() > testQuanZhongH)
                V.GpsIns_humidity += new Random().NextDouble() * .5;
            else
                V.GpsIns_humidity -= new Random().NextDouble() * .5;
            if (V.GpsIns_humidity >= 90)
                testQuanZhongH = 0.75F;
            else if (V.GpsIns_humidity <= 80)
                testQuanZhongH = 0.25F;
        }
    }
}
