namespace MiniSite.Data
{
    public class UsersClass
    {
        public List<User> userList = new List<User>
        {
            new User("user1", "user1", "user1"),
            new User("user2", "user2", "user2"),
            new User("user3", "user3", "user3")
        };
    }
    
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
