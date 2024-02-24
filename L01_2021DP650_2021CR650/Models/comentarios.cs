using System.ComponentModel.DataAnnotations;

namespace L01_2021DP650_2021CR650.Models
{
    public class comentarios
    {
        [Key]

        public int publicacionId { get; set; }

        public string comentario{ get; set; }

        public int usuarioId { get; set; }
    }
}
