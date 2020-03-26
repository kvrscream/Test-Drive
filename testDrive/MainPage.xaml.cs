using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testDrive.Models;
using testDrive.Views;
using Xamarin.Forms;

namespace testDrive
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            List<Veiculos> veiculos = new List<Veiculos>()
            {
                new Veiculos {Veiculo = "Azera V6", Valor = 60000},
                new Veiculos {Veiculo = "Fiesta 2.0", Valor = 50000},
                new Veiculos {Veiculo = "HB20 S", Valor = 40000}
            };


            listViewVieiculos.ItemsSource = veiculos;
            
        }

        void listViewVieiculos_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Veiculos veiculo = new Veiculos();
            veiculo = (Veiculos)e.Item;
            //Criando alerta
            //this.DisplayAlert("Clicou em", veiculo.Veiculo, "Ok");

            //Navegar para outra página easy
            Navigation.PushAsync(new DetalheView(veiculo: veiculo), true);
            
        }
    }
}
