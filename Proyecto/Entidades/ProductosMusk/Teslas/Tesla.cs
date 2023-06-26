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

            StringBuilder reporteService = new StringBuilder(); // Generar el reporte final de services
            
            int a = (int)this.FrecuenciaService;
            int b = (int)this.FrecuenciaService;
            int c = (int)this.FrecuenciaService;

            for (int i = 1; i <= serviceRealizados; i++)
            {
                int kilometrajeService = i * (int)this.FrecuenciaService; // Kilometraje del service actual.
             
                StringBuilder reporteServiceParcial = new StringBuilder(); // Reporte parcial de cada service
                reporteServiceParcial.AppendLine($"Service {i}:");

                reporteServiceParcial.AppendLine("Revision de cinturones de seguridad");

                if (this.FrecuenciaService >= 2000)
                {
                    reporteServiceParcial.AppendLine("Revisión de batería");
                }
                else if (this.FrecuenciaService == 1000)
                {
                    if (a == 2000)
                    {
                        reporteServiceParcial.AppendLine("Revisión de batería");
                    }
                    else if (a == 1000)
                    {
                        a = 2000;
                    }
                }

                if (this.FrecuenciaService == 3000)
                {
                    reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                }
                else if (this.FrecuenciaService == 1000)
                {

                    if (b == 2500)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                        b = 0;
                    }
                    else if (b == 1000)
                    {
                        b = 2000;
                    }
                    else if (b == 2000)
                    {
                        b = 3000;
                    }
                    else if (b == 3000)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                        b = 500;
                    }
                    else if (b == 500)
                    {
                        b = 1500;
                    }
                    else if (b == 1500)
                    {
                        b = 2500;
                    }
                }
                else if (this.FrecuenciaService == 2000)
                {
                    if (b == 2000)
                    {
                        b = 4000;
                    }
                    else if (b == 4000)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                        b = 1500;
                    }
                    else if (b == 1500)
                    {
                        b = 3500;
                    }
                    else if (b == 3500)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                        b = 1000;
                    }
                    else if (b == 1000)
                    {
                        b = 3000;
                    }
                    else if (b == 3000)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                        b = 500;
                    }
                    else if (b == 500)
                    {
                        b = 2500;
                    }
                    else if (b == 2500)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                        b = 0;
                    }
                    else if (b == 0)
                    {
                        b = 2000;
                    }
                }

                if (this.FrecuenciaService == 3000)
                {
                    reporteServiceParcial.AppendLine("Revisión de sistema de tracción");
                    reporteServiceParcial.AppendLine("Revisión de motor");
                }
                else if (this.FrecuenciaService == 2000)
                {
                    if (c == 3000)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de tracción");
                        reporteServiceParcial.AppendLine("Revisión de motor");
                        c = 0;
                    }
                    else if (c == 0)
                    {
                        c = 2000;
                    }
                    else if (c == 2000)
                    {
                        c = 4000;
                    }
                    else if (c == 4000)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de tracción");
                        reporteServiceParcial.AppendLine("Revisión de motor");
                        c = 1000;
                    }
                    else if (c == 1000)
                    {
                        c = 3000;
                    }
                }
                else if (this.FrecuenciaService == 1000)
                {
                    if (c == 3000)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de tracción");
                        reporteServiceParcial.AppendLine("Revisión de motor");
                        c = 0;
                    }
                    else if (c == 2000)
                    {
                        c = 3000;
                    }
                    else if (c == 1000)
                    {
                        c = 2000;
                    }
                    else if (c == 0)
                    {
                        c = 1000;
                    }
                }

                reporteService.AppendLine(reporteServiceParcial.ToString());
                
            }

            return reporteService.ToString();
        }

 
    }
}
