using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace FundamentosOO
{
    public class Mago : Personagem
    {
        int contagemNivel = 1;

        public override void apresentarse()
        {
            Console.WriteLine("Olá meu nome é " + this.Nome + " sou um grande mago e atualmente estou no nível " + this.Nivel);
        }
        public override int atacar()
        {
            int pontosAtaque = 0;

            pontosAtaque = this.Inteligencia + this.ArmaForc;

            return pontosAtaque;
        }
        public override void evoluir()
        {

            if (this.xp >= 100)
            {
                this.Nivel += 1;
                this.Forca += 1;
                this.Inteligencia += 5;
                this.Agilidade += 5;
                this.xp = 0;
                this.Vida = 200;
                Console.WriteLine(this.Nome + " evoluiiu para o Nível:" + this.Nivel + ". Todos seus atributos aumentaram:\n Força: " + this.Forca + "\n Agilidade: " + this.Agilidade + "\n Inteligência: " + this.Inteligencia + "\n Vida: " + this.Vida + "\n");
                Console.WriteLine("========================================================= \n");

                contagemNivel++;

            }
            if (contagemNivel == 5)
            {
                this.ArmaForc += 10;
                Console.WriteLine("Parece que sua arma evoluiu seu dano agora é de: " + this.ArmaForc);
                contagemNivel = 0;

            }


        }
    }
}