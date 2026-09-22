using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Id { get; set; }

        public double Credito { get; set; }
    }
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
    public class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorVenda { get; set; }
    }
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public Pedido()
        {
            Itens = new List<ItemPedido>();
        }

        public void AdicionarItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public double CalcularTotal()
        {
            double total = 0;
            int i;
            for (i = 0; i < Itens.Count; i++)
            {
                total += Itens[i].ValorVenda * Itens[i].Quantidade;
            }
            return total;
        } 
        public void ExibirItens()
        {
            Console.WriteLine($"{Cliente.Nome}");
            for (int i = 0; i < Itens.Count; i++)
            {
                Console.WriteLine($"{Itens[i].Produto.Nome} - {Itens[i].Quantidade} - R${Itens[i].ValorVenda:F2}");
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto
            {
                Nome = "Monitor Alienware Oled 360hz",
                Preco = 5500.00,
            };
            Produto produto2 = new Produto
            {
                Nome = "Mouse Zowie EC3-B",
                Preco = 1100.00,
            };

            Cliente cliente = new Cliente
            {
                Nome = "Arthur Lima",
                Id = "1",
                Credito = 100.00,
            };
            ItemPedido itemPedido = new ItemPedido
            {
                Produto = produto,
                Quantidade = 2,
                ValorVenda = produto.Preco,

            };
            ItemPedido itemPedido2 = new ItemPedido
            {
                Produto = produto2,
                Quantidade = 2,
                ValorVenda = produto2.Preco,
            };


            Pedido pedido = new Pedido
            {
                Cliente = cliente,
  
            };
            pedido.AdicionarItem(itemPedido);
            pedido.AdicionarItem(itemPedido2);
            pedido.ExibirItens();
            double total = pedido.CalcularTotal();
            Console.WriteLine($"Total do pedido: R$ {total:F2}");
           

         

            


            
            
        }
    }
}
