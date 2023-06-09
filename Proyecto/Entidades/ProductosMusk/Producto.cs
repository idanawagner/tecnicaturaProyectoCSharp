﻿using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk
{
    /// <summary>
    /// En esta clase se implementaron todos aquellos atributos que son comunes a cualquier producto de las empresas de Elon Musk. Ellos son:
    /// Año: que se corresponde al año de fabricacion.
    /// Uso Actual: de acuerdo al producto será el kilometraje de uso o las horas de vuelo que posea.
    /// Color: El color del vehiculo.
    /// Autonomia: de acuerdo al producto será el kilometraje /las horas de vuelo que puede realizar el vehiculo con carga completa de combustible/bateria
    /// Autonomia Actual: de acuerdo al producto será el kilometraje /las horas de vuelo que puede realizar el vehiculo con la carga que tiene disponible.
    /// Cargas: La cantidad de veces que se le realizaron cargas al vehiculo.
    /// Frecuencia Service: de acuerdo al producto será la frecuencia de kilometos/horas de vuelo a los que el vehiculo deba realizarse un service. Cabe aclrar que el service es especifico de cada vehiculo y de acuerdo al kilometraje/horas de vuelos ( tambien se puede interpretar como numero de service) que tiene el vehiculo serán los controles que se le van a realizar.
    /// Los nombres de las variables son representantivos de los atributos descriptos.
    /// Además se agrega una lista static que contendrá todos los productos creados para ser consultados.
    /// 
    /// 
    /// Se implementa un constructor que asigne los argumentos pasados a las propiedades de la clase y que agregue el producto a la lista de productos.
    /// 
    /// Se establecen los Getters y los Setters de cada atributo.
    /// Se implementan dos metodos: uno que permita consultar la lista de productos (aunque no modificarla) es decir, es de "Solo Lectura". Y otro que permita sacar un producto de la lista, pasando como argumento la instancia de la clase correspondiente.
    /// 
    /// Se sugiere continuar la lectura en Entidades/ProductosMusk/Teslas/Tesla.cs
    /// /// </summary>
    public abstract class Producto
    {
        private static List<Producto> _productos = new List<Producto>(); // Lista de productos
        private int _anio;
        private double _usoActual;
        private string _color;
        private double _autonomia;
        private double _autonomiaActual;
        private int _cargas;
        private double _frecuenciaService;


        #region CONSTRUCTOR

        public Producto(int anio, double usoActual, string color, double autonomiaActual, int cargas,  double autonomia, double frecuenciaService)
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
