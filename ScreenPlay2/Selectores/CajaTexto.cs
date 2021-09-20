using OpenQA.Selenium;

namespace ScreenPlay2.Selectores
{
    public static class CajaTexto
    {
        public static By username = By.XPath("//input[@id='txtUsername']");
        public static By password = By.XPath("//input[@id='txtPassword']");
    }
}