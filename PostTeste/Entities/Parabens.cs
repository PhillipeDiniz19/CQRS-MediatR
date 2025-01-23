using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostTeste.Entities
{
    public class Parabens
    {
        [Key]
        public int IdParabens { get; set; } // Chave primária
        [ForeignKey("Post")]
        public int PostId { get; set; } // Chave estrangeira para Post
        public string UserName { get; set; }

        // Navegação
        public Post Post { get; set; }
    }
}
