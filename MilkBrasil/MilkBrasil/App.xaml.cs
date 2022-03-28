using MilkBrasil.LocalDataBase;
using MilkBrasil.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MilkBrasil
{
    public partial class App : Application
    {
        static DataBase database;
        public static DataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cooperados.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainShell();
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
