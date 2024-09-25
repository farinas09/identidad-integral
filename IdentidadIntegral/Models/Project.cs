using System.ComponentModel.DataAnnotations;

namespace IdentidadIntegral.Models
{
    public class Project
    {
        [Key]
        public int IdProject { get; set; }
        public int IdCompany { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BaseUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Enabled { get; set; }
        public ICollection<Module>? Modules { get; set; }
        public ICollection<UserProject>? UserProjects { get; set; }
    }
}
