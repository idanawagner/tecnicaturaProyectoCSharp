using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk
{
    public abstract class Producto
    {
        private static List<Producto> _productos = new List<Producto>();
        private int _anio;
        private double _usoActual;
        private string _color;
        private double _autonomia;
        private double _autonomiaActual;
        private int _cargas;
        private double _frecuenciaService;


        #region CONSTRUCTOR

        public Producto(int anio, double usoActual, string color, double autonomia, double autonomiaActual, int cargas, double frecuenciaService)
        {
            _productos.Add(this); 
            Anio = anio;
            UsoActual = usoActual;
            Color = color;
            Autonomia = autonomia;
            AutonomiaActual = autonomiaActual;
            Cargas = cargas;
            FrecuenciaService = frecuenciaService;

        }

        #endregion


        #region GETTERS Y SETTERS
        public int Anio { get => _anio; set => _anio = value; }
        public double UsoActual { get => _usoActual; set => _usoActual = value; }
        public string Color { get => _color; set => _color = value; }
        public double Autonomia { get => _autonomia; set => _autonomia = value; }
        public double AutonomiaActual { get => _autonomiaActual; set => _autonomiaActual = value; }
        public int Cargas { get => _cargas; set => _cargas = value; }
        public double FrecuenciaService { get => _frecuenciaService; set => _frecuenciaService = value; }

        #endregion

        #region Métodos
        public static List<Producto> ListaProductos()
        {
            return _productos;
        }

        public static void RemoveProducto(Producto vehiculo)
        {
            _productos.Remove(vehiculo);
        }

        #endregion
    }
}
