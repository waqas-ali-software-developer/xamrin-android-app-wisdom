﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wisdom
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class leadpg7 : ContentPage
	{
		public leadpg7 ()
		{
			InitializeComponent ();
		}

        private void GoToMainPage(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}