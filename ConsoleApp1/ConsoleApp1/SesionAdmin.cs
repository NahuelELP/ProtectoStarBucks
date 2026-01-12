using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SesionAdmin
    {
        private string nombreProducto;
        private double precioProducto;
        private DateTime dataProducto;

        private int mes;
        private int dia;
        private int año;
        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        List<Productos> listaDeProductos = new List<Productos>();//deja la lista fuera del while

        Productos producto;
        public void AgregarProductos()
        {
            Console.WriteLine("Nombre del prodcuto a agregar:");
            nombreProducto = Console.ReadLine();
            Console.WriteLine("Precio del Producto a agregar:");
            precioProducto = double.Parse(Console.ReadLine());
            Console.WriteLine("Vencimiento del producto a agregar:\nColoque la fecha de la siguiente manera: 1°año (Enter) 2°mes (Enter) 3°dia");
            año = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            dia = int.Parse(Console.ReadLine());
            dataProducto = new DateTime(año, mes, dia);//Por que muestra los segundo y minutos?
            producto = new Productos(nombreProducto, precioProducto, dataProducto);
            listaDeProductos.Add(producto);
        }
        public void BorrarProductos()
        {
            Console.WriteLine("Pone el nombre del producto que queres borrar:");
            nombreProducto = Console.ReadLine();
            Productos productoBuscado;
            listaDeProductos.Remove(productoBuscado = listaDeProductos.Find(p => p.Nombre == nombreProducto));
        }
        public void VerProductos()
        {
            foreach (Productos p in listaDeProductos)//lista de los productos
            {
                Console.WriteLine("-------------------");
                p.InfoProductos();
                Console.WriteLine("-------------------");
            }
        }
        public void ActualizarProductos()
        {
            Console.WriteLine("Nombre del Productos que quieras Actualizar");
            nombreProducto = Console.ReadLine();
            Productos productoActualizado;
            productoActualizado = listaDeProductos.Find(p => p.Nombre == nombreProducto);
            Console.WriteLine("Que queres actualizar del producto\n1-Nombre\n2-Precio\n3-Vencimiento");
            int input = Int32.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Coloca el nuevo nombre del producto {0}", nombreProducto);
                    productoActualizado.Nombre = nombreProducto;
                    break;
                case 2:
                    Console.WriteLine("Coloca el nuevo precio del producto {0}", nombreProducto);
                    productoActualizado.Precio= double.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Coloca el nuevo vencimiento del producto {0} de la siguiente manera: 1°año (Enter) 2°mes (Enter) 3°dia", nombreProducto);
                    año = int.Parse(Console.ReadLine());
                    mes = int.Parse(Console.ReadLine());
                    dia = int.Parse(Console.ReadLine());
                    productoActualizado.Date = new DateTime(año,mes, dia);
                    break;
            }
        }
        //Agregar producto
        //Borrar Producto
        //Ver Productos
        //Actualizar Productos
    }
}
