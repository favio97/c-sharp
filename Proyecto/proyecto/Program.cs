using System;

namespace _10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("********** P  I  Z  Z  A   H  U  T **********");
                Console.WriteLine("BIENVENIDO AL SISTEMA DE ORDENES DE PIZZA HUT");
                Console.WriteLine("ELIGA UNA OPCION");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Productos");
                Console.WriteLine("2 - Crear Orden");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Lista de Ordenes");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.CrearOrden();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.ListarOrdenes();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}
