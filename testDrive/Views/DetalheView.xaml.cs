using System;
using System.Collections.Generic;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.Views
{
    public partial class DetalheView : ContentPage
    {
        private readonly Veiculos Veiculos;

        private const decimal FREIO_ABS = 800;
        private const decimal AR_CONDICIONADO = 1000;
        private const decimal MP3_PALYER = 500;

        public string TextFreio
        {
            get
            {
                return string.Format("Freio ABS R$ {0}", FREIO_ABS);
            }
        }

        public string TextAr
        {
            get
            {
                return string.Format("Ar-condicionado R$ {0}", AR_CONDICIONADO);
            }
        }


        public string TextMp3
        {
            get
            {
                return string.Format("MP3 Player R$ {0}", MP3_PALYER);
            }
        }

        bool temFreioAbs;
        public bool TemFreio {
            get
            {
                return temFreioAbs;
            }
            set
            {
                temFreioAbs = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool temAr;
        public bool TemAr
        {
            get
            {
                return temAr;
            }
            set
            {
                temAr = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool temMp3;
        public bool TemMp3
        {
            get
            {
                return temMp3;
            }
            set
            {
                temMp3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {               
                return string.Format("Valor Total: R$ {0}", Veiculos.Valor
                    + (TemFreio ? FREIO_ABS : 0) + (temAr ? AR_CONDICIONADO : 0) +
                    (TemMp3 ? MP3_PALYER : 0)) ;
            }
        }

        public DetalheView(Veiculos veiculo)
        {
            InitializeComponent();
            
            this.Veiculos = veiculo;
            this.Title = veiculo.Veiculo;


            this.BindingContext = this;
        }

        void btnProximo_Clicked(System.Object sender, System.EventArgs e)
        {
            Veiculos veiculoParam = Veiculos;

            Navigation.PushAsync(new AgendamentoView(veiculoParam));
        }

        
    }
}
