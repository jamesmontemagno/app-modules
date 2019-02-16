using System;
using Xamarin.Forms;

namespace ComponentApp.SharedInterface
{
    public interface IModule
    {
        void SetNavigation(INavigation navigation);
        Type StartPageType { get; }
        string Icon { get; }
        string Title { get; }
    }
}
