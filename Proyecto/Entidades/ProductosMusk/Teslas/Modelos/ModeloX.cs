using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas.Modelos
{
    /// <summary>
    /// En esta clase se hereda de la clase abstracta Tesla todo lo descripto en dicho archivo. Se adicionan un valores predeterminados para algunos atributos especificos. Ellos son:
    /// Autonomia = 560
    /// Frecuencia Service = 1000
    /// Asientos = 7

    /// Se implementa un constructor que asigne los argumentos pasados a las propiedades de la clase. Este constructor contempla en su sintaxis la herencia de la clase Tesla.
    /// 
    /// Se establecen los Getters y los Setters de cada atributo.
    /// 
    /// Se sobreescribe el método ToString().
    /// 
    /// Se sugiere continuar la lectura en Entidades/Duenios/Persona.cs (si aun no se leyó)
    /// 
    /// 
    /// </summary>
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
