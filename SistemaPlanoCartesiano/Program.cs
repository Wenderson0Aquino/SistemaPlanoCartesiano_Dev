using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPlanoCartesiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ponto ponto1 = new Ponto(3,4);
            Ponto ponto2 = new Ponto(5,6);
            Ponto ponto3 = new Ponto(ponto2);
          
            ponto1.CalcularDistancia(ponto2);
            Console.ReadKey();
        }
    }
}
