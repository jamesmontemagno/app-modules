using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module1.TestApp
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private async void ButtonGoToModule_Clicked(object sender, EventArgs e)
        {
            var module = App.Module;
            var page = (Page)Activator.CreateInstance(module.StartPageType);
            page.Title = module.Title;
            module.SetNavigation(Navigation);
            await Navigation.PushAsync(page);
        }
    }
}