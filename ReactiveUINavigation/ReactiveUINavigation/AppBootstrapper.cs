using System;
using ReactiveUI;
using ReactiveUI.XamForms;
using ReactiveUINavigation.Services;
using ReactiveUINavigation.ViewModels;
using ReactiveUINavigation.Views;
using Splat;
using Xamarin.Forms;

namespace ReactiveUINavigation
{
    public class AppBootstrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; }

        public AppBootstrapper()
        {
            Router = new RoutingState();
            RegisterServices();
            RegisterViews();
        }

        public Page Init()
        {
            var service = Locator.Current.GetService<INavigationManager>();
            service.NavigateTo<FirstViewModel>();
            return new RoutedViewHost(); 
        }

        private void RegisterServices()
        {
            var instance = new NavigationManager();
            Locator.CurrentMutable.RegisterConstant(instance, typeof(IScreen));
            Locator.CurrentMutable.RegisterConstant(instance, typeof(INavigationManager));
        }

        private void RegisterViews()
        {
            Locator.CurrentMutable.Register(() => new FirstPage(), typeof(IViewFor<FirstViewModel>));
            Locator.CurrentMutable.Register(() => new SecondPage(), typeof(IViewFor<SecondViewModel>));
            Locator.CurrentMutable.Register(() => new RootFlyoutPage(), typeof(IViewFor<MainFlyoutViewModel>));
            Locator.CurrentMutable.Register(() => new RootTabbedPage(), typeof(IViewFor<MainTabbedViewModel>));
        }
    }
}

