namespace MiniSite.Data
{
    public class DataContext
    {
        public List<User> userList = new List<User>
        {
            new User("User_1", "User_1", "User1"),
            new User("User_2", "User_2", "User2"),
            new User("User_3", "User_3", "User3")
        };

        public List<MessageClass> messageList = new List<MessageClass>
        {
            // TODO: Заполнить лист
        };

        public List<ChatClass> chatList = new List<ChatClass>
        {
            // TODO: Заполнить лист
        };

        // TODO: Реаализовать методы Add(), Remove(), Update()  для каждого списка
    }
}
