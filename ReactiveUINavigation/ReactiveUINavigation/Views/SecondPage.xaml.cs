using System;
using System.Collections.Generic;
using ReactiveUI.XamForms;
using ReactiveUINavigation.ViewModels;
using Xamarin.Forms;

namespace ReactiveUINavigation.Views
{	
	public partial class SecondPage : ReactiveContentPage<SecondViewModel>
	{	
		public SecondPage ()
		{
			InitializeComponent ();
            BindingContext = ViewModel = new SecondViewModel();
        }
	}
}

