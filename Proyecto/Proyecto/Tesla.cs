using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Tesla
    {
        private int numeroSerie;
        private string modelo;
        private int año;
        private int kilometrajeActual;
        private int KilometrajeService;
        private string color;
        private string dueño;

        public Tesla(int numeroSerie, string modelo, int año, int kilometrajeActual, int kilometrajeService, string color, string dueño)
        {
            this.NumeroSerie = numeroSerie;
            this.Modelo = modelo;
            this.Año = año;
            this.kilometrajeActual = kilometrajeActual;
            this.KilometrajeService = kilometrajeService;
            this.Color = color;
            this.Dueño = dueño;
        }

        public int NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Año { get => año; set => año = value; }
        public int KilometrajeA { get => kilometrajeActual; set => kilometrajeActual = value; }
        public int KilometrajeS1 { get => KilometrajeService; set => KilometrajeService = value; }
        public string Color { get => color; set => color = value; }
        public string Dueño { get => dueño; set => dueño = value; }
    }
}
