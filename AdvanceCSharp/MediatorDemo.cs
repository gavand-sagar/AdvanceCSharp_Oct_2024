using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class MediatorDemo : IExecutableClass
    {

        // chatRoom  - one instance of chat room


        // user   -- multiple instances  --
        // while creating single instance of user, we will assign chat room instance to it

        public interface IChatRoom
        {
            string Name { get; }
            void registerUser(IChatUser user);
            void sendMessage(IChatUser user, string message);
        }

        public interface IChatUser
        {
            string getUsername();
            //void sendMessage(string message);
            void recieveMessage(string message);
        }

        public class ChatRoom : IChatRoom
        {
            private string _name;
            public string Name => _name;

            List<IChatUser> users = new List<IChatUser>();

            public ChatRoom(string name)
            {
                _name = name;
            }
            public void sendMessage(IChatUser user, string message)
            {
                foreach (var item in users)
                {
                    item.recieveMessage(message);
                }
            }

            public void registerUser(IChatUser user)
            {
                users.Add(user);
            }
        }

        public class ChatUser : IChatUser
        {
            private string username;
            public ChatUser(string username)
            {
                this.username = username;
            }
            public string getUsername()
            {
                return this.username;
            }

            public void recieveMessage(string message)
            {
                Console.WriteLine($"[{this.getUsername()}]Message Recieved - {message}");
            }

        }



        public void Execute()
        {
            IChatRoom room = new ChatRoom("Room1");

            IChatUser sagar = new ChatUser("Sagar");
            IChatUser amit = new ChatUser("Amit");
            IChatUser rohan = new ChatUser("Rohan");
            room.registerUser(sagar);
            room.registerUser(amit);
            room.registerUser(rohan);

            room.sendMessage(sagar, "Hi");




        }
    }
}
