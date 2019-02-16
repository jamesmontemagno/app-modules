using ComponentApp.Module1;
using ComponentApp.SharedInterface;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Module1
{
    public class Module : IModule
    {
        public INavigation Navigation { get; private set; }
        public Type StartPageType => typeof(MainPage);

        public string Icon => "ic_view_module.png";

        public string Title => "Module 1";

        public void SetNavigation(INavigation navigation) =>
            Navigation = navigation;
    }
}
