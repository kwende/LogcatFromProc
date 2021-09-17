using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogcatViewer
{
    public partial class App : Application
    {
        public App(ILogCat logCat)
        {
            InitializeComponent();

            MainPage = new MainPage(logCat);
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
