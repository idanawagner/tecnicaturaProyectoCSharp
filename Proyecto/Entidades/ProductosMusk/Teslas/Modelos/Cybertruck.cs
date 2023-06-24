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
        public Cybertruck(int anio, double usoActual, string color, double autonomia, double autonomiaActual, int cargas, double frecuenciaService, int asientos, PersonaFisica duenio) 
            : base(anio, usoActual, color, 800, autonomiaActual, cargas, 3000, 6, duenio)
        {
            // No se requiere codigo adicional
        }

        public override string ToString()
        {
            return $"Modelo: Cybertruck, Año: {Anio}, Kilometraje Actual: {UsoActual}";
        }

    }
}
