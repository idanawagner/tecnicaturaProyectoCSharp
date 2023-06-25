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
       
        public ModeloX(int anio, double usoActual, string color,  double autonomiaActual, int cargas, PersonaFisica duenio, double autonomia = 560, double frecuenciaService = 1000, int asientos = 7)
            : base(anio, usoActual, color, autonomiaActual, cargas, duenio, autonomia, frecuenciaService, asientos)
        {
            // No se requiere código adicional en el constructor
        }


        public override string ToString()
        {
            return $"Modelo: ModeloX, Año: {Anio}, Kilometraje Actual: {UsoActual}";
        }

    }

}
