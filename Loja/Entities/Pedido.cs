using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Entities.Enum;

namespace Loja.Entities
{
    public class Pedido
    {
        public DateTime Momento { get; set; }
        public OrderStatus Status { get; set; }
        public List<ItemPedido> Pedidos { get; set; } = new List<ItemPedido>();
        public Cliente Client { get; set; }

        public Pedido(DateTime momento, OrderStatus status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Client = cliente;
        }

        public void AddItem(ItemPedido item)
        {
            Pedidos.Add(item);
        }
        public void RemoveItem(ItemPedido item)
        {
            Pedidos.Remove(item);
        }

        public double TotalValor()
        {
            double total = 0.0;
            foreach (ItemPedido item in Pedidos)
            {
                total += item.Total();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"SUMÁRIO DO PEDIDO: ");
            sb.AppendLine($"Momento do pedido: {Momento}");
            sb.AppendLine($"Status do pedido: {Status}");
            sb.AppendLine($"Cliente: {Client.Nome} ({Client.Nascimento.ToShortDateString()}) - {Client.Email}");
            sb.AppendLine($"Itens do pedido: ");
            foreach (ItemPedido item in Pedidos)
            {
                sb.AppendLine($"{item.Produtos.Nome}, R${item.Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {item.Quantidade}, SubTotal: R${item.Total().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            sb.AppendLine($"Total dos pedidos: R${TotalValor().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
