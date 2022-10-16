using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalno_Osmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br1 = 0;
            int br2 = 1;
            int fBr = 0;
            int n;

            Console.WriteLine("Upišite broj n:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                fBr=br1+br2;

                br1=br2;
                br2=fBr;
            }

            Console.WriteLine(fBr);
            Console.ReadKey();
        }
    }
}
