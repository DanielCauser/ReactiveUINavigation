﻿using System;
using System.Collections.Generic;
using ReactiveUI.XamForms;
using ReactiveUINavigation.ViewModels;
using Xamarin.Forms;

namespace ReactiveUINavigation.Views
{	
	public partial class FirstPage : ReactiveContentPage<FirstViewModel>
	{	
		public FirstPage ()
		{
			InitializeComponent ();

			BindingContext = ViewModel = new FirstViewModel();
		}
	}
}

