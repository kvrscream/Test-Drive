using System;
namespace testDrive.Models
{
    public class Veiculos
    {

        public string Veiculo { get; set; }
        public decimal Valor { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", Valor);
            }
        }    
    }   
}
