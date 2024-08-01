using SRTP2021.JsonTempClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SRTP2021
{
    class ServerAccess
    {
        public static string HttpGet(string url)
        {
            //创建
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            //设置请求方法
            httpWebRequest.Method = "GET";
            //请求超时时间
            httpWebRequest.Timeout = 20000;
            //发送请求
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //利用Stream流读取返回数据
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
            //获得最终数据，一般是json
            string responseContent = streamReader.ReadToEnd();
            streamReader.Close();
            httpWebResponse.Close();
            return responseContent;
        }

        public static void saveServerData() {
            //((TempGpsL)Json.toTempGpsL(O.HttpGet("http://127.0.0.1:80"))).SaveToV_GpsL();//http://192.168.31.252:8081/gps/1 获取GPS类
            string JsonStr = "[{\"id\":1,\"gpsInsLongitude\":103.0,\"gpsInsLatitude\":30.0,\"gpsInsHeight\":150.2,\"modify\":\"2021 - 01 - 18\"},{\"id\":40,\"gpsInsLongitude\":104.3,\"gpsInsLatitude\":34.5,\"gpsInsHeight\":187.21,\"modify\":\"2021 - 01 - 19\"},{\"id\":41,\"gpsInsLongitude\":105.36,\"gpsInsLatitude\":54.5,\"gpsInsHeight\":287.61,\"modify\":\"2021 - 01 - 19\"}]";
            List<TempGpsL> tempGpsLList = new List<TempGpsL>();
            tempGpsLList = Json.JSONStringToList<TempGpsL>(JsonStr);
            foreach(var item in tempGpsLList)
            {
                Console.WriteLine(item.Id+":"+item.GpsInsLongitude);
            }


        }




    }
}
