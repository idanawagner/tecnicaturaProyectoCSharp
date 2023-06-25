using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX.Modelos
{
    public class Falcon9 : SpaceX
    {
        public Falcon9(int anio, double usoActual, string color, double autonomiaActual, int cargas, PersonaJuridica duenio, double autonomia = 200, double frecuenciaService = 400)
           : base(anio, usoActual, color, autonomiaActual, cargas, duenio, autonomia, frecuenciaService)
        {
            //No se requiere codigo adicional
        }
        public override string ToString()
        {
            return $"Modelo: Falcon 9 , Año: {Anio}, Horas de uso actuales: {UsoActual}";
        }

    }
}
