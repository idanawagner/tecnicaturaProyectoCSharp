using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas
{
    /// <summary>
    /// En esta clase se hereda de la clase abstracta Producto todo lo descripto en dicho archivo. Se adicionan atributos especificos de los Teslas. Ellos son:
    /// Asientos: la cantidad de asientos que posee el Tesla.
    /// Dueño: Quien es el dueño del Tesla. Este atributo es una instancia de la clase Persona Fisica.
    /// 
    /// 
    /// Se agrega además  una atributo id que se asigna de manera automatica en la implentacion del contructor para asegurar que aunque se creen dos Teslas exactamente iguales, posean un atributo unico e irrepetible que los diferencie.
    /// Además se agrega una lista static que contendrá todos los Teslas creados para ser consultados.
    /// Los nombres de las variables son representantivos de los atributos descriptos.
    ///
    /// Se implementa un constructor que asigne los argumentos pasados a las propiedades de la clase y que agregue el Tesla a la lista de Tesla. este constructor contempla en su sintaxis la herencia de la clase Producto.
    /// 
    /// Se establecen los Getters y los Setters de cada atributo.
    /// 
    /// Se implementan tres metodos: uno que permita consultar la lista de Teslas (aunque no modificarla) es decir, es de "Solo Lectura". Y otro que permita sacar un Tesla de la lista, pasando como argumento la instancia de la clase correspondiente. El tercer metodo se llama RealizarEscaneo() y su función es ofrecer un reporte de todos los services realizados con el detalle de que controles se realizo en cada uno.
    /// 
    /// Se sugiere continuar la lectura en Entidades/ProductosMusk/Teslas/Modelos/ModeloX.cs
    /// 
    /// 
    /// </summary>
    public abstract class Tesla : Producto
    {
        private static List<Tesla> _listaTeslas = new List<Tesla>();
        private static int contador = 1;
        private int _id;
        private int _asientos;
        private PersonaFisica _duenio;

        #region CONSTRUCTOR

        public Tesla(int anio, double usoActual, string color, double autonomiaActual, int cargas,PersonaFisica duenio, double autonomia, double frecuenciaService, int asientos)
            : base(anio, usoActual, color, autonomiaActual, cargas, autonomia, frecuenciaService)
        {
            _id = contador; // Se asigna un valor de id unico al Tesla que se instancie.
            contador++; // Se incrementa el contador para que la proxima vez que se intancie cambie el valor del id asignado.
            _asientos = asientos;
            _duenio = duenio;

            // Se agrega el Tesla al nuevo dueño. Este es un metodo implementado en la clase Persona Fisica.
            duenio.Comprar(this);

            // Se agrega el nuevo Tesla a la lista de Teslas.
            _listaTeslas.Add(this);
        }

        #endregion


        #region GETTERS Y SETTERS

        public int Id { get => _id; }
        public int Asientos { get => _asientos; set => _asientos = value; }
        public PersonaFisica Duenio { get => _duenio; internal set => _duenio = value; }

        #endregion


        #region METODOS

        public static List<Tesla> ListaTeslas()
        {
            return _listaTeslas;
        }

        public static void RemoveTesla(Tesla auto) 
        {
            _listaTeslas.Remove(auto);
        }
        /// <summary>
        /// Este método evalua la cantidad de kilometros que posee el Tesla que se está escaneando y en funcion de eso, muestra un reporte. la logica implementada consiste en identificar la cantidad de service que le corresponden al Tesla escaneado en funcion de su kilometraje actual y la frecuencia con la que se debe realizar el service. Se asume que todos los service fueron hechos en tiempo y forma. 
        /// Una vez determinada la cantidad de service, el método evalua qué control debe hacerse sobre el Tesla en funcion del kilometraje que tenga al momento de ese service en particular. En concreto se utilizo un bucle for que iterará tantas veces como service le correspondan al vehiculo y en cada vuelta del bucle (en cada service) se evalua con un if para cada control si le correponde esa revision en ese service o no.
        /// Los controles son:
        /// Control Cinturones de Seguridad: cada 1000km
        /// Control de Baterias: cada 2000km
        /// Control del Sistema de Navegacion: 2500km
        /// Control del Sistema de Traccion: cada 3000km.
        /// Control del motor: cada 3000km. 
        /// </summary>
        /// 
        /// <returns>
        /// Retorna un string. Si el Tesla no ha necesitado ningun service por no tener el uso suficiente, el string retornado será que no corresponde nigun service. Si el vehiculo ha debido realizarse al menos un service, entonces retornara un string que contendra la cantidad de service hechos con el detalle de los controles realizados en cada service.
        /// </returns>
        public string RealizarEscaneo()
        {

           double kilometraje = this.UsoActual; // Obtener el kilometraje actual del Tesla

            double serviceRealizados = Math.Floor(kilometraje / this.FrecuenciaService); // Calcular la cantidad de services realizados
            if (serviceRealizados <= 0) 
            {
                return $"No corresponde ningun service. El vehiculo tiene menos de {this.FrecuenciaService} kilometros";
            }

            double frecuenciaCinturones = 1000; // kilometraje al que se debe hacer el primer control de cinturones.
            double frecuenciaBateria = 2000; // kilometraje al que se debe hacer el primer control de bateria.
            double frecuenciaNavegacion = 2500;// kilometraje al que se debe hacer el primer control de sistema de navegacion.
            double frecuenciaTraccionMotor = 3000; // kilometraje al que se debe hacer el primer control de sistema de traccion y motor.

            StringBuilder reporteService = new StringBuilder(); // Generar el reporte final de services

            for (int i = 1; i <= serviceRealizados; i++) // Bucle for que iterará tantas veces como services se hayan hecho.
            {
                int kilometrajeService = i * (int)this.FrecuenciaService; // Kilometraje del service actual.

                
                StringBuilder reporteServiceParcial = new StringBuilder(); // Reporte parcial de cada service
                reporteServiceParcial.AppendLine($"Service {i}:"); // Encabezado del reporte del service

                // En cada condicional if se evalua si el kilometraje del service en curso se correpsonde con el control correspondiente. Si se realiza el control se agrega el string al repote parcial del service y se actualiza el valor de la variable del control para que se mantenga la frecuencia adecuada.
                if (kilometrajeService >= frecuenciaCinturones)
                {
                    reporteServiceParcial.AppendLine("Revisión de cinturones de seguridad");
                    frecuenciaCinturones+= 1000;
                }

                if (kilometrajeService >= frecuenciaBateria)
                {
                    reporteServiceParcial.AppendLine("Revisión de batería");
                    frecuenciaBateria += 2000;
                }

                if (kilometrajeService >= frecuenciaNavegacion)
                {
                    reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                    frecuenciaNavegacion += 2500;
                }

                if (kilometrajeService >= frecuenciaTraccionMotor )
                {
                    reporteServiceParcial.AppendLine("Revisión de sistema de tracción");
                    reporteServiceParcial.AppendLine("Revisión de motor");
                    frecuenciaTraccionMotor += 3000;

                }

                // Al finalizar el service se agrega al reporte final (que contiene la informacion de todos los service)  el contenido del reporte parcial (el contenido del service en curso).
                reporteService.AppendLine(reporteServiceParcial.ToString());
                
            }

            return reporteService.ToString(); // Al finalizar la iteracion en el bucle for se retorna el reporte final de escaneo.
        }



        #endregion

    }
}
