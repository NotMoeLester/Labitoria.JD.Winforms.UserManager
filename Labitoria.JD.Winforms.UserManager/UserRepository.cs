using SQLite;

namespace Labitoria.JD.Winforms.UserManager
{
    public class UserRepository
    {
        private readonly ISQLiteConnection _connection;

        public UserRepository()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserData.db");
        _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<User>();
        
        }
        public bool Add(User user)
        {
            _connection.Insert(user);
            return true;
        }

        public List<User> GetAll() 
        { 
            return new List<User>();
        }

        public User Get(int id) 
        {
            return new User("DummyFullname","DummyUsername","DummyPassword");
        }
    }
}
