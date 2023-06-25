using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX
{
    public abstract class SpaceX : Producto
    {
        private static List<SpaceX> _listaSpaceX = new List<SpaceX>();
        private static int contador = 1;
        private int _id;
        private PersonaJuridica _duenio;

        public SpaceX(int anio, double usoActual, string color, double autonomiaActual, int cargas, PersonaJuridica duenio, double autonomia, double frecuenciaService)
            : base(anio, usoActual, color, autonomiaActual, cargas, autonomia,  frecuenciaService)
        {
            _id = contador;
            contador++;
            _duenio = duenio;


            // agregamos el nuevo SpaceX a la lista SpaceX
            _listaSpaceX.Add(this);
        }
        public int Id { get => _id; }

        public static List<SpaceX> ListaSpaceX()
        {
            return _listaSpaceX;
        }

        public static void RemoveSpaceX(SpaceX nave)
        {
            _listaSpaceX.Remove(nave);
        }

        //FALTA SERVICE
    }
}
