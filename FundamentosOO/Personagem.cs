using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }
        public int ArmaForc { get; set; }
        public int xp { get; set; }
        int contagemNivel = 1;

        public virtual void apresentarse()
        {
        }
        public virtual void evoluir()
        {

            if (this.xp >= 100)
            {
                this.Nivel += 1;
                this.Forca += 5;
                this.Inteligencia += 1;
                this.Agilidade += 5;

                Console.WriteLine("\n " + this.Nome + " evoluiiu para o Nível:" + this.Nivel + ". Todos seus atributos aumentaram:\n Força: " + this.Forca + "\n Agilidade: " + this.Agilidade + "\n Inteligência: " + this.Inteligencia + "\n Vida: " + this.Vida);
                Console.WriteLine("========================================================= \n");
                contagemNivel++;

                this.xp = 0;
                this.Vida = 200;
            }
            if (contagemNivel == 5)
            {
                this.ArmaForc += 10;
                Console.WriteLine("Parece que sua arma evoluiu seu dano agora é de: " + this.ArmaForc);
                contagemNivel = 0;
            }


        }
        public virtual int atacar()
        {
            int pontosAtaque = 0;

            pontosAtaque = this.Forca + this.ArmaForc;

            return pontosAtaque;
        }
        public virtual int defender()
        {
            int pontosDefesa = 0;

            pontosDefesa = this.Forca + this.Agilidade;

            return pontosDefesa;
        }
        public virtual void batalha(Personagem p)
        {

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
                Console.WriteLine(p.Nome + " está com " + p.Vida + " pontos de HP;\n");
                Console.WriteLine("========================================================= \n");


                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;

                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine(p.Nome + " acertou um ataque em " + this.Nome + " um dano de: " + danoDeVida2);
                Console.WriteLine(this.Nome + " está com " + this.Vida + " pontos de HP;\n");
                Console.WriteLine("========================================================= \n");
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
                Console.WriteLine("                " + this.Nome + " venceu a luta             \n");

                Console.WriteLine("=========================================================\n");

                this.xp += 30;
                this.evoluir();
            }
            else if (this.Vida <= 0)
            {
                this.Vida = 0;
                Console.WriteLine("                " + p.Nome + " venceu a luta             \n");
                Console.WriteLine("=========================================================\n");

                p.xp += 30;
                p.evoluir();

            }
        }



    }
}
