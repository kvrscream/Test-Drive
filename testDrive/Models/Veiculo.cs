using System;
namespace testDrive.Models
{
    public class Veiculo
    {

        public const decimal FREIO_ABS = 800;
        public const decimal AR_CONDICIONADO = 1000;
        public const decimal MP3_PALYER = 500;

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R$ {0}", Valor);
            }
        }

        public bool TemFreio { get; set; }
        public bool TemAr { get; set; }
        public bool TemMp3 { get; set; }

        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", Valor
                    + (TemFreio ? FREIO_ABS : 0) + (TemAr ? AR_CONDICIONADO : 0) +
                    (TemMp3 ? MP3_PALYER : 0));
            }
        }

    }   
}
