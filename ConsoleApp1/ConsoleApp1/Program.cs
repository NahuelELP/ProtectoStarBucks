using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interfaz interfaz = new Interfaz();

            interfaz.IniInterfaz();//primero
            interfaz.EleccionDeSesion(interfaz.InputSesion);// eleccion de Admin o Persona Normal

            switch (interfaz.InputSesion)
            {
                case "1":
                    SesionAdmin admin = new SesionAdmin();
                    int input = 1;
                    do {
                        interfaz.InterfazDelAdmin();
                        switch (interfaz.InputInterfazAdmin)
                        {
                            case "1":
                                admin.AgregarProductos();
                                Console.WriteLine("Queres vovler al menu de seleccion?\n1-si\n2-no");
                                input = int.Parse(Console.ReadLine());                                
                                Console.Clear();
                                break;
                            case "2":
                                admin.BorrarProductos();
                                Console.WriteLine("Queres vovler al menu de seleccion?\n1-si\n2-no");
                                input = int.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case "3":
                                admin.VerProductos();
                                Console.WriteLine("Queres vovler al menu de seleccion?\n1-si\n2-no");
                                input = int.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            case "4":
                                admin.ActualizarProductos();
                                Console.WriteLine("Queres vovler al menu de seleccion?\n1-si\n2-no");
                                input = int.Parse(Console.ReadLine());
                                Console.Clear();
                                break;
                            default:
                                break;
                        }
                    } while (input == 1);
                    break;
                case "2":
                    Console.WriteLine("hola2");
                    break;
            }
        }
    }
}
