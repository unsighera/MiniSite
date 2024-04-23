namespace MiniSite.Data
{
    public class ChatClass
    {
        public string Id = Guid.NewGuid().ToString();
        public List<User> Users { get; set; }
        public List<MessageClass> Messages { get; set; }

        public ChatClass() 
        {
            Users = new List<User>();
            Messages = new List<MessageClass>();
        }
    }
}
