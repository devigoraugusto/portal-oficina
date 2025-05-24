namespace portal_oficina.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }

    }
}
