using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("tb_vendedores")]
    public class VendedorEntity
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public DateTime DataContratacao { get; set; }
        public decimal ComissaoPercentual { get; set; }

        public decimal MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }

}
