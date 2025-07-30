using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGawada.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string? ImagenUrl { get; set; }
        public bool Visibilidad { get; set; }
        public int? Descuento { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public ICollection<DetallePedido>? DetallesPedido { get; set; }
    }
}
