namespace portal_oficina.Core.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string PasswordHash { get; set; }
    }
}
