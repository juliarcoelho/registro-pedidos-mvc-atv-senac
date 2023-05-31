namespace servir.Models
{
    public class ItemPedido
    {
        public string descricao {get; set;}
        public double valorUnitario;
        public double quantidade; 
         public ItemPedido(double q, double v)
        {
            valorUnitario = v;
            quantidade = q;
        }

    }
}
