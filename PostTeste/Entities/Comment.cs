using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostTeste.Entities
{
    public class Comment
    {
        [Key]
        public int IdComments { get; set; } // Chave primária
        [ForeignKey("Post")]
        public int PostId { get; set; } // Chave estrangeira para Post
        public string UserName { get; set; }
        public string Content { get; set; }
        public string UserPhoto { get; set; }
        public string Sigla { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navegação
        public Post Post { get; set; }
    }
}
