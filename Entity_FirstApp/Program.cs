using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Entity_FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {

                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Sam", Age = 26 };


                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                WriteLine("Object saved succesfully");

                var users = db.Users;
                WriteLine("List of objects");
                foreach (User u in users)
                {
                    WriteLine("{0}.{1}-{2}" , u.Id, u.Name, u.Age);
                }
            }
            Read();

        }
    }
}
