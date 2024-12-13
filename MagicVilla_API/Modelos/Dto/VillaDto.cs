using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }

        
        [Required] // para añadir una clase con ctrl + .
        [MaxLength(30)]
        public string Nombre { get; set; } // para añadir una propiedad con prop tab tab

        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
    }
}
