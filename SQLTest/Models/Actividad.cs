using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SQLTest.Models
{
    public class Actividad
    {
        [Key]
        public int Actividad_id { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(1024)]
        public string Detalles { get; set; }
        [Required]
        public string Estado_id { get; set; }

        [ForeignKey("Estado_id")]
        public Estado Estado { get; set; }
    }
}
