using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.ViewModels
{
    public class AgendamentoViewModel : INotifyPropertyChanged
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
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public ICommand AgendamentoCommand { get; set; }

    }
}
