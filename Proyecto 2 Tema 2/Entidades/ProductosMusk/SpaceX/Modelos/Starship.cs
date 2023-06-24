using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX.Modelos
{
    public class Starship : SpaceX
    {
        public Starship(int anio, double usoActual, string color, double autonomia, double autonomiaActual, int cargas, double frecuenciaService, PersonaJuridica duenio) 
            : base(anio, usoActual, color, 500, autonomiaActual, cargas, 1000,duenio)
        {
            //No requiere codigo adicional
        }

        public override string ToString()
        {
            return $"Modelo: Starship , Año: {Anio}, Horas de uso actuales: {UsoActual}";
        }
    }
}
