using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.ViewModels
{
    public class ListagemViewModel : BaseViewModel
    {
        public ObservableCollection<Veiculo> Veiculos { get; set; }

        private Veiculo veiculoSelecionado;
        public Veiculo VeiculoSelecionado
        {
            get
            {
                return veiculoSelecionado;
            }
            set
            {
                veiculoSelecionado = value;
                if(value != null)
                {   
                    MessagingCenter.Send(veiculoSelecionado, "veiculoSelecionado");
                }
            }
        }

        private bool aguarde;
        public bool Aguarde
        {
            get
            {
                return aguarde;
            }
            set
            {
                aguarde = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Aguarde));
            }
        }


        public ListagemViewModel()
        {
            this.Veiculos = new ObservableCollection<Veiculo>();
        }

        public async Task getVeiculos()
        {
            string urlVeiculos = "https://aluracar.herokuapp.com/";
            try
            {
                Aguarde = true;
                HttpClient client = new HttpClient();
                string resultado = await client.GetStringAsync(urlVeiculos);
                VeiculoJson[] veiculoJson = JsonConvert.DeserializeObject<VeiculoJson[]>(resultado);

                foreach (VeiculoJson item in veiculoJson)
                {
                    this.Veiculos.Add(new Veiculo{
                        Nome = item.nome.ToString(),
                        Valor = decimal.Parse(item.preco)
                    });
                }

                Aguarde = false;
            } catch(Exception ex)
            {
                throw ex;
            }
            
        }




    }

}
