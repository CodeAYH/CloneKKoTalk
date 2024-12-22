using Jamesnet.Wpf.Controls;
using KaKao.Login.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kakao.Settings
{
    class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, LoginContent>("LoginContent");
        }
    }
}
