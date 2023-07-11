using System;
using System.Collections.Generic;
using ReactiveUI.XamForms;
using ReactiveUINavigation.ViewModels;
using Xamarin.Forms;

namespace ReactiveUINavigation.Views
{	
	public partial class RootTabbedPage : ReactiveTabbedPage<MainTabbedViewModel>
	{	
		public RootTabbedPage ()
		{
			InitializeComponent ();

            BindingContext = ViewModel = new MainTabbedViewModel();
        }
	}
}

