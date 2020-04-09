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

            MessagingCenter.Subscribe<Agendamento>(this, "agendamento", async (msg) =>
            {

                bool confirma = await DisplayAlert("Salvar Agendamento",
                    "Deseja mesmo salvar este agendamento?",
                    "Sim", "Não");

                if (confirma)
                {
                    this.AgendamentoViewModel.SalvaAgendamento();
                }

            });

            MessagingCenter.Subscribe<Agendamento>(this, "sucessoAgendamento", (msg) =>
            {
                DisplayAlert("Agendamento", "Agendamento salvo com sucesso!", "Ok");
            });


            MessagingCenter.Subscribe<ArgumentException>(this, "erroAgendamento", (msg) =>
            {
                DisplayAlert("Agendamento", "Falha ao agendar o test-drive! Tente novamente mais tarde.", "Ok");
            });
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "agendamento");
            MessagingCenter.Unsubscribe<Agendamento>(this, "sucessoAgendamento");
            MessagingCenter.Unsubscribe<ArgumentException>(this, "erroAgendamento");
        }

        

    }
}
