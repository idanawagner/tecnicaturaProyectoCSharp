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

            duenio.Comprar(this);


            // agregamos el nuevo SpaceX a la lista SpaceX
            _listaSpaceX.Add(this);
        }
        public int Id { get => _id; }
        public PersonaJuridica Duenio { get => _duenio; internal set => _duenio = value; }
        public static List<SpaceX> ListaSpaceX()
        {
            return _listaSpaceX;
        }

        public static void RemoveSpaceX(SpaceX nave)
        {
            _listaSpaceX.Remove(nave);
        }

   

        public string RealizarService()
        {
            double kilometraje = this.UsoActual; // Obtener el kilometraje actual del Tesla

            double serviceRealizados = Math.Floor(kilometraje / this.FrecuenciaService); // Calcular la cantidad de services realizados

            double frecuenciaPropulsion = 1000;
            double frecuenciaNavegacion = 500;            

            StringBuilder reporteService = new StringBuilder(); // Generar el reporte final de services

            for (int i = 1; i <= serviceRealizados; i++)
            {
                int horasUsoService = i * (int)this.FrecuenciaService; // Kilometraje del service actual.


                StringBuilder reporteServiceParcial = new StringBuilder(); // Reporte parcial de cada service
                reporteServiceParcial.AppendLine($"Service {i}:");

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
  
                reporteService.AppendLine(reporteServiceParcial.ToString());

            }

            return reporteService.ToString();
        }


    }
}
