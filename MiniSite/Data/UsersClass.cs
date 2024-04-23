namespace MiniSite.Data
{  
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public User(string login, string password, string name)
        {
            Login = login;
            Password = password;
            Name = name;
        }
    }
}
