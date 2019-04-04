using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barajeo
{
    class Baraja{

        private List<int> lista;
        public Baraja(List<int> numbers)
        {
            lista = numbers;
        }

        public void imprimir()
        {
           foreach(int lis in lista)
            {
                Console.WriteLine(lis);
                
            }
        }

        public List<int> Mezcla()
        { 
            List<int> List1 = new List<int>();
            List<int> List2 = new List<int>();
            int mitad = (lista.Count / 2);
            int tam = lista.Count;
            int j = 0, k = 0;
           
            for (int i = 0; i < lista.Count; i++)
            {
                if(i < lista.Count / 2)
                {
                    List1.Add(lista.ElementAt(i));
                }
                else
                {
                    List2.Add(lista.ElementAt(mitad));
                    mitad++;
                }
                
            }

            lista.Clear();

            for (int i = 0; i < tam; i ++ )
            {
                if (i % 2 == 0)
                {
                    lista.Add(List1.ElementAt(j));
                    j++;
                }
                else
                {
                    lista.Add(List2.ElementAt(k));
                    k++;
                }
                
            }

            return lista;

        }
    }

   
}
