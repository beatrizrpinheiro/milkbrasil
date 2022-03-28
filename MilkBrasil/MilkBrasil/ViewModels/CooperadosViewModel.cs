using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using MilkBrasil.Models;
using Xamarin.Forms;

namespace MilkBrasil.ViewModels
{
    class CooperadosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        ObservableCollection<CadastroCooperados> infoCooperados = new ObservableCollection<CadastroCooperados>();

        //Coleção que armazena os cooperados cadastrados
        public ObservableCollection<CadastroCooperados> InfoCooperados
        {
            get => infoCooperados;
            set => infoCooperados = value;
        }

        public ICommand Refresh
        {
            get
            {
                return new Command(async () =>
               {
                   try
                   {
                       List<CadastroCooperados> temporaria = await App.Database.GetCooperadosAsync();
                       InfoCooperados.Clear();
                       temporaria.ForEach(i => InfoCooperados.Add(i));
                   }
                   catch (Exception ex)
                   {
                       await Application.Current.MainPage.DisplayAlert("Erro", ex.Message, "Ok");
                   }
               });
            }
        }
        public ICommand Details
        {
            get
            {
                return new Command<int>(async (int id) =>
                {
                    await Shell.Current.GoToAsync($"//Cadastro?parametro_id={id}");
                });
            }
        }
    }
}
