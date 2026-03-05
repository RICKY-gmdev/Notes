namespace ftest1.Notes.Api.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public String Email { get; set; } = String.Empty;
        public String PasswordHash { get; set; } = String.Empty;
    }
}