using System;
using System.Collections.Generic;

namespace testDrive.Models
{
    public class ListagemVeiculo
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemVeiculo()
        {
            this.Veiculos = new List<Veiculo>()
            {
                new Veiculo {Nome = "Azera V6", Valor = 60000},
                new Veiculo {Nome = "Fiesta 2.0", Valor = 50000},
                new Veiculo {Nome = "HB20 S", Valor = 40000}
            };
        }

    }
}
