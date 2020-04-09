using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.ViewModels
{
    public class DetalheViewModel : BaseViewModel
    {

        public DetalheViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            ProximoCommand = new Command(
                () =>
                {
                    MessagingCenter.Send(Veiculo, "proximo");
                }
            );
        }

        public Veiculo Veiculo { get; set; }
        public string TextFreio
        {
            get
            {
                return string.Format("Freio ABS R$ {0}", Veiculo.FREIO_ABS);
            }
        }

        public string TextAr
        {
            get
            {
                return string.Format("Ar-condicionado R$ {0}", Veiculo.AR_CONDICIONADO);
            }
        }


        public string TextMp3
        {
            get
            {
                return string.Format("MP3 Player R$ {0}", Veiculo.MP3_PALYER);
            }
        }

        public bool TemFreio
        {
            get
            {
                return Veiculo.TemFreio;
            }
            set
            {
                Veiculo.TemFreio = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }


        public bool TemAr
        {
            get
            {
                return Veiculo.TemAr;
            }
            set
            {
                Veiculo.TemAr = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }


        public bool TemMp3
        {
            get
            {
                return Veiculo.TemMp3;
            }
            set
            {
                Veiculo.TemMp3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;
            }
        }

        


        public ICommand ProximoCommand { get; set; }


    }
}
