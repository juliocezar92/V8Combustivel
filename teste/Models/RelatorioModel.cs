using System.ComponentModel.DataAnnotations;

namespace teste.Models
{
    public class RelatorioModel
    {
        public int Id { get; set; }
        public string Bomba { get; set; }
        public string Combustivel { get; set; }
        public string Valor { get; set; }
        public string Pagamento { get; set; }   
       

    }
}
