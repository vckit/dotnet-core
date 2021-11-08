using System;
using docker_test2.Context;
using System.Linq;
using System.Data.SqlClient;

namespace docker_test2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    // создаем два объекта User
                    User user1 = new User { Name = "Tom", Age = 33 };
                    User user2 = new User { Name = "Alice", Age = 26 };

                    // добавляем их в бд
                    db.Users.Add(user1);
                    db.Users.Add(user2);
                    db.SaveChanges();
                    Console.WriteLine("Объекты успешно сохранены");

                    // получаем объекты из бд и выводим на консоль
                    var users = db.Users.ToList();
                    Console.WriteLine("Список объектов:");
                    foreach (User u in users)
                    {
                        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                    }
                }
            }
            catch (System.Exception ex)
            {
                // TODO
                System.Console.WriteLine(ex.Message, ex.Source);
            }

        }
    }
}
