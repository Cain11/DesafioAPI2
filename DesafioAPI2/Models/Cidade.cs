using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioAPI2.Models
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Nome { get; set; }
        [Column(TypeName = "nvarchar(2)")]
        public string Uf { get; set; }

    }
}
