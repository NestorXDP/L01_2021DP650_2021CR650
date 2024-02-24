using System.ComponentModel.DataAnnotations;

namespace L01_2021DP650_2021CR650.Models
{
    public class publicaciones
    {
        [Key]

        public string titulo { get; set; }

        public string descripcion { get; set; }

        public int usuarioId { get; set; }
    }
}
