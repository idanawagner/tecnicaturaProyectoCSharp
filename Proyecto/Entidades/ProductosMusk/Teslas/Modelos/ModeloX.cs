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
        private const double AUTONOMIA = 560;
        private const int ASIENTOS = 7;
        private const double FRECUENCIASERVICE = 1000;
        public ModeloX(int anio, double usoActual, string color, double autonomia, double autonomiaActual, int cargas, double frecuenciaService, int asientos, PersonaFisica duenio)
            : base(anio, usoActual, color, AUTONOMIA, autonomiaActual, cargas, FRECUENCIASERVICE, ASIENTOS, duenio)
        {
            // No se requiere código adicional en el constructor
        }


        public override string ToString()
        {
            return $"Modelo: ModeloX, Año: {Anio}, Kilometraje Actual: {UsoActual}";
        }

    }

}
