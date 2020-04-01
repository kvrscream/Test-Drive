using System;
using System.Collections.Generic;
using testDrive.Models;
using testDrive.ViewModels;
using Xamarin.Forms;

namespace testDrive.Views
{
    public partial class DetalheView : ContentPage
    {
        public Veiculo Veiculo { get; set; }

        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            
            this.Title = veiculo.Nome;
            this.Veiculo = veiculo;
            this.BindingContext = new DetalheViewModel(veiculo: veiculo);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<Veiculo>(this, "proximo", (msg) =>
            {
                Navigation.PushAsync(new AgendamentoView(this.Veiculo));
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Veiculo>(this, "proximo");
        }

    }
}
