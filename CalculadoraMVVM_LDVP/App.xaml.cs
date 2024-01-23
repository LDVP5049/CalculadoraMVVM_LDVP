using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CalculadoraMVVM_LDVP.Vistas;


namespace CalculadoraMVVM_LDVP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vcalcu();
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
