namespace MiniSite.Data
{
    public class ChatContext
    {
        public ChatClass CurrentChat{ get; private set; }

        public void SetCurrentUser(ChatClass chat)
        {
            CurrentChat = chat;
        }

        public void ClearCurrentUser()
        {
            CurrentChat = null;
        }
    }
}
