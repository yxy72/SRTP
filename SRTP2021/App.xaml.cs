﻿using SRTP2021.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SRTP2021
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        
        protected override void OnStartup(StartupEventArgs e)
        {
            
            
            base.OnStartup(e);
            if (new LoginView().ShowDialog() == true) {
                new MainView().ShowDialog();
            }
            Application.Current.Shutdown();
        }
    }
}
 