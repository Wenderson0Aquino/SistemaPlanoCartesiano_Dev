using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPlanoCartesiano
{
    internal class Ponto
    {
        double x;
        double y;

        //CRIA UM PONTO NAS COORDENADAS (0,0):

        public Ponto ()
        {
            this.x = 0; 
            this.y = 0;
        }

        //RECEBE DE INÍCIO AS COORDENADAS:

        public Ponto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Ponto(Ponto outroPonto) //NESSE CASO, ELE ESTÁ PEGANDO COMO POR EXEMPLO O PONTO 2 COMO PARÂMETRO DE ENTRADA PARA O PONTO 3!
        {
            this.y = outroPonto.y;
            this.x = outroPonto.x;       
        }

        //RETORNAR OS VALORES:

        public double getX()
        {
            return this.x;
        }

        public double getY()
        {
            return this.y;
        }

        //MODIFICAR OS VALORES:

        public void SetX(double X)
        {
            this.x = X;
        }
        public void SetY(double y)
        {
            this.y = y;
        }

        public void CalcularDistancia(Ponto outroPonto)
        {
            double x = this.x - outroPonto.x;
            double y = this.y - outroPonto.y;
            double distancia = Math.Sqrt(x * x + y * y);
            Console.WriteLine(distancia);
        }
    }
}
