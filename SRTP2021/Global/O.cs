using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SRTP2021
{
    //规定本类用于存放全局操作Operation


    public class O
    {
        public static string HttpGet(string url) {
            return ServerAccess.HttpGet(url);
        }

    }
}
