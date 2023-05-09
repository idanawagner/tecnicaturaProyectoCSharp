using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//El Señor E. Musk nos contacta para solicitarnos el diseño e implementación de un sistema básico para registrar información de su empresa Tesla.

//De ellos quiere guardar el modelo, año, kilometraje actual, kilometraje de Service, color y el Dueño del mismo para mantener estadística y trazabilidad 
//de sus productos.

//Luego de varias reuniones con el señor Musk, se llegó al acuerdo de realizar el sistema en varias versiones. 
//La primer versión deberán implementar las siguientes funcionalidades:

//1.Dar de alta un Tesla

//2. Eliminar un Tesla.

//3. Mostrar un listado de los Tesla que ya tuvieron Service.

//4. Reordenar el listado de los Tesla por año.

//5. Mostrar el Tesla mas nuevo.

//Entregar el proyecto en un archivo .ZIP o .RAR y el nombre del mismo debe tener los apellidos de los integrantes (Ej: APELLIDO1_APELLIDO2.ZIP).

namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaAutosService = new List<Tesla>();
            var listaAutos = new List<Tesla>();
            var auto = new Tesla(10000, "Bitcoin", 2020, 3000, 300, "Azul", "Juan");
            var auto1 = new Tesla(11000,"BitFast", 2020, 2090, 0, "Verde", "Raul");
            var auto2 = new Tesla(11100, "BitSlow", 2019, 4000, 500, "Naranja", "Pepe");
            var auto3 = new Tesla(11000, "Ventura", 2021, 1002, 200, "Violeta", "Salmani");

            listaAutos.Add(auto);
            listaAutos.Add(auto1);
            listaAutos.Add(auto2);
            listaAutos.Add(auto3);
            Console.WriteLine($" La lista de Teslas consta de {listaAutos.Count} elementos.");
            Console.ReadLine();

            listaAutos.RemoveAt(0);
            Console.WriteLine($" La lista de Teslas consta de {listaAutos.Count} elementos.");
            Console.ReadLine();

            Console.WriteLine("Lista de autos que tuvieron service:");
           
            foreach (var i in listaAutos)
            {
                if (i.KilometrajeS1 != 0)
                {
                    listaAutosService.Add(i);
                    Console.WriteLine($" numero de serie: {i.NumeroSerie}");
                }
            }
            List<Tesla> listaAutosOrdenada = listaAutos.OrderBy(tesla => tesla.Año).ToList();
            Console.WriteLine($" El auto mas nuevo es: {listaAutosOrdenada[0].Modelo}, del año {listaAutosOrdenada[0].Año}, perteneciente a {listaAutosOrdenada[0].Dueño}");
            Console.ReadLine();

        }
    }
}
