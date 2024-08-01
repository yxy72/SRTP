using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTP2021.JsonTempClass
{
    class TempGpsL
    {
        //string[][] his10Data = new string[PTInfo.PTnum][];


        private int id;
        private string modify;

        [JsonProperty("gpsInsLongitude")]
        private double gpsInsLongitude;    //GPS经度

        [JsonProperty("gpsInsLatitude")]
        private double gpsInsLatitude;     //GPS纬度

        [JsonProperty("gpsInsHeight")]
        private double gpsInsHeight;       //GPS海拔



        [JsonProperty("gpsInsLongitude")]
        public double GpsInsLongitude { get => gpsInsLongitude; set => gpsInsLongitude = value; }
        public double GpsIns_latitude { get => gpsInsLatitude; set => gpsInsLatitude = value; }
        public double GpsIns_height { get => gpsInsHeight; set => gpsInsHeight = value; }
        public int Id { get => id; set => id = value; }
        public string Modify { get => modify; set => modify = value; }




        public void SaveToV_GpsL()
        {
            V.GpsIns_longitude = this.gpsInsLongitude;
            V.GpsIns_latitude = this.gpsInsLatitude;
            V.GpsIns_height = this.gpsInsHeight;
        }


        /*public int[] Status { get => status; set => status = value;}
        public string[] Data { get => data; set => data = value; }*/
    }
}