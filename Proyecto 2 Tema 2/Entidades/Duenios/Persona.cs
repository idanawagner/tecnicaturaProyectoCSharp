using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.Duenios
{
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


    }
}
