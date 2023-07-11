using System;
using System.IO;
using System.Runtime.CompilerServices;
using ReactiveUI;
using Splat;

namespace ReactiveUINavigation.ViewModels
{
    public class BaseViewModel : ReactiveObject, IRoutableViewModel
    {
        public BaseViewModel([CallerFilePath] string sourceFilePath = "")
        {
            UrlPathSegment = Path.GetFileNameWithoutExtension(sourceFilePath);
            HostScreen = Locator.Current.GetService<IScreen>();
        }

        public string UrlPathSegment { get; }

        public IScreen HostScreen { get; }
    }
}

