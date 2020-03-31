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

        void btnProximo_Clicked(System.Object sender, System.EventArgs e)
        {
            Veiculo veiculoParam = Veiculo;

            Navigation.PushAsync(new AgendamentoView(veiculoParam));
        }

        
    }
}
