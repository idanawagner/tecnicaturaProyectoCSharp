using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas.Modelos
{
    public class Cybertruck : Tesla
    {
        public Cybertruck(int anio, double usoActual, string color, double autonomiaActual, int cargas, PersonaFisica duenio, double autonomia = 800, double frecuenciaService = 3000, int asientos = 6)
    : base(anio, usoActual, color, autonomiaActual, cargas, duenio, autonomia, frecuenciaService, asientos)
        {
            // No se requiere código adicional en el constructor
        }


        public override string ToString()
        {
            return $"Modelo: Cybertruck, Año: {Anio}, Kilometraje Actual: {UsoActual}";
        }

    }
}
