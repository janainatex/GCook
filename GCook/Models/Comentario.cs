using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;
[Table("Comentario")]
    public class Comentario
    {
        [Key]

        public int Id {get; set;}

        public int ReceitaId {get; set;}
        [ForeignKey("ReceitaId")]

        public Receita Receita {get; set;}

        [Required]

        public string UsuarioId {get; set;}


        public DateTime DataComentario {get; set;} = DateTime.Now;

        [StringLength(300)]
        public string TextoComentario {get; set;}

    }
