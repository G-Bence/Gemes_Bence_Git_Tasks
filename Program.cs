using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_241213
{
    internal class Program
    {
        /*
            · Készíts egy „F01” nevű void típusú statikus metódust. A metódus várjon paraméterként egy egész számokból álló tömböt.
            
            · Készíts egy Random típusú változót.
            
            · Készíts egy for ciklust, amely 0-tól a tömb hosszáig fut.
            
            · A cikluson belül az aktuális indexű tömb eleméhez adj egész szám típusú értéket a randomizált változóval 1 és 50 között.
            
            · Készíts egy commit-ot „F01 feladat elkészítve” névvel, majd push-old is fel.
        */

        static void F01(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += random.Next(0, 51);
            }
        }

        static void Main(string[] args)
        {
            //Test_1.2.3...
        }
    }
}
