using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioAPI2.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(300)")]
        public string Nome { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public string Cpf { get; set; }
        [ForeignKey("FK_Show")]
        public int Id_Cidade { get; set; }
        public int Idade { get; set; }

    }
}
