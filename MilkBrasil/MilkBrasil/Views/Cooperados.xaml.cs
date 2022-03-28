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
    public partial class Cooperados : ContentPage
    {
        public Cooperados()
        {
            BindingContext = new CooperadosViewModel();
            
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var vm = (CooperadosViewModel)BindingContext;
            vm.Refresh.Execute(null);
        }

        protected void Details()
        {
            var vm = (CooperadosViewModel)BindingContext;
            vm.Details.Execute(null);
        }

    }
}