using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Class_241213
{
    internal class Program
    {
        /*
            · Készíts egy „F03” nevű double típusú statikus metódust. A metódus várjon paraméterként egy egész számokból álló tömböt.
            
            · Deklarálj egy double típusú átlag változót.
            
            · Készíts egy for ciklust, amely a paraméterként várt tömb hosszáig fut. A cikluson belül az átlag változóhoz add hozzá az aktuális index helyen lévő tömb elemét.
            
            · A ciklus után az átlag értékét módosítsd úgy, hogy az eredeti értéket elosztod a tömb hosszával.
            
            · Ezek után return-öld az átlagot az új értékével.
            
            · Készíts egy commit-ot „F03 feladat elkészítve” névvel, majd push-old is fel.
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

        static double F03(int[] array)
        {
            double average = 0;

            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }

            return (average / array.Length);
        }

        static void Main(string[] args)
        {
            //Test_1.2.3...
        }
    }
}
