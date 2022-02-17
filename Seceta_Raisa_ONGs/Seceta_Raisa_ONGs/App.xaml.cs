using System;
using Seceta_Raisa_ONGs.Models;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Seceta_Raisa_ONGs
{
    public partial class App : Application
    {
        static ProjectListDatabase database;
        public static ProjectListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                        ProjectListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjectListDatabase.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
