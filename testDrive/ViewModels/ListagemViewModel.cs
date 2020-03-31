using System;
using System.Collections.Generic;
using testDrive.Models;

namespace testDrive.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculo().Veiculos;
        }
    }
}
