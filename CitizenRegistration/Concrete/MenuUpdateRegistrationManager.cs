using System;

namespace CitizenRegistration
{
    internal class MenuUpdateRegistrationManager : IRegister
    {
        public void Registration()
        {
            CitizenVerification citizenTrue1 = new CitizenVerification()
            {
                CitizenId = "1234567890", BirthTime = "1990", FirstName = "Tarik", LastName = "Pinar",
                Address = "Istanbul", Country = "Turkey"
            };

            CitizenVerification[] citizenTrues = {citizenTrue1};

            foreach (CitizenVerification citizen in citizenTrues)
            {
                Console.WriteLine("Vatandaşlık Numaranız: " + citizen.CitizenId);
                Console.WriteLine("Adınız: " + citizen.FirstName);
                Console.WriteLine("Soy İsminiz: " + citizen.LastName);
                Console.WriteLine("Doğum Tarihiniz: " + citizen.BirthTime);
                Console.WriteLine("Sisteme Kayıtlı Adresiniz: " + citizen.Address);
                Console.WriteLine("Ulkeniz: " + citizen.Country);
                Console.WriteLine("1.Bilgilerini güncellemek için");
                Console.WriteLine("2.Bilgilerini silmek ve sistemden çıkmak için");
                string input2 = Console.ReadLine();
                switch (input2)
                {
                    case "1":
                        Console.WriteLine("Bilgileriniz Güncellendi");
                        break;
                    case "2":
                        Console.WriteLine("Bilgilerin silindi");
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}