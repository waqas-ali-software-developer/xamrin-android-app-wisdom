using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wisdom
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class leaderpg : ContentPage
	{
        public List<Data> leader_list_data = new List<Data>()
        {
            new Data{Name="Page 1 wisdom",Id=1 },
            new Data{Name="Page 2 wisdom",Id=2 },
            new Data{Name="Page 3 wisdom",Id=3 }
        };
        public leaderpg ()
		{
			InitializeComponent ();
            leaderlist.ItemsSource = leader_list_data;
        }

        private void leaderlist_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}