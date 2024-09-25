using System.ComponentModel.DataAnnotations;

namespace IdentidadIntegral.Models
{
    public class Company
    {
        [Key]
        public int IdCompany { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Fecha de Creación")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Fecha de Modificación")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Habilitado")]
        public bool Enabled { get; set; }
        public ICollection<Project>? Projects { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
