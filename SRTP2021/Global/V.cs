using SRTP2021.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTP2021
{
    //规定本类用于存放全局变量Val
    public class V 
    {
        public string url;

        private static double gpsIns_longitude = 103.993214;    //GPS经度
        private static double gpsIns_latitude = 30.770399;     //GPS纬度
        private static double gpsIns_height = 0;       //GPS海拔

        private static double gpsIns_temperature = 20;  //GPS温度
        private static double gpsIns_speed = 0;        //GPS速度
        private static double laser_distance = 0;      //激光测距
        private static double gpsIns_humidity = 85;

        public static class Distance_FromOther {
            public static double No1;
            public static double No2;
            public static double No3;
        }









        public enum mn
        { //menuName
            all, gps, speed, environment, radar, settings,
        }
        private static int menuMode = (int)mn.all;
        public static int MenuMode
        {
            get { return menuMode; }
            set { menuMode = value; }
        }


        private static ValueTuple radar_image;     //雷达绘图(占位)

        public V() {
        }

        #region 全局变量外部接口
        public static double GpsIns_humidity
        {
            get { return double.Parse(gpsIns_humidity.ToString("0.0")); ; }
            set { gpsIns_humidity = value; }
        }
        public static ValueTuple Radar_image
        {
            get { return radar_image; }
            set { radar_image = value; }
        }
        public static double Laser_distance
        {
            get { return laser_distance; }
            set { laser_distance = value;  }
        }
        public static double GpsIns_speed
        {
            get { return gpsIns_speed; }
            set { gpsIns_speed = value;}
        }
        public static double GpsIns_height
        {
            get { return gpsIns_height; }
            set { gpsIns_height = value; }
        }
        public static double GpsIns_temperature
        {
            get { return double.Parse(gpsIns_temperature.ToString("0.0")); }
            set { gpsIns_temperature = value;  }
        }
        public static double GpsIns_latitude
        {
            get { return gpsIns_latitude; }
            set { gpsIns_latitude = value;  }
        }
        public static double GpsIns_longitude
        {
            get { return gpsIns_longitude; }
            set { gpsIns_longitude = value; }
        }
        #endregion



        public static class otherV
        {
            public static double No1_gpsIns_longitude = 103.993214;    //GPS经度
            public static double No1_gpsIns_latitude = 30.770399;     //GPS纬度
            public static double No1_gpsIns_height = 0;       //GPS海拔
            public static double No1_gpsIns_temperature = 20;  //GPS温度
            public static double No1_gpsIns_speed = 0;        //GPS速度
            public static double No1_laser_distance = 0;      //激光测距
            public static double No1_gpsIns_humidity = 85;

            public static double No2_gpsIns_longitude = 103.993214;    //GPS经度
            public static double No2_gpsIns_latitude = 30.770399;     //GPS纬度
            public static double No2_gpsIns_height = 0;       //GPS海拔
            public static double No2_gpsIns_temperature = 20;  //GPS温度
            public static double No2_gpsIns_speed = 0;        //GPS速度
            public static double No2_laser_distance = 0;      //激光测距
            public static double No2_gpsIns_humidity = 85;

            public static double No3_gpsIns_longitude = 103.993214;    //GPS经度
            public static double No3_gpsIns_latitude = 30.770399;     //GPS纬度
            public static double No3_gpsIns_height = 0;       //GPS海拔
            public static double No3_gpsIns_temperature = 20;  //GPS温度
            public static double No3_gpsIns_speed = 0;        //GPS速度
            public static double No3_laser_distance = 0;      //激光测距
            public static double No3_gpsIns_humidity = 85;
        }
    }


    //常用快捷指令
    /*
    ctor TAB 构造函数
    prop TAB 变量结构
    propfull TAB 带封装属性类型


        */
}
