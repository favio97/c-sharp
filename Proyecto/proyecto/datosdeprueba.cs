using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {

        Producto p1 = new Producto(1, "Pizza Jamon", 199);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Pizza Peperoni", 199);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Pizza Suprema", 199);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, "Pan de Ajo (4 Unidades)", 89);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, "Alitas Picantes (6 unidades)", 149);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, "Pechurricas (8 Unidades)", 129);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto(7, "Personal (Pepsi)", 29);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto(8, "2 Litros (Pepsi)", 42);
        ListadeProductos.Add(p8);

    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Cliente Mesa 1");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Cliente Mesa 2");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Cliente Mesa 3");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "Cliente Mesa 4");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "Cliente Mesa 5");
        ListadeClientes.Add(c5);

    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre);
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el numero de mesa: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Mesa no encontrada");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("¿DESEA AGREGAR UNA PIZZA? s/n");
            string continuar1 = Console.ReadLine();
            if (continuar1.ToLower() == "n") {
                break;
            }
            Console.WriteLine("*********** INGRESE EL PRODUCTO **********");
            Console.WriteLine(".");
            Console.WriteLine("************ P  I  Z  Z  A  S ************");
            Console.WriteLine("==========================================");
            Console.WriteLine("1 | Pizza Jamon    (12 piezas) | L. 199.00");
            Console.WriteLine("2 | Pizza Peperoni (12 piezas) | L. 199.00");
            Console.WriteLine("3 | Pizza Suprema  (12 piezas) | L. 199.00");


            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("¿DESEA CONTINUAR? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }
        
        while(true)
        {
            Console.WriteLine("¿DESEA AGREGAR UNA ENTRADA? s/n");
            string continuar1 = Console.ReadLine();
            if (continuar1.ToLower() == "n") {
                break;
            }

            Console.WriteLine("*********** INGRESE EL PRODUCTO **********");
            Console.WriteLine(".");
            Console.WriteLine("********** E  N  T  R  A  D  A  S **********");
            Console.WriteLine("============================================");
            Console.WriteLine("4 | Pan de Ajo     (4 Unidades)  | L.  89.00");
            Console.WriteLine("5 | Alitas Picante (6 Unidades)  | L. 149.00");
            Console.WriteLine("6 | Pechurricas    (8 Unidades)  | L. 129.00");

            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("¿DESEA CONTINUAR? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        while(true)
        {
            Console.WriteLine("¿DESEA AGREGAR UNA BEBIDA? s/n");
            string continuar1 = Console.ReadLine();
            if (continuar1.ToLower() == "n") {
                break;
            }

            Console.WriteLine("***** INGRESE EL PRODUCTO ******");
            Console.WriteLine(".");
            Console.WriteLine("****** B  E  B  I  D  A  S *****");
            Console.WriteLine("================================");
            Console.WriteLine("7 | Personal (Pepsi) | L.  29.00");
            Console.WriteLine("8 | 2 Litros (Pepsi) | L.  42.00"); 

            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("¿DESEA CONTINUAR? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo |         Fecha           | Cliente | Total");
        Console.WriteLine("=======================================================");
        Console.WriteLine("");  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.Cliente.Nombre + " | " + orden.Total);
            
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.ReadLine();
        } 

    }

}