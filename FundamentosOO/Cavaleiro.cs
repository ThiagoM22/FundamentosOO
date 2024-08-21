using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Cavaleiro : Personagem
    {
        public override void apresentarse()
        {
            Console.WriteLine("Olá meu nome é " + this.Nome + " sou um grande mago e atualmente estou no nível" + this.Nivel);
        }
    }

}

