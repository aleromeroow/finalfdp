using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalFDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables principales
            char ingreserol;
            char primeravez;

            //admin variables
            string[] usuarioadmin = new string[1];
            string[] contraseñaadmin = new string[1];


            Console.WriteLine("¿Es la primera vez que ingresa?:" + "\n" + "1. Si (ingrese S)" + "\n" + "2. No (ingrese N)");
            primeravez = char.Parse(Console.ReadLine());


            if (primeravez == 'S' || primeravez == 's')
            {
                Console.WriteLine("Ingrese su rol:" + "\n" + "1. Administrador (ingrese A)" + "\n" + "2. Cajero (ingrese C)");
                ingreserol = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese su rol:" + "\n" + "1. Administrador (ingrese A)" + "\n" + "2. Cajero (ingrese C)");
            ingreserol = char.Parse(Console.ReadLine());



            if (ingreserol == 'A' || ingreserol == 'a')
            {
                
            }





        }
    }
}
