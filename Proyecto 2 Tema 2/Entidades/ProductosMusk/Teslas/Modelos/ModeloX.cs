using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas.Modelos
{
    public class ModeloX : Tesla
    {
        public ModeloX(int anio, double usoActual, string color, double autonomiaActual, int cargas, PersonaFisica duenio)
            : base(anio, usoActual, color, 560, autonomiaActual, cargas, 1000, 7, duenio)
        {
            // No se requiere código adicional en el constructor
        }


        public override string ToString()
        {
            return $"Modelo: ModeloX, Año: {Anio}, Kilometraje Actual: {UsoActual}";
        }

    }

}
