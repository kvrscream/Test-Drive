using System;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Agendamento Agendamento { get; set; }
        public Veiculo Veiculo { get; set; }

        public string Nome
        {
            get
            {
                return Agendamento.Nome;
            }
            set
            {
                Agendamento.Nome = value;
                OnPropertyChanged();
                ((Command)AgendamentoCommand).ChangeCanExecute();
            }
        }
        public string Fone
        {
            get
            {
                return Agendamento.Fone;
            }
            set
            {
                Agendamento.Fone = value;
                OnPropertyChanged();
                ((Command)AgendamentoCommand).ChangeCanExecute();
            }
        }
        public string Email
        {
            get
            {
                return Agendamento.Email;
            }
            set
            {
                Agendamento.Email = value;
                OnPropertyChanged();
                ((Command)AgendamentoCommand).ChangeCanExecute();
            }
        }

        public DateTime DataAgendamento
        {
            get
            {
                return Agendamento.DataAgendamento;
            }
            set
            {
                Agendamento.DataAgendamento = value;
            }
        }
        public TimeSpan HoraAgendamento
        {
            get
            {
                return Agendamento.HoraAgendamento;
            }
            set
            {
                Agendamento.HoraAgendamento = value;
            }
        }

        public AgendamentoViewModel(Veiculo veiculo)
        {
            this.Agendamento = new Agendamento();
            Veiculo = veiculo;
            AgendamentoCommand = new Command(() =>
            {
                MessagingCenter.Send<Agendamento>(this.Agendamento, "agendamento");
            },
            () => {
                return !string.IsNullOrEmpty(this.Nome) && !string.IsNullOrEmpty(this.Fone) && !string.IsNullOrEmpty(this.Email);
            });
        }

        public ICommand AgendamentoCommand { get; set; }


        public async void SalvaAgendamento()
        {
            string urlAgendamento = "https://aluracar.herokuapp.com/salvaragendamento";
            try
            {
                HttpClient client = new HttpClient();

                var json = JsonConvert.SerializeObject(new {
                        nome = Nome,
                        fone = Fone,
                        email = Email,
                        carro = Veiculo.Nome,
                        preco = Veiculo.Valor,
                        dataAgendamento = new DateTime(DataAgendamento.Year, DataAgendamento.Month, DataAgendamento.Day,
                        HoraAgendamento.Hours, HoraAgendamento.Minutes, HoraAgendamento.Seconds)
                });


                StringContent content = new StringContent(json, encoding: Encoding.UTF8, "application/json");

                HttpResponseMessage result = await client.PostAsync(urlAgendamento, content);

                if (result.IsSuccessStatusCode)
                {
                    MessagingCenter.Send<Agendamento>(this.Agendamento, "sucessoAgendamento");
                } else
                {
                    MessagingCenter.Send<ArgumentException>(new ArgumentException(), "erroAgendamento");
                }

            } catch(Exception ex)
            {
                MessagingCenter.Send<ArgumentException>(new ArgumentException(), "erroAgendamento");
            }
        }


    }
}
