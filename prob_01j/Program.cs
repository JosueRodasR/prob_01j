using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob_01j
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = 0;
            string fruta;
            int precio = 0;

            Console.WriteLine("escriba el tipo de fruta a llevar:");
            fruta = Console.ReadLine();
            Console.WriteLine("ingrese el numero de kilometros que debe recorrer:");
            km = int.Parse(Console.ReadLine());
            switch(fruta)
            {
                case "naranja":
                    if(km < 30)
                    {
                        precio = 2;
                    }
                    else 
                    {
                        precio = 4;
                    }
                break;

                case "fresa":
                    if(km < 30)
                    {
                        precio = 6;
                    }
                    else
                    {
                        precio = 9;
                    }
                break;

                case "mango":
                    if (km < 30)
                    {
                        precio = 3;
                    }
                    else
                    {
                        precio = 5;
                    }
                break;   
                    
            }
            Console.WriteLine("el precio de la fruta escogida es:");
            Console.WriteLine(precio);
            Console.ReadKey();
        }
    }
}
