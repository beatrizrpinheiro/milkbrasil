using MilkBrasil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MilkBrasil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroCooperados : ContentPage
    {
        public CadastroCooperados()
        {
            InitializeComponent();
            BindingContext = new CadastroCooperadosViewModel();
        }

    
        private void Button_Clicked(object sender, EventArgs e)
        {
          

        }
    }
}