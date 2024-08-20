using FundamentosOO;
using System.Data;
using System.Runtime.CompilerServices;

internal class Program
{

    private static void Main(string[] args)
    {
        //exemplo de comentario um uma linha
        //Livro livro1 = new Livro();
        //livro1.Titulo = "Hyrule Historia";
        //livro1.Editora = "Nintendo";
        //livro1.Autor = "Rogério";
        //livro1.AnoLancamento = 2001;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "Garoto de C#";
        //livro2.Editora = "Sesnai novo";
        //livro2.Autor = "Thiag O Mazzi";
        //livro2.AnoLancamento = 2018;

        //Livro livro3 = new Livro();
        //livro3.Titulo = "Kung Fu com C#";
        //livro3.Editora = "Sesnai";
        //livro3.Autor = "Profs Castello";
        //livro3.AnoLancamento = 1928;

        //Instanciar um objeto do Tipo Aluno
        //Aluno aluno1 = new Aluno();

        ////Preencher atributos na tela
        //aluno1.Nome = "Bruno Martins Alves Junior";
        //aluno1.RM = "CEJAU4368";
        //aluno1.Email = "bruno.h.alves@aluno.senai.br";
        //aluno1.Nascimento = new DateOnly(2007, 08, 28);

        //////Imprimir na tela
        //Console.WriteLine("Aluno 1");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("RM: " + aluno1.RM);
        //Console.WriteLine("Email: " + aluno1.Email);
        //Console.WriteLine("Nascimento: " + aluno1.Nascimento);

        //Console.WriteLine("=========================================================");

        //Aluno aluno2 = new Aluno();

        ////Preencher atributos na tela
        //aluno2.Nome = "Ryan Rattini Ribeiro";
        //aluno2.RM = "CEJAU4798";
        //aluno2.Email = "ryan.rattini2@aluno.senai.br";
        //aluno2.Nascimento = new DateOnly(2007, 02, 03);

        ////Imprimir na tela
        //Console.WriteLine("Aluno 2");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("RM: " + aluno2.RM);
        //Console.WriteLine("Email: " + aluno2.Email);
        //Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        //Console.WriteLine("=========================================================");

        //Aluno aluno3 = new Aluno();

        ////Preencher atributos na tela
        //aluno3.Nome = "Thiago Mazzi";
        //aluno3.RM = "CEJAU4368";
        //aluno3.Email = "thiago.mazzi@aluno.senai.br";
        //aluno3.Nascimento = new DateOnly(2007, 07, 31);

        ////Imprimir na tela
        //Console.WriteLine("Aluno 3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM: " + aluno3.RM);
        //Console.WriteLine("Email: " + aluno3.Email);
        //Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        //Console.WriteLine("=========================================================");

        ////Instanciar um objeto do tipo produto
        //Produto p1 = new Produto();
        //p1.Nome = "Pepsi";
        //p1.Codigo = 123456;
        //p1.Preco = 12.99;
        //p1.Estoque = 100;
        ////Chamar metodo QuantidadeEstoque
        //p1.QuantidadedeEstoque();
        //p1.Estoque = 90;
        //p1.QuantidadedeEstoque();
        //Console.WriteLine("=========================================================");

        ////Instanciar um objeto do tipo Carro
        //Carro carro1 = new Carro();

        //carro1.Marca = "Chevrolet";
        //carro1.Modelo = "488";
        //carro1.Velocidade = 5;


        //carro1.Desacelerar();
        //carro1.Desacelerar();
        //carro1.Desacelerar();
        //Console.WriteLine("=========================================================");

        //Pessoa pessoa1 = new Pessoa();

        //pessoa1.Nome = "Joelmo";
        //pessoa1.Idade = 20;

        //pessoa1.Envelhecer(1);
        //pessoa1.Envelhecer(3);
        //pessoa1.Envelhecer(4);

        //Console.WriteLine("=========================================================");
        //Funcionario func1 = new Funcionario();
        //func1.Nome = "Claudio";
        //func1.Idade = 20;
        //func1.Cargo = "Aprendiz";
        //func1.Salario = 1400;
        //func1.Apresentarse();

        //Console.WriteLine("=========================================================");
        //        //Instamciar um objeto
        //        Animal animal1 = new Animal();

        //        //Inserindo dados no Atributo
        //        animal1.Especie = "Tigre";

        //        //Chamando o Metodo do Objeto
        //        animal1.emitirSom();
        //    }
        //Gato gato1 = new Gato();
        //gato1.Nome = "Roberto";
        //Console.WriteLine(gato1.Nome + " Faz: ");
        //gato1.emitirSom();
        //Console.WriteLine("=========================================================");
        //Porco porco = new Porco();
        //porco.Nome = "Hilario";
        //Console.WriteLine(porco.Nome + " Faz: ");
        //porco.emitirSom();
        //Console.WriteLine("=========================================================");
        //Galinha galinha = new Galinha();
        //galinha.Nome = "Filomena";
        //Console.WriteLine(galinha.Nome + " Faz: ");
        //galinha.emitirSom();
        Mago mago = new Mago();
        mago.Nome = "Patolino";
        mago.Forca = 10;
        mago.Inteligencia = 80;
        mago.Vida = 200;
        mago.Agilidade = 55;
        mago.Nivel = 1;

        Cavaleiro cava = new Cavaleiro();
        cava.Nome = "Link";
        cava.Forca = 80;
        cava.Inteligencia = 20;
        cava.Vida = 200;
        cava.Agilidade = 55;
        cava.Nivel = 1;









    }
}