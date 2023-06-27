using Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas
{
    /// En esta clase se hereda de la clase abstracta Persona todo lo descripto en dicho archivo. 
    /// Se establece ademas una lista static de SpaceX donde se iran almacenando los SpaceX que cada persona vaya adquiriendo en el proceso de Alta del vehiculo (cuando se instancie un SpaceX y se le asigne un dueño)
    /// Se establece una Lista de personas juridicas donde se iran almacenando todas las personas juridicas creadas.

    /// Se implementa un constructor que asigne los argumentos pasados a las propiedades de la clase. Este constructor contempla en su sintaxis la herencia de la clase Persona. Tambien incorpora la persona juridica instanciada a las lista de personas juridicas.
    /// Se implementa un metodo de consulta de la lista de personajuridicas y uno de la lista de naves de una persona juridica.
    /// Por ultimo se implementa un método que será utilizado para validad el ID ingresado por el usuario con el fin de asegurarse que no repetiran IDs.
    /// 
    /// 
    /// </summary>
    public class PersonaJuridica : Persona
    {
        private static List<PersonaJuridica> _listaPersonasJuridicas = new List<PersonaJuridica>();
        private static List<SpaceX> _listaNaves = new List<SpaceX>();

        #region CONSTRUCTOR

        public PersonaJuridica(string nombre, int id)
        : base(nombre, id)
        {
            _listaPersonasJuridicas.Add(this);
        }

        #endregion

        #region METODOS

        public void Comprar(SpaceX nave)
        {
            _listaNaves.Add(nave);
        }

        public static List<PersonaJuridica> ListaPersonasJuridicas()
        {
            return _listaPersonasJuridicas;
        }

        public List<SpaceX> ListaNaves()
        {
            return _listaNaves;
        }


        public static bool VerificarIdUnico(int identificador)
        {

            foreach (PersonaJuridica persona in _listaPersonasJuridicas)
            {
                if (persona.Id == identificador)
                {
                    return false; // El ID no es único
                }
            }
            return true; // El ID es único


        }

        #endregion
    }
}
