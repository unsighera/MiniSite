using MiniSite.Data;
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

        public List<MessageClass> messageList;
        public List<ChatClass> chatList;

        public DataContext()
        {

            messageList = new List<MessageClass>
            {
                new MessageClass("Hello, how are you?", userList[0]),
                new MessageClass("I'm doing well, thank you!", userList[1]),
                new MessageClass("What are you up to today?", userList[0]),
                new MessageClass("Just working on some coding projects.", userList[1]),
                new MessageClass("Sounds interesting!", userList[0]),
            };

            chatList = new List<ChatClass>
            {
                new ChatClass
                {
                    Users = new List<User> { userList[0], userList[1] },
                    Messages = new List<MessageClass>
                    {
                        new MessageClass("Hello, how are you?", userList[0]),
                        new MessageClass("I'm doing well, thank you!", userList[1]),
                        new MessageClass("What are you up to today?", userList[0]),
                        new MessageClass("Just working on some coding projects.", userList[1]),
                        new MessageClass("Sounds interesting!", userList[0]),
                    }
                },
                new ChatClass
                {
                    Users = new List<User> { userList[1], userList[2] },
                    Messages = new List<MessageClass>
                    {
                        new MessageClass("Hey there!", userList[1]),
                        new MessageClass("Hi, how's it going?", userList[2]),
                        new MessageClass("Not bad, just relaxing.", userList[1]),
                        new MessageClass("Sounds nice!", userList[2]),
                    }
                },
            };
        }


        public void AddUser(User user)
        {
            userList.Add(user);
        }

        public void RemoveUser(User user)
        {
            userList.Remove(user);
        }

        public void UpdateUser(User userToUpdate)
        {
            var existingUser = userList.FirstOrDefault(u => u.Login == userToUpdate.Login);
            if (existingUser != null)
            {
                existingUser.Name = userToUpdate.Name;
                existingUser.Password = userToUpdate.Password;
            }
        }


        public void AddMessage(MessageClass message)
        {
            messageList.Add(message);
        }

        public void RemoveMessage(MessageClass message)
        {
            messageList.Remove(message);
        }

        public void UpdateMessage(MessageClass messageToUpdate)
        {
            var existingMessage = messageList.FirstOrDefault(m => m.Id == messageToUpdate.Id);
            if (existingMessage != null)
            {
                existingMessage.Message = messageToUpdate.Message;
                existingMessage.UserOwner = messageToUpdate.UserOwner;
                existingMessage.DateTime = messageToUpdate.DateTime;
            }
        }


        public void AddChat(ChatClass chat)
        {
            chatList.Add(chat);
        }

        public void RemoveChat(ChatClass chat)
        {
            chatList.Remove(chat);
        }

        public void UpdateChat(ChatClass chatToUpdate)
        {
            var existingChat = chatList.FirstOrDefault(c => c.Id == chatToUpdate.Id);
            if (existingChat != null)
            {
                // TODO: Реализация обновления пользователей или сообщений чата
            }
        }

    }
}
