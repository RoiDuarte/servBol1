using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servBol1ej5
{
    internal class Program
    {
        delegate void MyDelegate();
        static void MenuGenerator(string[] opciones, MyDelegate[] p)
        {
            int opcion = 0;
            Console.WriteLine("--MENU--");
            for (int i = 0; i < opciones.Length; i++)
            {

                Console.WriteLine((i + 1) + ".-" + opciones[i]);

            }
            Console.WriteLine(opciones.Length + ".-" + "Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < opciones.Length; i++)
            {
                
            }






        }
        static void Main(string[] args)
        {

        }
    }
}
