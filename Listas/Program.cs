using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores =
                new List<string>();
            colores.Add("azul");
            colores.Add("verde");
            colores.Add("violeta");
            colores.Add("amarillo");

            colores.RemoveAt(1);
            colores.Remove("amarillo");

            Console.WriteLine("Numero de elemenos: " + colores.Count);

            int indiceColor = 1;

            foreach(string color in colores)
            {
                Console.WriteLine( "Elemento " + indiceColor.ToString() + ": " + color);

                indiceColor++;
            }

            Console.Read();
        }
    }
}
