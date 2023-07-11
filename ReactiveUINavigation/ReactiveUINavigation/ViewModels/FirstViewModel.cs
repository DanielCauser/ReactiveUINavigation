using System;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUINavigation.Services;
using Splat;

namespace ReactiveUINavigation.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        public FirstViewModel()
        {
            var service = Locator.Current.GetService<INavigationManager>();

            NavigateCommand = ReactiveCommand.CreateFromObservable(() =>
                service.NavigateTo<SecondViewModel>());

            NavigateFullPageCommand = ReactiveCommand.CreateFromObservable(() =>
                service.NavigateAndReset<SecondViewModel>());

            NavigateFlyoutCommand = ReactiveCommand.CreateFromObservable(() =>
                service.NavigateAndReset<MainFlyoutViewModel>());

            NavigateTabbedCommand = ReactiveCommand.CreateFromObservable(() =>
                service.NavigateAndReset<MainTabbedViewModel>());
        }


        public ICommand NavigateTabbedCommand { get; }
        
        public ICommand NavigateCommand { get; }

        public ICommand NavigateFullPageCommand { get; }

        public ICommand NavigateFlyoutCommand { get; }
    }
}

