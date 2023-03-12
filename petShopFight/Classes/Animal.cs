using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShopFight.Classes
{
     public abstract class Animal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Life { get; set; }
        public double DistanciaSeg { get; set; }
        public int Dano { get; set; }

        public Animal()
        {
            this.Life = 100;
        }

        public double Andar(int tempoSegundos )
        {
            return tempoSegundos*this.DistanciaSeg;
        }

        public double Morder(int Lifeinimigo)
        {

            return Lifeinimigo - this.Dano;
        }

        
    }
}
