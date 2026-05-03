using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto2026.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public int Valor { get; set; }

        public int Km { get; set; }

        public TipoCombustivel Tipo { get; set; }

        public enum TipoCombustivel
        {
            Gasolina,
            Etanol,
            Diesel,
            Eletrico,
        }

        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }
}