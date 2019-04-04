using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barajeo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = new List<int>( );
            int Acount;

            Console.WriteLine("Numero a Barajear: ");
            Acount = int.Parse(Console.ReadLine());
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Ingrese un numero: ");
                numbers.Add(int.Parse(Console.ReadLine()));
                Console.Clear();
                Acount--;
                if (Acount == 0)
                {
                    break;
                }
                
            }
            
            var Bara = new Baraja(numbers);
            numbers = Bara.Mezcla();

            Console.WriteLine("Tamaño del vector: "+numbers.Count);
            Console.WriteLine("Salida");
            foreach (int lis in numbers)
            {
                Console.WriteLine(lis);

            }
            Console.ReadLine();




        }
    }
}
