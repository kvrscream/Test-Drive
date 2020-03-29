using System;
using System.Collections.Generic;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.Views
{
    public partial class AgendamentoView : ContentPage
    {

        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }
        }
        public TimeSpan HoraAgendamento { get; set; }

        public AgendamentoView(Veiculos veiculo)
        {
            InitializeComponent();

            this.Title = veiculo.Veiculo;
            this.BindingContext = this;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Dados Preenchidos", @"Nome: " + Nome + "\n" +
                "Telefone: " + Fone + "\n" +
                "E-mail: "+ Email + "\n"+
                "Data Agendamento:"+ DataAgendamento + "\n" +
                "Hora Agendamento: " + HoraAgendamento


                , "Ok");
        }
    }
}
