using Proyecto_2_Tema_2.Entidades.Duenios.TiposDePersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas
{
    public abstract class Tesla : Producto
    {
        private static List<Tesla> _listaTeslas = new List<Tesla>();
        private static int contador = 1;
        private int _id;
        private int _asientos;
        private PersonaFisica _duenio;


        public Tesla(int anio, double usoActual, string color, double autonomiaActual, int cargas,PersonaFisica duenio, double autonomia, double frecuenciaService, int asientos)
            : base(anio, usoActual, color, autonomiaActual, cargas, autonomia, frecuenciaService)
        {
            _id = contador;
            contador++;
            _asientos = asientos;
            _duenio = duenio;

            // Le agregamos el Tesla al nuevo dueño
            duenio.Comprar(this);

            // agregamos el nuevo Tesla a la lista de Teslas
            _listaTeslas.Add(this);
        }

        public int Id { get => _id; }
        public int Asientos { get => _asientos; set => _asientos = value; }
        public PersonaFisica Duenio { get => _duenio; internal set => _duenio = value; }


        public static List<Tesla> ListaTeslas()
        {
            return _listaTeslas;
        }

        public static void RemoveTesla(Tesla auto) 
        {
            _listaTeslas.Remove(auto);
        }

        public string RealizarService()
        {
           double kilometraje = this.UsoActual; // Obtener el kilometraje actual del Tesla

            double serviceRealizados = Math.Floor(kilometraje / this.FrecuenciaService); // Calcular la cantidad de services realizados

            double frecuenciaCinturones = 1000;
            double frecuenciaBateria = 2000;
            double frecuenciaNavegacion = 2500;
            //double frecuenciaMotor = 3000;
            double frecuenciaTraccionMotor = 3000;

            StringBuilder reporteService = new StringBuilder(); // Generar el reporte final de services

            for (int i = 1; i <= serviceRealizados; i++)
            {
                int kilometrajeService = i * (int)this.FrecuenciaService; // Kilometraje del service actual.

                
                StringBuilder reporteServiceParcial = new StringBuilder(); // Reporte parcial de cada service
                reporteServiceParcial.AppendLine($"Service {i}:");

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

                reporteService.AppendLine(reporteServiceParcial.ToString());
                
            }

            return reporteService.ToString();
        }

 
    }
}
