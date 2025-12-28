using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Interfaz
    {
        private string inputSesion;
        private string inputInterfazAdmin;
        public string InputInterfazAdmin
        {
            get
            {
                return inputInterfazAdmin;
            }
            set
            {
                inputInterfazAdmin = value; //validar
            }
        }
        public string InputSesion
        {
            get
            {
                return inputSesion;
            }
            set
            {
                inputSesion = value;//validar
            }
        }
        public void IniInterfaz()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Bienvenido a Starbucks");
            Console.WriteLine("Sesion Admin:(Presione 1)");
            Console.WriteLine("Sesion Normal:(Presione 2)");
            Console.WriteLine("---------------------------");
            InputSesion = Console.ReadLine();
            Console.Clear();
        }//Interfaz inicial
        public void InterfazSesionAdmin()
        {
            SesionAdmin InicioSesionAdmin = new SesionAdmin();

            Console.WriteLine("----------------");
            Console.WriteLine("-Sesion Admin-");
            Console.WriteLine("Nombre:");
            InicioSesionAdmin.Nombre = Console.ReadLine();
            Console.WriteLine("Contraseña:");
            InicioSesionAdmin.Contraseña = Console.ReadLine();
        }//Interfaz inicio sesion del admin
        public void InterfazSesionNormal()
        {
            SesionNormal InicioSesionNormal = new SesionNormal();
            Console.WriteLine("----------------");
            Console.WriteLine("-Sesion Normal-");
            Console.WriteLine("Nombre:");
            InicioSesionNormal.Nombre = Console.ReadLine();
            Console.WriteLine("Contraseña:");
            InicioSesionNormal.Contraseña = Console.ReadLine();
        }//Interfaz inicio sesion noraml
        public void InterfazDelAdmin()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Agregar Producto (Presione 1)");
            Console.WriteLine("Borrar Producto (Presione 2)");
            Console.WriteLine("Ver Producto/s (Presione 3)");
            Console.WriteLine("Editar Producto (Presione 4)");
            InputInterfazAdmin = Console.ReadLine();
        }//Interfaz Del CRUD
        public void EleccionCrud(string opcion)
        {
            switch(opcion)
            {
                case "1":
                    Console.WriteLine("eleccion 1"); //clases heredadas validas? rangos
                    break;
                case "2":
                    Console.WriteLine("eleccion 2");
                    break;
                case "3":
                    Console.WriteLine("eleccion 3");
                    break;
                case "4":
                    Console.WriteLine("eleccion 4");
                    break;
            }
        }//Eleccion de CRUD
        public void EleccionDeSesion(string opcion)
        {
            switch(opcion)
            {
                case "1":
                    InterfazSesionAdmin();
                    Console.Clear();
                    break;
                case "2":
                    InterfazSesionNormal();
                    Console.Clear();
                    break;
                default:
                    break;
            }
        }//Eleccion de cual interfaz de inisesion mostrar
    }
}
