using System;
using System.Threading;

namespace CitizenRegistration
{
    internal class MenuRegisterManager : IRegister
    {
        public void Registration()
        {
            CitizenVerification citizenTrue1 = new CitizenVerification()
            {
                CitizenId = "1234567890", BirthTime = "1990", FirstName = "Tarik", LastName = "Pinar",
                Address = "Istanbul", Country = "Turkey"
            };

            Console.WriteLine(
                "Sisteme giriş yapmak için kullanıcı adınızı ve soyadınızı giriniz ");
            Console.WriteLine("Adınız: ");
            citizenTrue1.FirstName = Console.ReadLine();
            Console.WriteLine("Adınız" + " " + citizenTrue1.FirstName);
            Console.WriteLine("Soyisminiz: ");
            citizenTrue1.LastName = Console.ReadLine();
            Console.WriteLine("Soyadınız" + " " + citizenTrue1.LastName);
            string[] bars = {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"};

            if (citizenTrue1.FirstName == "Tarik" && citizenTrue1.LastName == "Pinar")
            {
                Console.WriteLine("Sisteme giriş yapıyorsunuz.. Lütfen bekleyin");
                foreach (var bar in bars)
                {
                    var second = 2000;
                    Thread.Sleep(second);
                    Console.WriteLine(bar);
                }

                Console.WriteLine("Giriş başarılı");
                Console.WriteLine("Sisteme Hoşgeldiniz" + " " + citizenTrue1.FirstName + " " + citizenTrue1.LastName);
                Console.WriteLine("Bilgileriniz getiriliyor...");
                Console.Clear();
            }
            else
            {
                Console.ReadKey();
                Console.WriteLine("Hatalı giriş yaptınız!");
            }
        }
    }
}