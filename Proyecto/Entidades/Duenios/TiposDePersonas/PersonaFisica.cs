using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas
{
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

        public override string ToString()
        {
            return $"CUIL: {this.Id} - Nombre: {this.Nombre}";
        }

    }
}