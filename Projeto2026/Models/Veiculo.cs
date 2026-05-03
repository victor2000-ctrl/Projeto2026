using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto2026.Models

{

    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do veículo é obrigatório.")]
        public string Nome { get; set; }
        public string Placa { get; set; }

        public int AnoFabricacao { get; set; }

        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
