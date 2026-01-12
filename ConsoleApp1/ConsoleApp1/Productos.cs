using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Productos
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public DateTime Date { get; set; }

        public Productos (string nombre, double precio, DateTime date)
        {
            Nombre = nombre;
            Precio = precio;
            Date = date;
        }
        public void InfoProductos()
        {
            Console.WriteLine("Producto: {0}\nPrecio: {1}\nVencimento: {2}",Nombre, Precio, Date);
        }
    }
}
