using System.ComponentModel.DataAnnotations;

namespace IdentidadIntegral.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Enabled { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<RoleAction> RoleActions { get; set; }
    }
}
