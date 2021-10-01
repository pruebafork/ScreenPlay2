using OpenQA.Selenium;

namespace ScreenPlay2.Selectores
{
    public static class Boton
    {
        private static By menus;

        public static By login = By.XPath("//input[@id='btnLogin']");

        public static By menu = By.XPath("//li[@class='main-menu-first-level-list-item']");

        public static By username = By.XPath("//input[@id='txtUsername']");

        public static By myInfo = By.XPath("//a[@id='menu_pim_viewMyDetails']");
        public static By edit = By.XPath("//input[@id='btnSave']");












        public static void setMenu(string valor)
        {
            menus = By.XPath("//li[@class='main-menu-first-level-list-item']//b[contains(text(),'"+valor+"')]");
        }

        public static By getMenu()
        {
            return menus;
        }


    }
}
