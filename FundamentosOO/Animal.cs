using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    //uma classe abastrata não pode ser instanciada
    public abstract class Animal
    {
        //Parallel um método abstrato a classe tambèm precisa ser abstrata
        public string Especie { get; set; }
        public string Nome { get; set; }
        //private string Especie;
        //public string getEspecie()
        //{
        //    return this.Especie;
        //}
        //public void setEspecie(string Especie)
        //{

        //}

        public abstract void emitirSom();
    }
}
