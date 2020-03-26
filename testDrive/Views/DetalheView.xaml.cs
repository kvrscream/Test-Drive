using System;
using System.Collections.Generic;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.Views
{
    public partial class DetalheView : ContentPage
    {
        private readonly Veiculos Veiculos;

        public DetalheView(Veiculos veiculo)
        {
            InitializeComponent();
            
            this.Veiculos = veiculo;
            this.Title = veiculo.Veiculo;
        }

        void btnProximo_Clicked(System.Object sender, System.EventArgs e)
        {
            Veiculos veiculoParam = Veiculos;

            Navigation.PushAsync(new AgendamentoView(veiculoParam));
        }

    }
}
