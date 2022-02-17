using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seceta_Raisa_ONGs.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Seceta_Raisa_ONGs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (ProjectListDatabase)BindingContext;
            slist.Date = DateTime.UtcNow;
            await App.Database.SaveProjectListAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked (object sender, EventArgs e)
        {
            var slist = (ProjectListDatabase)BindingContext;
            await App.Database.DeleteProjectListAsync(slist);
            await Navigation.PopAsync();
        }
    }
    }