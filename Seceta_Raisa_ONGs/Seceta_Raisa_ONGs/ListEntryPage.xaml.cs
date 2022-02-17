using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Seceta_Raisa_ONGs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
            protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetProjectListsAsync();
        }
        async void OnProjectListAddedClicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new List
            {
                BindingContext = new ProjectList()
            });
        }
        async void OnListViewItemSelected (object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new List
                {
                    BindingContext = e.SelectedItem as OnProjectListAddedClicked
                });
            }
        }
        }
    }
}