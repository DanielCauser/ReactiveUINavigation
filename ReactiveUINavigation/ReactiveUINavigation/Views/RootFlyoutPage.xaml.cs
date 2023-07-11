using System;
using System.Collections.Generic;
using ReactiveUI.XamForms;
using ReactiveUINavigation.ViewModels;
using Xamarin.Forms;

namespace ReactiveUINavigation.Views
{	
	public partial class RootFlyoutPage : ReactiveFlyoutPage<MainFlyoutViewModel>
	{	
		public RootFlyoutPage()
		{
			InitializeComponent ();

			BindingContext = ViewModel = new MainFlyoutViewModel();
		}
	}
}

