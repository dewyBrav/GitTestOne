using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class MyTestClassOne
    {

        public static void MyTestClass()
        {
            UserPass user1 = new UserPass(Name: "Alex", Age: 26, Pass: "12345");

            // Вызываем обобщенный метод
            string s = InfoObject.Info<UserPass>(user1);
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }

    // Создадим необобщенный класс
    class InfoObject
    {
        // Обобщенный метод использующий также ограничение
        public static string Info<T>(T obj)
            where T : User
        {
            return obj.ToString();
        }
    }

    class User
    {
        public User(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    class UserPass : User
    {
        public UserPass(string Name, int Age, string Pass)
            : base(Name, Age)
        {
            Password = Pass;
        }

        public string Password { get; set; }

        public override string ToString()
        {
            return String.Format(@"Информация о пользователе:
**************************
Имя: {0}
Возраст: {1}
Пароль: {2}", Name, Age, Password);
        }
    }

    
}
