using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Entities
{
   public class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto Produtos {  get; set; }

        public ItemPedido(int quantidade, double preco, Produto produtos)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produtos = produtos;
        }

        public double Total()
        {
            return Quantidade * Preco;
        }
    }
}
