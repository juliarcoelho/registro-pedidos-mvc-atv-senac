using System.Collections.Generic;
namespace servir.Models
{
    public class Pedido
    {
        public List<ItemPedido> itemPedido;
        public Pedido()
        {
            itemPedido = new List<ItemPedido>();
        }
        public void AdicionaPedido(ItemPedido item)
        {
            itemPedido.Add(item);
        }
        public double TotalizaPedido()
        {
            double total = 0;
            foreach (var item in itemPedido)
            {

                total = total + item.valorUnitario * item.quantidade;
            }

            return total;

        }
    }
}