namespace IdentidadIntegral.Models
{
    public class RoleAction
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int ActionId { get; set; }
        public Action Action { get; set; }
    }
}
