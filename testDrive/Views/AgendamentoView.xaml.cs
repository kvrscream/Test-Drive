using System;
using System.Collections.Generic;
using testDrive.Models;
using testDrive.ViewModels;
using Xamarin.Forms;

namespace testDrive.Views
{
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoViewModel AgendamentoViewModel { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Title = veiculo.Nome;
            this.AgendamentoViewModel = new AgendamentoViewModel(veiculo: veiculo);
            this.BindingContext = this.AgendamentoViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<Agendamento>(this, "agendamento", (msg) =>
            {
                DisplayAlert("Dados Preenchidos", @"Nome: " + AgendamentoViewModel.Agendamento.Nome + "\n" +
               "Telefone: " + AgendamentoViewModel.Agendamento.Fone + "\n" +
               "E-mail: " + AgendamentoViewModel.Agendamento.Email + "\n" +
               "Data Agendamento:" + AgendamentoViewModel.Agendamento.DataAgendamento + "\n" +
               "Hora Agendamento: " + AgendamentoViewModel.Agendamento.HoraAgendamento


               , "Ok");
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "agendamento");
        }

    }
}
