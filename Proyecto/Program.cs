using Proyecto_2_Tema_2.Entidades.ProductosMusk.SpaceX;
using Proyecto_2_Tema_2.Entidades.ProductosMusk.Teslas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proyecto_2_Tema_2
{
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// En este segmento se hace una descripcion general del programa. Luego, en el encabezado de cada archivo se hara la descripcion detallada del contenido del mismo. Particularmente, si se considerase necesario, los métodos tendran descripciones adicionales en su inicio, sumado a aclaraciones en las líneas internas de los mismos en donde se decida como pertienente para la comprension de la logica implementada.

    /// 
    /// Descripcion general del programa: 
    /// Esta es una aplicacion desarrollada en Windows Forms que pretende implementar las funciones solicitadas por el sr. Elon Musk en un Sistema de Gestion que sirva tanto para sus productos Tesla como sus productos SpaceX.
    /// Dichas funcionalidades son:
    /// 1.Dar de alta un Tesla y SpaceX, 
    /// 2.Eliminar un Tesla y SpaceX
    /// 3.Mostrar el Tesla mas nuevo
    /// 4.Escaneo de un vehiculo
    /// 5.Mostrar la cantidad de carga de baterias/combustible de todos los vehiculos.
    /// 
    /// A tal fin, se desarrollo una aplicacion con un formulario principal en donde a traves de un menu lateral izquierdo se puede acceder a formularios que implementan cada una de esas funcionalidades solicitadas. Cabe aclarar que este programa se implementa de manera posterior a la creacion y puesta en marcha de las empresas por lo que se permite tanto el Alta de vehículos ya en uso como nuevos. Asimismo se establece que cada vehiculo dado de alta (nuevo o usado) se le asignará de manera obligatoria un dueño. Es decir no habra productos en existencia sin que tengan un dueño designado.
    /// 
    /// Para implmentar lo pedido se utilizo una estructura de clases abstractas y concretas que, a grandes rasgos, se compone de:
    /// 1. Una clase abstracta Productos, con dos clases hijas abtractas Tesla y SpaceX. La clase abstracta Tesla cuenta con tres clases hijas concretas de acuerdo a cada modelo de Tesla existente: ModeloX, ModelosS y Cybertruck. La clase abstracta SpaceX cuenta con dos clases hijas concretas de acuerdo a cada modelo de SpaceX existente: Falcon9 y Starship.
    /// 2. Una clase abstracta Persona, con dos clases hijas concretas de acuerdo a los distintos tipos de personas posibles: Persona Fisica y Persona Juridica. Las personas fisicas (Humanos) podran adquirir productos Tesla y las personas jurídicas (Empresas, aunque podria escalarse facilmente a que compren otro tipo de personas juridicas como ONGs, Asociaciones Civiles, etc.) podran adquirir productos SpaceX.
    /// 
    /// Se sugiere que, una vez finalizada la lectura de la documentacion de este archivo, se continue la misma en Entidades/ProductosMusk/Producto.cs
    /// 
    /// </summary>
    internal static class Program
    {
        // Inicio de la aplicacion
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
