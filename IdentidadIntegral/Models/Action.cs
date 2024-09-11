namespace IdentidadIntegral.Models
{
    public class Action
    {
        public int IdAction { get; set; }
        public int IdModule { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Enabled { get; set; }
        public Module Module { get; set; }
    }
}
