using System.ComponentModel.DataAnnotations;

namespace Protofolio.Model
{
    public class ContactMessage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty; 
        [Required] public string Email { get; set; } = string.Empty;
        [Required] public string Subject { get; set; } = string.Empty; 
        [Required] public string Message { get; set; } = string.Empty; 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
