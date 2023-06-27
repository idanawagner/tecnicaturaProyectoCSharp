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
    /// Autonomia = 800
    /// Frecuencia Service = 3000
    /// Asientos = 6

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
