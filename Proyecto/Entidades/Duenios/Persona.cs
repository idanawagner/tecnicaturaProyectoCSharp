using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.Duenios
{
    /// <summary>
    /// En esta clase se implementaron todos aquellos atributos que son comunes a ambos tipos de personas. Ellos son:
    /// Nombre: Nombre de la persona fisica o juridica
    /// ID: numero unico identificatorio del cliente. Se aclara que los id no se pueden repetir entre personas del mismo tipo aunqie si entre personas de distinto tipo. 
    
    /// Los nombres de las variables son representantivos de los atributos descriptos.
    
    /// Se implementa un constructor que asigne los argumentos pasados a las propiedades de la clase.
    /// 
    /// Se establecen los Getters de cada atributo y el Setter del atributo nombre ya que ID no podra ser modificado, solo consultado.
    /// Se sobreescribe el método ToString()
    /// 
    /// Se sugiere continuar la lectura en Entidades/Duenios/TiposDePersonas/PersonaFisica.cs
    /// /// </summary>
    public abstract class Persona
    {
        private string _nombre;
        private int _id;

        protected Persona(string nombre, int id)
        {
            _nombre=nombre;
            _id=id;
        }

        public string Nombre { get => _nombre; set => _nombre=value; }
        public int Id { get => _id; }

        public override string ToString()
        {
            return $"ID: {this.Id} - Nombre: {this.Nombre}";
        }


    }
}
