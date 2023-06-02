using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace estacionamento.Models
{
    [Table("Estoque")]
    public class EstoqueModel
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Marca")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Column ("Modelo")]
        [Display(Name ="Modelo")]
        public string Modelo { get; set;}

        [Column("Ano")]
        [Display(Name ="Ano")]
        public Int16 Ano { get; set; }

        [Column("Km")]
        [Display(Name ="Km")]
        public int Km { get; set; }

        [Column("Automatico")]
        [Display(Name ="Automático")]
        public bool Automatico { get; set; }

        [Column("Cor")]
        [Display(Name ="Cor")]
        public string Cor { get; set;}

        [Column("Placa")]
        [Display(Name ="Placa")]
        public string Placa { get; set;}

        [Column("Preco")]
        [Display(Name ="Preço")]
        public decimal  Preco { get; set;}

        [Column("Diponivel")]
        [Display(Name = "Disponível")]
        public bool Dispinivel { get; set; }

        [Column("Entrada")]
        [Display(Name = "Entrada")]
        public DateTime Entrada { get; set; }

        [Column("Saida")]
        [Display(Name = "Saída")]
        public DateTime Saida { get; set; }

    }
}
