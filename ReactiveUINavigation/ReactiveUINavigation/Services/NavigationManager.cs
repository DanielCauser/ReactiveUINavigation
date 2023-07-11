using System;
using ReactiveUI;
using ReactiveUI.XamForms;
using ReactiveUINavigation.ViewModels;
using Splat;
using Xamarin.Forms;

namespace ReactiveUINavigation.Services
{
	public class NavigationManager : ReactiveObject, IScreen, INavigationManager
    {
        public RoutingState Router { get; }

        public NavigationManager()
		{
            Router = new RoutingState();
        }

        public IObservable<IRoutableViewModel> NavigateTo<T>() where T : IRoutableViewModel
        {
            var instance = Activator.CreateInstance<T>();
            return Router.Navigate.Execute((IRoutableViewModel)instance);
        }

        public IObservable<IRoutableViewModel> NavigateAndReset<T>() where T : IRoutableViewModel
        {
            var instance = Activator.CreateInstance<T>();
            return Router.NavigateAndReset.Execute((IRoutableViewModel)instance);
        }
    }

	public interface INavigationManager
	{
        IObservable<IRoutableViewModel> NavigateTo<T>() where T : IRoutableViewModel;

        IObservable<IRoutableViewModel> NavigateAndReset<T>() where T : IRoutableViewModel;
    }
}

