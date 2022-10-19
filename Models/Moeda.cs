using System.ComponentModel.DataAnnotations.Schema;

namespace PesquisaCrypto.Models
{
    public class Moeda
    {
        public int MoedaId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        [NotMapped]
        public bool CheckboxMarcado { get; set; }


    }
}
