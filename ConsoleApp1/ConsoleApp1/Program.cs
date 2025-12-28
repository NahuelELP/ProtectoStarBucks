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

            interfaz.EleccionDeSesion(interfaz.InputSesion);
            interfaz.InterfazDelAdmin();
            interfaz.EleccionCrud(interfaz.InputInterfazAdmin);

        }
    }
}
