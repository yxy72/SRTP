using SRTP2021.Common;
using SRTP2021.ViewVal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SRTP2021.ViewCS
{
    //类初始化快捷ctor
    class LoginCS : NotifyBase
    {

        public LoginVal loginVal { get; set; } = new LoginVal();
        public CommandBase CloseWindowCommand { set; get; }
        public CommandBase LoginCommand { set; get; }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value;this.DoNotify(); }
        }

        public LoginCS()
        {
            loginVal.UserName = "admin";
            loginVal.Password = "admin";
            this.CloseWindowCommand = new CommandBase();
            this.CloseWindowCommand.DoExecute = new Action<object>((o) => {
                (o as Window).Close();
            });
            this.CloseWindowCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });

            //登录逻辑初始化
            this.LoginCommand = new CommandBase();
            this.LoginCommand.DoExecute = new Action<object>(DoLogin);
            this.LoginCommand.DoCanExecute = new Func<object, bool>((o) => { return true; });



        }

        //主登录逻辑
        private void DoLogin(object o) {
            this.ErrorMessage = "";
            
            
            if (string.IsNullOrEmpty(loginVal.UserName))
            {
                this.ErrorMessage = "用户名不能为空。";
                return;
            }
            if (string.IsNullOrEmpty(loginVal.Password))
            {
                this.ErrorMessage = "密码没有输。";
                return;
            }
            if (loginVal.UserName == "admin" && loginVal.Password == "admin")
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    (o as Window).DialogResult = true;
                }));
            }
            else
            {
                this.ErrorMessage = "用户名或密码输入错误。";
            }




        }
    }
}
