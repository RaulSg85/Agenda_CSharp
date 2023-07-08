using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Consola
{
    class Program
    {
        static Control_Agenda control = new Control_Agenda(new Agenda());
        static void Main(string[] args)
        {
            string opcion = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Agenda de Contactos");
                ImprimirMenu();
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        control.VerContactos();
                        break;
                    case "2":
                        control.AgregarContacto();
                        break;
                    case "3":
                        control.BorrarUltimoContacto();
                        break;
                    case "4":
                        control.BuscarPorNombre();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                } 
            } while (opcion != "5");


        }

        static void ImprimirMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Ver Contactos");
            sb.AppendLine("2. Agregar Contacto");
            sb.AppendLine("3. Borrar Último Contacto");
            sb.AppendLine("4. Buscar Contacto por Nombre");
            sb.AppendLine("5. Salir");
            sb.Append("Seleccione una opción: ");

            Console.Write(sb.ToString());
        }
    }
}
