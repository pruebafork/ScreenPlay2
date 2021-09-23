using OpenQA.Selenium;

namespace ScreenPlay2.CodigosUtiles.Selectores
{
    public static class Botones
    {
        private static By selector;

        public static void setValor(string value)
        {
            selector = By.XPath("//div[contains(text(), '" + value + "')]");
        }

        public static By getValue()
        {
            return selector;
        }


        public static By getPosicionLista(int value)
        {
            return By.XPath(string.Format("//div[1]//div[2]//span[{0}]",value));
        }

        public static By getNombres(int value)
        {
            return By.XPath(string.Format("//div[text()='{0}']", value));
        }

    }
}