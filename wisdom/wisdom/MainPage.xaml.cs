using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace wisdom
{
	public partial class MainPage : ContentPage
	{
        public List<Data> leader_list_data = new List<Data>()
        {
            new Data{Name="Page 1 wisdom",Id=1 },
            new Data{Name="Page 2 wisdom",Id=2 },
            new Data{Name="Page 3 wisdom",Id=3 },
            new Data{Name="Page 4 wisdom",Id=4 },
            new Data{Name="Page 5 wisdom",Id=5 },
            new Data{Name="Page 6 wisdom",Id=6 },
            new Data{Name="Page 7 wisdom",Id=7 }
        };
        
        public MainPage()
		{
			InitializeComponent();
            leaderlist.ItemsSource = leader_list_data;
        }

        private void leaderlist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Data;
           switch(details.Id)
            {
                case 1:
                    Navigation.PushAsync(new leadpg1());
                    break;
                case 2:
                    Navigation.PushAsync(new leadpg2());
                    break;
                case 3:
                    Navigation.PushAsync(new leadpg3());
                    break;
                case 4:
                    Navigation.PushAsync(new leadpg4());
                    break;
                case 5:
                    Navigation.PushAsync(new leadpg5());
                    break;
                case 6:
                    Navigation.PushAsync(new leadpg6());
                    break;
                case 7:
                    Navigation.PushAsync(new leadpg7());
                    break;
                default:
                    Navigation.PushAsync(new leadpg1());
                    break;
            }
           
        }
    }
}
