using Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas
{
    public class PersonaJuridica : Persona
    {
        private static List<PersonaJuridica> _listaPersonasJuridicas = new List<PersonaJuridica>();
        private static List<SpaceX> _listaNaves = new List<SpaceX>();

        public PersonaJuridica(string nombre, int id)
        : base(nombre, id)
        {
            _listaPersonasJuridicas.Add(this);
        }

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

        //public override string ToString()
        //{
        //    return $"CUIT: {this.Id} - Nombre: {this.Nombre}";
        //}
    }

}
