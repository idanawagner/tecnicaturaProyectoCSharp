using Microsoft.Win32;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Reflection;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Proyecto
{
    //    El Señor E.Musk nos contacta para solicitarnos el diseño e implementación de un sistema básico para registrar información de su empresa Tesla.
    //De ellos quiere guardar el modelo, año, kilometraje actual, kilometraje de Service, color y el Dueño del mismo para mantener estadística y trazabilidad de sus productos.
    //Luego de varias reuniones con el señor Musk, se llegó al acuerdo de realizar el sistema en varias versiones.La primer versión deberán implementar las siguientes funcionalidades:

    // 1. Dar de alta un Tesla. - Hecho con un bucle for donde definimos cuantos autos creamos.
    // 2. Eliminar un Tesla. - Fran
    // 3. Mostrar un listado de los Tesla que ya tuvieron Service. - Juli
    // 4. Reordenar el listado de los Tesla por año. - Se puede hacer con sort o order by?
    // 5. Mostrar el Tesla mas nuevo.

    //Entregar el proyecto en un archivo .ZIP o .RAR y el nombre del mismo debe tener los apellidos de los integrantes (Ej: APELLIDO1_APELLIDO2.ZIP).
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSerie;
            string modelo;
            int anio;
            int kmActuales;
            int kmService;
            bool service;
            string color;
            string duenio;

            List<List<object>> misTeslas = new List<List<object>>();
            List<List<object>> teslasConService = new List<List<object>>();

            menuPrincipal();


            void menuPrincipal()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("------------- Menu Principal ------------------");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("* Alta tesla: 1 ");
                Console.WriteLine("* Eliminar tesla: 2");
                Console.WriteLine("* Listado teslas con service: 3");
                Console.WriteLine("* Listado teslas por anio: 4");
                Console.WriteLine("* Mostrar tesla mas nuevo: 5");
                Console.WriteLine("* Fin del programa: 6");

                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        altaTesla();
                        break;
                    case 2:
                        eliminarTesla();
                        break;
                    case 3:
                        listadoConServ();
                        break;
                    case 4:
                        listadoPorAnio();
                        break;
                    case 5:
                        teslaMasNuevo();
                        break;
                    case 6:
                        fin();
                        break;
                }
            }

            void altaTesla()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("-------------1.Alta de Tesla/s------------------");
                Console.WriteLine("------------------------------------------------");

                Console.WriteLine("¿Cuántos autos deseas crear? (máximo de 5 autos)");
                int cant = int.Parse(Console.ReadLine());
                if ((misTeslas.Count + cant) >= 5)
                {
                    Console.WriteLine("No se pueden crear más de 5 autos");
                    Console.WriteLine("Desea borrar la lista actual? si/no");
                    string borrar = Console.ReadLine();
                    if (borrar == "si")
                    {
                        misTeslas.Clear();
                        misTeslas = new List<List<object>>();
                        menuPrincipal();
                    }
                    else
                    {
                        Console.WriteLine("No se borró la lista");
                        menuPrincipal();
                    }
                }
                else
                {
                    if (misTeslas.Count > 0)
                    {
                        Console.WriteLine("Ya hay autos creados en el listado.");
                        Console.WriteLine(" * Agregas mas a la lista : 1");
                        Console.WriteLine(" * Crear una lista nueva : 2");


                        int respuesta = int.Parse(Console.ReadLine());
                        if (respuesta == 1)
                        {
                            Console.WriteLine("Ingrese los datos solicitados");
                        }
                        else if (respuesta == 2)
                        {
                            misTeslas.Clear();
                            misTeslas = new List<List<object>>();
                        }
                    }

                    for (int i = 0; i < cant; i++)
                    {
                        List<object> Tesla1 = new List<object>();
                        List<object> Tesla2 = new List<object>();
                        List<object> Tesla3 = new List<object>();
                        List<object> Tesla4 = new List<object>();
                        List<object> Tesla5 = new List<object>();
                        Console.WriteLine("Datos del auto: ");

                        // Numero de serie
                        numeroSerie = misTeslas.Count;

                        // Modelo
                        Console.WriteLine("Modelo:");
                        modelo = Console.ReadLine();

                        // Año
                        Console.WriteLine("Año: ");
                        anio = int.Parse(Console.ReadLine());

                        // Kilometraje actual
                        Console.WriteLine("Km actuales: (Ingrese números naturales)");
                        kmActuales = int.Parse(Console.ReadLine());

                        // Kilometraje service
                        Console.WriteLine("Km service: (Ingrese números naturales)");
                        kmService = int.Parse(Console.ReadLine());

                        // Service hecho
                        if (kmService != 0)
                        {
                            service = true;
                        }
                        else
                        {
                            service = false;
                        }

                        // Color
                        Console.WriteLine("Color:");
                        color = Console.ReadLine();

                        // Dueño
                        Console.WriteLine("Dueño:");
                        duenio = Console.ReadLine();

                        Console.WriteLine("");

                        switch (numeroSerie)
                        {
                            case 0:
                                Tesla1.Add(numeroSerie);
                                Tesla1.Add(modelo);
                                Tesla1.Add(anio);
                                Tesla1.Add(kmActuales);
                                Tesla1.Add(kmService);
                                Tesla1.Add(service);
                                Tesla1.Add(color);
                                Tesla1.Add(duenio);

                                misTeslas.Add(Tesla1);
                                break;
                            case 1:
                                Tesla2.Add(numeroSerie);
                                Tesla2.Add(modelo);
                                Tesla2.Add(anio);
                                Tesla2.Add(kmActuales);
                                Tesla2.Add(kmService);
                                Tesla2.Add(service);
                                Tesla2.Add(color);
                                Tesla2.Add(duenio);

                                misTeslas.Add(Tesla2);
                                break;
                            case 2:
                                Tesla3.Add(numeroSerie);
                                Tesla3.Add(modelo);
                                Tesla3.Add(anio);
                                Tesla3.Add(kmActuales);
                                Tesla3.Add(kmService);
                                Tesla3.Add(service);
                                Tesla3.Add(color);
                                Tesla3.Add(duenio);

                                misTeslas.Add(Tesla3);
                                break;
                            case 3:
                                Tesla4.Add(numeroSerie);
                                Tesla4.Add(modelo);
                                Tesla4.Add(anio);
                                Tesla4.Add(kmActuales);
                                Tesla4.Add(kmService);
                                Tesla4.Add(service);
                                Tesla4.Add(color);
                                Tesla4.Add(duenio);

                                misTeslas.Add(Tesla4);
                                break;
                            case 4:
                                Tesla5.Add(numeroSerie);
                                Tesla5.Add(modelo);
                                Tesla5.Add(anio);
                                Tesla5.Add(kmActuales);
                                Tesla5.Add(kmService);
                                Tesla5.Add(service);
                                Tesla5.Add(color);
                                Tesla5.Add(duenio);

                                misTeslas.Add(Tesla5);
                                break;
                        }
                    }
                    listadoTeslas();
                }
                menuPrincipal();

            }

            void listadoTeslas()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("---------------Listado de Teslas----------------");
                Console.WriteLine("------------------------------------------------");

                for (int i = 0; i < misTeslas.Count; i++)
                {
                    for (int j = 0; j < misTeslas[i].Count; j++)
                    {
                        Console.WriteLine(misTeslas[i][j]);
                    }
                    Console.WriteLine("");
                }
                menuPrincipal();
            }

            void eliminarTesla()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("------------2.Eliminar un Tesla-----------------");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Ingrese el índice del Tesla que desea eliminar: ");

                for (int i = 0; i < misTeslas.Count; i++)
                {
                    Console.WriteLine($"Indice {misTeslas[i][0]}: Auto de {misTeslas[i][7]}");
                }

                int indice = int.Parse(Console.ReadLine());
                misTeslas.RemoveAt(indice);
                listadoTeslas();
                menuPrincipal();

            }

            void listadoConServ()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("----3.Listado de Teslas con service hecho-------");
                Console.WriteLine("------------------------------------------------");

                // Separo los teslas con service hecho - Anda
                for (int i = 0; i < misTeslas.Count; i++)
                {
                    for (int j = 0; j < misTeslas[i].Count; j++)
                    {
                        if (misTeslas[i][j] is true)
                        {
                            teslasConService.Add(misTeslas[i]);
                        }

                    }
                    Console.WriteLine("");
                }


                // Recorremos la lista de listas - Anda

                Console.WriteLine("Teslas con service:");
                Console.WriteLine("");

                for (int i = 0; i < teslasConService.Count; i++)
                {
                    for (int j = 0; j < teslasConService[i].Count; j++)
                    {
                        Console.WriteLine(teslasConService[i][j]);

                    }
                    Console.WriteLine("");
                }
                menuPrincipal();
            }

            void listadoPorAnio()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("------4.Listado de Teslas ordenados por año-----");
                Console.WriteLine("------------------------------------------------");

                // Ordenar los autos por año - Anda

                var teslasOrdenados = misTeslas.OrderByDescending(x => x[2]).ToList();

                Console.WriteLine("Lista de Teslas Ordenados");

                for (int i = 0; i < teslasOrdenados.Count; i++)
                {
                    for (int j = 0; j < teslasOrdenados[i].Count; j++)
                    {
                        Console.WriteLine(teslasOrdenados[i][j]);
                    }
                    Console.WriteLine("");
                }
                menuPrincipal();

            }

            void teslaMasNuevo()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("----------------5.Tesla mas nuevo---------------");
                Console.WriteLine("------------------------------------------------");

                var teslasOrdenados = misTeslas.OrderByDescending(x => x[2]).ToList();
                // Tesla mas nuevo
                if (teslasOrdenados.Count > 0)
                {

                    Console.WriteLine($"El tesla mas nuevo es modelo {teslasOrdenados[0][1]}, del año {teslasOrdenados[0][2]} y su dueño es {teslasOrdenados[0][7]}");
                }
                else
                {
                    Console.WriteLine($"El listado de Teslas esta vacio");

                }
                menuPrincipal();

            }

            void fin()
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("----------------Fin del programa.----------------");
                Console.WriteLine("------------------------------------------------");
                Console.ReadLine();

            }
        }
    }
}