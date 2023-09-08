using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOPAM_07
{
    public class Raices {
        public int A = 0;
        public int B = 0;
        public int C = 0;

        public Raices(int a, int b, int c) { 
            this.A = a; this.B = b; this.C = c;
        }

        public void obtenerRaices() { /*
            int resultadoMas = Convert.ToInt32((-1 * B + Math.Sqrt(B * B - 4 * A * C)) / 2 * A);
            int resultadoMenos = Convert.ToInt32((-1 * B - Math.Sqrt(B * B - 4 * A * C)) / 2 * A);

            Console.WriteLine($"Raiz 1: {resultadoMas}, raiz 2: {resultadoMenos}");*/

            Console.WriteLine($"Raiz 1: {Convert.ToInt32((-1 * B + Math.Sqrt(B * B - 4 * A * C)) / 2 * A)}, raiz 2: {Convert.ToInt32((-1 * B - Math.Sqrt(B * B - 4 * A * C)) / 2 * A)}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
