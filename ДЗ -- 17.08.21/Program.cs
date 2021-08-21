using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class UserInfo
    {
        // Поля класса
        public string Name, Family, Adress;
        public byte Age;

        // Метод, выводящий в консоль контактную информацию
        public void writeInConsoleInfo(string name, string family, string adress, byte age)
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nМестонахождение: {2}\nВозраст: {3}\n", name, family, adress, age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект типа UserInfo
            UserInfo myInfo = new UserInfo();

            myInfo.Name = "Alexandr";
            myInfo.Family = "Erohin";
            myInfo.Adress = "ViceCity";
            myInfo.Age = 26;

            // Создадим новый экземпляр класса UserInfo
            UserInfo myGirlFriendInfo = new UserInfo();

            myGirlFriendInfo.Name = "Elena";
            myGirlFriendInfo.Family = "Korneeva";
            myGirlFriendInfo.Adress = "ViceCity";
            myGirlFriendInfo.Age = 22;

            // Выведем информацию в консоль
            myInfo.writeInConsoleInfo(myInfo.Name, myInfo.Family, myInfo.Adress, myInfo.Age);
            myGirlFriendInfo.writeInConsoleInfo(myGirlFriendInfo.Name,myGirlFriendInfo.Family,myGirlFriendInfo.Adress,myGirlFriendInfo.Age);

            Console.ReadLine();
        }
    }

}