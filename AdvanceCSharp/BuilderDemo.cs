using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class BuilderDemo
    {
        public void Execute()
        {
            UserBuiler userBuilder2 = new UserBuiler();

            User u2 = userBuilder2
                .WithName("Amit")
                .WithPassword("123")
                .Build();


            User u3 = userBuilder2
               .WithName("Amit")
               .WithPassword("123")
               .WithRole("123")
               .WithEmail("123")
               .WithDb(new SQLDatabase(new ConsoleLogger()))
               .Build();



        }
    }

    public class UserBuiler
    {
        User user;

        public UserBuiler()
        {
            this.user = new User();
        }
        internal User Build()
        {
            return this.user;
        }

        internal UserBuiler WithDb(IDatabase db)
        {
            this.user.databsse= db;
            return this;
        }

        internal UserBuiler WithEmail(string v)
        {
            this.user.Email = v;
            return this;
        }

        internal UserBuiler WithName(string v)
        {
            this.user.Name = v;
            return this;
        }

        internal UserBuiler WithPassword(string v)
        {
            this.user.Password = v;
            return this;
        }

        internal UserBuiler WithRole(string v)
        {
            this.user.Role = v;
            return this;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }

        public IDatabase databsse { get; set; }

    }
}
