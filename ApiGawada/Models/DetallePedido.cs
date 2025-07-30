using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGawada.Models
{
    public class DetallePedido
    {
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnitario { get; set; }
    }
}
