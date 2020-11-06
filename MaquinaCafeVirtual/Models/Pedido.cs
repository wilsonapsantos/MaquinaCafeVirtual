namespace MaquinaCafeVirtual.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public float ValorPago { get; set; }

        public float Troco { get; set; }
    }
}