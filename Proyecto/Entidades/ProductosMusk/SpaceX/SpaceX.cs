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


            // agregamos el nuevo Tesla a la lista de Teslas
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

        public string RealizarService()
        {
            double horasUso = this.UsoActual; // Obtener horasUso actual del Tesla

            double serviceRealizados = Math.Floor(horasUso / this.FrecuenciaService); // Calcular la cantidad de services realizados

            StringBuilder reporteService = new StringBuilder(); // Generar el reporte final de services

            for (int i = 1; i <= serviceRealizados; i++)
            {
                int horasService = i * 1000; // Horas del service actual.

                // Agregar escaneos según horasUso del servicio actual
                if (horasService <= horasUso)
                {
                    StringBuilder reporteServiceParcial = new StringBuilder(); // Reporte parcial de cada service
                    reporteServiceParcial.AppendLine($"Service {i}:");

                    if (horasService % 1000 == 0)
                    {
                        reporteServiceParcial.AppendLine("Revisión de cinturones de seguridad");
                    }

                    if (horasService % 2000 == 0)
                    {
                        reporteServiceParcial.AppendLine("Revisión de batería");
                    }

                    if (horasService % 2500 == 0)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de navegación");
                    }

                    if (horasService % 3000 == 0)
                    {
                        reporteServiceParcial.AppendLine("Revisión de sistema de tracción");
                        reporteServiceParcial.AppendLine("Revisión de motor");
                    }

                    reporteService.AppendLine(reporteServiceParcial.ToString());
                }
            }

            return reporteService.ToString();
        }


    }
}
