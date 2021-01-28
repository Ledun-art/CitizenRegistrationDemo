using System;

namespace CitizenRegistration
{
    internal class Program : MenuControlManager
    {
        public static void Main(string[] args)
        {
            MenuControlManager menuControlManager = new MenuControlManager();
            menuControlManager.MenuRegister(new MenuRegisterManager());
            Console.WriteLine("Ana Menüye Hoşgeldiniz");
            Console.WriteLine("1. Bilgilerini Görüntüle");
            Console.WriteLine("2. Oyunlarını görüntüle");
            Console.WriteLine("3. Oyunlarını Sil!");
            Console.WriteLine("4. Database bilgilerini logla");
            Console.WriteLine("5. Sms olarak logla");


            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MenuControlManager menuUptadeManager = new MenuControlManager();
                    menuUptadeManager.MenuUpdate(new MenuUpdateRegistrationManager());
                    break;
                case "2":
                    MenuControlManager menuGameManager = new MenuControlManager();
                    menuGameManager.Game(new GameManager());
                    break;
                case "3":
                    MenuControlManager deleteGameManager = new MenuControlManager();
                    deleteGameManager.GameDelete(new GameManager());
                    break;
                case "4":
                    LogControlService logControlDatabaseService = new LogControlService();
                    logControlDatabaseService.Database();
                    break;
                case "5":
                    LogControlService logControlSmsService = new LogControlService();
                    logControlSmsService.Sms();
                    break;
            }
        }
    }
}