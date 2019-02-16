using ComponentApp.SharedInterface;
using System;
using System.Collections.Generic;
using System.Text;
using Module1;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComponentApp.ViewModels
{
    public class MainViewModel
    {
        public List<IModule> Modules { get; }
        public INavigation Navigation { get; set; }
        public MainViewModel()
        {
            Modules = new List<IModule>
            {
                new Module()
            };
        }

        public async Task GoToModule(IModule module)
        {
            var page = (Page)Activator.CreateInstance(module.StartPageType);
            page.Title = module.Title;
            module.SetNavigation(Navigation);
            await Navigation.PushAsync(page);
        }
    }
}
