using SQLite;

namespace Labitoria.JD.Winforms.UserManager
{
    public class User
    {
        public User(string fullName, string username, string password)
        {
            this.FullName = fullName;
            this.Username = username;
            this.Password = password;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
