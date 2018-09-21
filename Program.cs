using System;
using System.Collections.Generic;

namespace Programando
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<int> Lista1 = new List<int>();
            List<int> Lista2 = new List<int>();
            //Lista1.Add(1);
            int Longitud = 9;
            bool pase = false;
            int contador = 1;
            Longitud = Longitud + 2;
            for ( int i=0 ; i < Longitud ; i++ )
            {
                for ( int j = ( Longitud -i ) ; j > 0 ; j--)
                    Console.Write(" ");
                if ( pase )
                {
                    foreach (int vEntero in Lista1)
                    {
                        Console.Write(vEntero+" ");
                    }
                } else
                {
                    //Console.Write("1");
                    if ( contador == 2 )
                    {
                        Console.Write("1");
                        pase = true;
                    }
                    else
                        contador++;
                }
                Console.WriteLine("");
                
                Lista2.Clear();
                Lista2.Add(1);
                for ( int j=0 ; j<(i-1) ;j++)
                {
                    Lista2.Add(Lista1[j]+Lista1[j+1]);
                }
                Lista2.Add(1); 
                
                Lista1.Clear();
                
                foreach (int vEntero in Lista2)
                {
                    Lista1.Add(vEntero);
                }

            }
            /*
            1
            11
            121
            1331
            14641
             */

        }
    }
}
