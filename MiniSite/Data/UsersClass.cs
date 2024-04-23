namespace MiniSite.Data
{
    public class UsersClass
    {
        public List<User> userList = new List<User>
        {
            new User("User_1", "User_1", "User1"),
            new User("User_2", "User_2", "User2"),
            new User("User_3", "User_3", "User3")
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
