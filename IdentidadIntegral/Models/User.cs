namespace IdentidadIntegral.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public int IdCompany { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AzureAD { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Company Company { get; set; }
    }
}
