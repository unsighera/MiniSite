namespace MiniSite.Data
{
    public class MessageClass
    {
        public string Id = Guid.NewGuid().ToString();
        public string Message { get; set; }
        public User UserOwner { get; set; }
        public DateTime DateTime { get; set; }

        public MessageClass(string message, User userOwner)
        {
            Id = Guid.NewGuid().ToString();
            Message = message;
            UserOwner = userOwner;
            DateTime = DateTime.Now;
        }
    }
}
