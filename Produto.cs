using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Produto
    {
        public string produto;
        public int    QuantidadeEmEstoque;
        public double Preço;

      public double CalcularTotal()
        {
            return QuantidadeEmEstoque * Preço;
        }
    }
}

