using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Mago : Personagem
    {

        public override void apresentarse()
        {
            Console.WriteLine("Olá meu nome é " + this.Nome + " sou um grande mago e atualmente estou no nível " + this.Nivel);
        }
        public override int atacar()
        {
            int pontosAtaque = 0;

            pontosAtaque = (this.Forca + this.Agilidade + this.Inteligencia + this.Vida) / 4;

            return pontosAtaque;
        }

        public virtual void batalha(Personagem p)
        {
            this.apresentarse();
            p.apresentarse();
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 1;
                }
                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine(this.Nome + " acertou um ataque em " + p.Nome + " um dano de: " + danoDeVida);
                Console.WriteLine(p.Nome + " está com " + p.Vida + " pontos de HP;");
                Console.WriteLine("=========================================================");


                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine(p.Nome + " acertou um ataque em " + this.Nome + " um dano de: " + danoDeVida2);
                Console.WriteLine(this.Nome + " está com " + this.Vida + " pontos de HP;");
                Console.WriteLine("=========================================================");

                if (p.Vida <= 0)
                {
                    vencedor = true;
                }
                else if (this.Vida <= 0)
                {
                    vencedor = true;
                }

            }
            if (p.Vida <= 0)
            {
                p.Vida = 0;
                Console.WriteLine(this.Nome + " venceu a luta");
                this.evoluir();
            }
            else if (this.Vida <= 0)
            {
                this.Vida = 0;
                Console.WriteLine(p.Nome + " venceu a luta");
                p.evoluir();
            }
        }





        public override int defender()
        {
            int pontosDefesa = 0;

            pontosDefesa = (this.Forca + this.Agilidade + this.Inteligencia + this.Vida) / 4;

            return pontosDefesa;
        }

        public override void evoluir()
        {
            this.Nivel += 1;
            this.Forca += 1;
            this.Inteligencia += 1;
            this.Agilidade += 1;
            Console.WriteLine(this.Nome + " evoluiiu para o Nível:" + this.Nivel + ". Todos seus atributos aumentaram");
        }
    }
}