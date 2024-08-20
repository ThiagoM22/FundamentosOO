using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            this.Velocidade += 5;
            Console.WriteLine("A velocidade atual é " + this.Velocidade + "km/h");
        }
        public void Desacelerar()
        {
            if (this.Velocidade <= 0)
            {
                Console.WriteLine("A velocidade chegou a 0 não se pode mais desacelerar.");
            }
            else
            {
                this.Velocidade -= 5;
                Console.WriteLine("A velocidade atual é " + this.Velocidade + "km/h");
            }
        }
    }
}
