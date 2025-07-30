using System.ComponentModel.DataAnnotations;

namespace ApiGawada.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nombre { get; set; }
        [Required, MaxLength(100)]
        public string Apellido { get; set; }
        [Required, EmailAddress]
        public string Correo { get; set; }
        [Required]
        public string ContrasenaHash { get; set; }
        public string? Celular { get; set; }
    
        [Required]
        public string Rol { get; set; } // "User" o "Admin"
        public DateTime FechaRegistro { get; set; }
        public ICollection<Pedido>? Pedidos { get; set; }

    }
