using ComponentApp.SharedInterface;
using ComponentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComponentApp
{
    public partial class MainPage : ContentPage
    {
        MainViewModel vm;
        public MainViewModel VM => vm ?? (vm = BindingContext as MainViewModel);
        public MainPage()
        {
            InitializeComponent();
            ListViewModules.ItemSelected += ListViewModules_ItemSelected;
            VM.Navigation = Navigation;
        }

        private async void ListViewModules_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem is IModule module)
            {
                await VM.GoToModule(module);
                ListViewModules.SelectedItem = null;
            }
        }
    }
}
