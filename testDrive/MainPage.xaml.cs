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
        }

        void listViewVieiculos_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo = (Veiculo)e.Item;
            //Criando alerta
            //this.DisplayAlert("Clicou em", veiculo.Veiculo, "Ok");

            //Navegar para outra página easy
            Navigation.PushAsync(new DetalheView(veiculo: veiculo), true);
            
        }
    }
}
