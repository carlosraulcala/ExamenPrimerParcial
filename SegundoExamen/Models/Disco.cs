using System.ComponentModel.DataAnnotations;

namespace SegundoExamen.Models
{
    public class Disco
    {
        [Key]
        public int idDisco { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Año { get; set; }
    }
}
