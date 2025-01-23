using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostTeste.Entities
{
    public class Post
    {
        [Key]
        public int PostId { get; set; } // Chave primária
        public string Content { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Siglas { get; set; }
        public string DescricaoLotacao { get; set; }
        public string Images { get; set; }
        public string UserPhoto { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsApproved { get; set; } = false;

        public ICollection<Comment> Comments { get; set; } = null;
        public ICollection<Parabens> ParabensList { get; set; } = null;
    }
}
