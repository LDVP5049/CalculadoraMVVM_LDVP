using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraMVVM_LDVP.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraMVVM_LDVP.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vcalcu : ContentPage
    {
        public Vcalcu()
        {
            InitializeComponent();
            BindingContext = new VMcalcu(Navigation);
        }
    }
}