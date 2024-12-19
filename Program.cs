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
            · Készíts egy „F02” nevű int típusú statikus metódust. A metódus várjon paraméterként egy egész számokból álló tömböt.
            
            · Deklarálj egy egész szám típusú számláló változót.
            
            · Készíts egy for ciklust, amely a paraméterként várt tömb hosszáig fut. A cikluson belül döntsd el, hogy az adott indexen lévő töm eleme páros szám vagy sem. Ha igen, akkor a számláló változóhoz adj hozzá 1-et.
            
            · A ciklus után return-öld a számláló változót.
            
            · Készíts egy commit-ot „F02 feladat elkészítve” névvel, majd push-old is fel.
        */

        static void F01(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += random.Next(0, 51);
            }
        }

        static int F02(int[] array)
        {
            int counter = 0;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            //Test_1.2.3...
        }
    }
}
