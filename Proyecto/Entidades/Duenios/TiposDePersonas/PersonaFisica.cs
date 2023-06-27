using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas
{
    /// <summary>
    /// En esta clase se hereda de la clase abstracta Persona todo lo descripto en dicho archivo. 
    /// Se establece ademas una lista static de Teslas donde se iran almacenando los Teslas que cada persona vaya adquiriendo en el proceso de Alta del vehiculo (cuando se instancie un Tesla y se le asigne un dueño)
    /// Se establece una Lista de personas fisicas donde se iran almacenando todas las personas fisicas creadas.

    /// Se implementa un constructor que asigne los argumentos pasados a las propiedades de la clase. Este constructor contempla en su sintaxis la herencia de la clase Persona. Tambien incorpora la persona fisica instnaciada a las lista de personas fisicas.
    /// Se implementa un metodo de consulta de la lista de personas fisicas y uno de la lista de autos de una persona fisica.
    /// Por ultimo se implementa un método que será utilizado para validad el ID ingresado por el usuario con el fin de asegurarse que no repetiran IDs.
    /// 
    /// 
    /// 
    /// 
    /// Se sugiere continuar la lectura en Entidades/Duenios/Persona/PerosnaJuridica.cs 
    /// 
    /// 
    /// </summary>
    public class PersonaFisica : Persona
    {
        private static List<PersonaFisica> _listaPersonasFisicas = new List<PersonaFisica>();
        private static List<Tesla> _listaAutos = new List<Tesla>();

        public PersonaFisica(string nombre, int id)
        : base(nombre, id)
        {
            _listaPersonasFisicas.Add(this);
        }

        public void Comprar(Tesla auto)
        {
            _listaAutos.Add(auto);
        }

        public static List<PersonaFisica> ListaPersonasFisicas()
        {
            return _listaPersonasFisicas;
        }

        public List<Tesla> ListaAutos()
        {
           return _listaAutos;
        }


        public static bool VerificarIdUnico(int identificador)
        {

            foreach (PersonaFisica persona in _listaPersonasFisicas)
            {
                if (persona.Id == identificador)
                {
                    return false; // El ID no es único
                }
            }
            return true; // El ID es único


        }

       

    }
}