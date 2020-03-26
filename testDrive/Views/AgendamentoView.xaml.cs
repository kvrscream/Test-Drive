using System;
using System.Collections.Generic;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.Views
{
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoView(Veiculos veiculo)
        {
            InitializeComponent();

            this.Title = veiculo.Veiculo;
        }
    }
}
