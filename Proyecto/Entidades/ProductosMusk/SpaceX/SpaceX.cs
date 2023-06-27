using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX
{
    /// <summary>
    /// En esta clase se hereda de la clase abstracta Producto todo lo descripto en dicho archivo. Se adiciona un atributo especifico de los SpaceX:
    /// Dueño: Quien es el dueño del SpaceX. Este atributo es una instancia de la clase Persona Juridica.
    /// 
    /// 
    /// Se agrega además  una atributo id que se asigna de manera automatica en la implentacion del contructor para asegurar que aunque se creen dos SpaceX exactamente iguales, posean un atributo unico e irrepetible que los diferencie.
    /// Además se agrega una lista static que contendrá todos los SpaceX creados para ser consultados.
    /// Los nombres de las variables son representantivos de los atributos descriptos.
    ///
    /// Se implementa un constructor que asigne los argumentos pasados a las propiedades de la clase y que agregue el SpaceX a la lista de SpaceX. Este constructor contempla en su sintaxis la herencia de la clase Producto.
    /// 
    /// Se establecen los Getters y los Setters de cada atributo.
    /// 
    /// Se implementan tres metodos: uno que permita consultar la lista de SpaceX (aunque no modificarla) es decir, es de "Solo Lectura". Y otro que permita sacar un SpaceX de la lista, pasando como argumento la instancia de la clase correspondiente. El tercer metodo se llama RealizarEscaneo() y su función es ofrecer un reporte de todos los services realizados con el detalle de que controles se realizo en cada uno.
    /// 
    /// Se sugiere continuar la lectura en Entidades/ProductosMusk/SpaceX/Modelos/Falcon9.cs
    /// 
    /// 
    /// </summary>
    public abstract class SpaceX : Producto
    {
        private static List<SpaceX> _listaSpaceX = new List<SpaceX>();
        private static int contador = 1;
        private int _id;
        private PersonaJuridica _duenio;

        #region CONSTRUCTOR

        public SpaceX(int anio, double usoActual, string color, double autonomiaActual, int cargas, PersonaJuridica duenio, double autonomia, double frecuenciaService)
            : base(anio, usoActual, color, autonomiaActual, cargas, autonomia,  frecuenciaService)
        {
            _id = contador;// Se asigna un valor de id unico al SpaceX que se instancie.
            contador++; // Se incrementa el contador para que la proxima vez que se intancie cambie el valor del id asignado.
            _duenio = duenio;

            // Se agrega el SpaceX al nuevo dueño. Este es un metodo implementado en la clase Persona Juridica.
            duenio.Comprar(this);


            // Se agrega el nuevo SpaceX a la lista SpaceX
            _listaSpaceX.Add(this);
        }
        #endregion

        #region GETTERS Y SETTERS
        public int Id { get => _id; }
        public PersonaJuridica Duenio { get => _duenio; internal set => _duenio = value; }

        #endregion

        #region METODOS
        public static List<SpaceX> ListaSpaceX()
        {
            return _listaSpaceX;
        }

        public static void RemoveSpaceX(SpaceX nave)
        {
            _listaSpaceX.Remove(nave);
        }


        /// <summary>
        /// Este método evalua la cantidad de horas de vuelo que posee el SpaceX que se está escaneando y en funcion de eso, muestra un reporte. la logica implementada consiste en identificar la cantidad de service que le corresponden al SpaceX escaneado en funcion de sus horas de vuelo y la frecuencia con la que se debe realizar el service. Se asume que todos los service fueron hechos en tiempo y forma. 
        /// Una vez determinada la cantidad de service, el método evalua qué control debe hacerse sobre el SpaceX en funcion de las horas de vuelo que tenga al momento de ese service en particular. En concreto se utilizo un bucle for que iterará tantas veces como service le correspondan al vehiculo y en cada vuelta del bucle (en cada service) se evalua con un if para cada control si le correponde esa revision en ese service o no.
        /// Los controles son:
        /// Control del Sistema de Propulsion: cada 1000Hs
        ///  Control del Sistema de Navegacion: cada 500Hs

        /// </summary>
        /// 
        /// <returns>
        /// Retorna un string. Si el SpaceX no ha necesitado ningun service por no tener el uso suficiente, el string retornado estará vacío. Si el vehiculo ha debido realizarse al menos un service, entonces retornara un string que contendra la cantidad de services hechos con el detalle de los controles realizados en cada service.
        /// </returns>
        public string RealizarService()
        {
            double horasDeVueloActual = this.UsoActual;  // Obtener las horas de vuelo actual del SpaceX

            double serviceRealizados = Math.Floor(horasDeVueloActual / this.FrecuenciaService); // Calcular la cantidad de services realizados

            double frecuenciaPropulsion = 1000; // horas de vuelos a las que se debe hacer el primer control del sistema de propulsion
            double frecuenciaNavegacion = 500; // horas de vuelos a las que se debe hacer el primer control del sistema de navegacion         

            StringBuilder reporteService = new StringBuilder(); // Generar el reporte final de services

            for (int i = 1; i <= serviceRealizados; i++) // Bucle for que iterará tantas veces como services se hayan hecho.
            {
                int horasUsoService = i * (int)this.FrecuenciaService; // Horas de uso del service actual.


                StringBuilder reporteServiceParcial = new StringBuilder(); // Reporte parcial de cada service
                reporteServiceParcial.AppendLine($"Service {i}:"); // Encabezado del reporte del service
                
                // En cada condicional if se evalua si las horas de vuelo del service en curso se correpsonde con el control correspondiente. Si se realiza el control se agrega el string al repote parcial del service y se actualiza el valor de la variable del control para que se mantenga la frecuencia adecuada.

                if (horasUsoService >= frecuenciaPropulsion)
                {
                    reporteServiceParcial.AppendLine("Revisión de sistema de propulsion");
                    frecuenciaPropulsion+= 1000;
                }

                if (horasUsoService >= frecuenciaNavegacion)
                {
                    reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                    frecuenciaNavegacion += 500;
                }

                if (reporteServiceParcial.Length < 20)
                {
                    reporteServiceParcial.AppendLine("No corresponden chequeos.");
                }
                // Al finalizar el service se agrega al reporte final (que contiene la informacion de todos los service)  el contenido del reporte parcial (el contenido del service en curso).
                reporteService.AppendLine(reporteServiceParcial.ToString());

            }

            return reporteService.ToString();// Al finalizar la iteracion en el bucle for se retorna el reporte final de escaneo.
        }

        #endregion
    }
}
