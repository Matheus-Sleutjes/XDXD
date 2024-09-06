using System.ComponentModel.DataAnnotations.Schema;

namespace Stefanini.Domain.Model
{
    public class ItensPedido : Entity
    {
        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }
}
