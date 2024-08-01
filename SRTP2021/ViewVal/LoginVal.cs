using SRTP2021.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRTP2021.ViewVal
{
    //View的变量处理
    public class LoginVal : NotifyBase
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; this.DoNotify(); }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; this.DoNotify(); }
        }




    }
}
