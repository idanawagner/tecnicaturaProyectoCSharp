using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas.Modelos
{
    public class ModeloS : Tesla
    {
        public ModeloS(int anio, double usoActual, string color, double autonomia, double autonomiaActual, int cargas, double frecuenciaService, int asientos, PersonaFisica duenio) 
            : base(anio, usoActual, color, 650, autonomiaActual, cargas, 2000, 5, duenio)
        {
            // No se requiere codigo adicional
        }

        public override string ToString()
        {
            return $"Modelo: ModeloS, Año: {Anio}, Kilometraje Actual: {UsoActual}";
        }

    }
}
