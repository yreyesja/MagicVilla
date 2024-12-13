using MagicVilla_API.Modelos.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        { 
            new VillaDto{Id=1, Nombre="Visita a la Piscina", Ocupantes=3,MetrosCuadrados=50},
            new VillaDto{Id=2, Nombre="Visita a la Playa", Ocupantes=4,MetrosCuadrados=80}
        };
    }
}
