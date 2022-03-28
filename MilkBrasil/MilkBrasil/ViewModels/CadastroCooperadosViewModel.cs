using MilkBrasil.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace MilkBrasil.ViewModels
{
    [QueryProperty("PegarIdDaNavegacao", "parametro_id")]
   public class CadastroCooperadosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string razao, nome, endereco, atividade, representante;
        int cnpj, telefone, celular, envolvidos, id;
        DateTime fundacao;

        public string Razao 
        { 
            get => razao;
            set
            {
                razao = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Razao"));
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Nome"));
            }
        }
        public string Endereco 
        { 
            get => endereco;
            set
            {
                endereco = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Endereco"));
            }
         }
        public string Atividade
        {
            get => atividade;
            set
            {
                atividade = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Atividade"));
            }
        }
        public string Representante
        {
            get => representante;
            set
            {
                representante = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Representante"));
            }
        }
        public int Cnpj
        {
            get => cnpj;
            set
            {
                cnpj = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Cnpj"));
            }
        }
        public int Telefone
        {
            get => telefone;
            set
            {
                telefone = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Telefone"));
            }
        }

        public int Celular
        {
            get => celular;
            set
            {
                celular = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Celular"));
            }
        }

        public int Envolvidos 
        { 
            get => envolvidos; 
            set 
            {
                envolvidos = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Envolvidos"));
            } 
        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Id"));
            }
        }
        public DateTime Fundacao
        {
            get => fundacao;
            set
            {
                fundacao = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Fundacao"));
            }
        }

        public ICommand SalvarCooperado
        {
            get => new Command(async() =>
            {
                try
                {
                    CadastroCooperados cadastro = new CadastroCooperados()
                    {
                        Razao = this.Razao,
                        Nome = this.Nome,
                        Endereco = this.Endereco,
                        Atividade  = this.Atividade,
                        Representante = this.Representante,
                        Cnpj = this.Cnpj,
                        Telefone = this.Telefone,
                        Envolvidos = this.Envolvidos,
                        Fundacao = this.Fundacao
                    };

                    await App.Database.SaveCooperadosAsync(cadastro);
                    await Application.Current.MainPage.DisplayAlert("Excelente", "Cadastro realizado com sucesso!", "Ok");
                    await Shell.Current.GoToAsync("//Cooperados");


                }
                catch (Exception ex)
                {
                   await Application.Current.MainPage.DisplayAlert("Erro", ex.Message, "Ok");
                }
            });
        }
    }
}
