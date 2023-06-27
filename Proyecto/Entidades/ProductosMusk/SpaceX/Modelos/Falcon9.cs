using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX.Modelos
{
    /// <summary>
    /// En esta clase se hereda de la clase abstracta SpaceX todo lo descripto en dicho archivo. Se adicionan un valores predeterminados para algunos atributos especificos. Ellos son:
    /// Autonomia = 200
    /// Frecuencia Service = 400
  
    /// Se implementa un constructor que asigne los argumentos pasados a las propiedades de la clase. Este constructor contempla en su sintaxis la herencia de la clase SpaceX.
    /// 
    /// Se establecen los Getters y los Setters de cada atributo.
    /// 
    /// Se sobreescribe el método ToString().
    /// 
    /// Se sugiere continuar la lectura en Entidades/ProductosMusk/SpaceX/Modelos/Starship.cs
    /// 
    /// 
    /// </summary>
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
