namespace CitizenRegistration
{
    internal class MenuControlManager
    {
        public void MenuRegister(IRegister register)
        {
            MenuRegisterManager menuRegisterManager = new MenuRegisterManager();
            menuRegisterManager.Registration();
        }


        public void MenuUpdate(IRegister register)
        {
            MenuUpdateRegistrationManager menuUpdateRegistrationManager = new MenuUpdateRegistrationManager();
            menuUpdateRegistrationManager.Registration();
        }

        public void Game(IProduct product)
        {
            GameManager gameManager = new GameManager();
            gameManager.Add();
           
        }

        public void GameDelete(IProduct product)
        {
            GameManager gameManager = new GameManager();
            gameManager.Delete();
        }
    }
}