using System;
using System.Collections.Generic;
using testDrive.Models;
using Xamarin.Forms;

namespace testDrive.ViewModels
{
    public class ListagemViewModel 
    {
        public List<Veiculo> Veiculos { get; set; }

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

        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculo().Veiculos;
        }
    }
}
