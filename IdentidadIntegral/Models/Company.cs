using System.ComponentModel.DataAnnotations;

namespace IdentidadIntegral.Models
{
    public class Company
    {
        [Key]
        public int IdCompany { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Enabled { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
