using System.ComponentModel.DataAnnotations;

namespace ApiGawada.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public string Estado { get; set; } // Pendiente, Confirmado, Enviado, Cancelado
        public string? Gclid { get; set; }
        public string? UtmCampaign { get; set; }
        public ICollection<DetallePedido> Detalles { get; set; }
    }
}
