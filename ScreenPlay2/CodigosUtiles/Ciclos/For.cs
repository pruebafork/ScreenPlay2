using OpenQA.Selenium;
using ScreenPlay2.Bases;
using ScreenPlay2.CodigosUtiles.Selectores;

namespace ScreenPlay2.CodigosUtiles.Ciclos
{
    public static class For
    {
        public static void recorrerFor()
        {
            var locators = Botones.getPosicionLista(3);
            var elementsList = Driver.GetInstance().FindElements(locators);
            var n = 1;
            foreach (var item in elementsList)
            {
                n++;
                if (item.Text =="texto")
                {
                    var locator = By.XPath(string.Format("//table[@id='algo']//tbody[{0}]",n));
                    //var texto = Elemento.On(locator).Text;
                    //var texto = Elemento.On(locator);
                    //texto.Click();
                }
            }
        }

        public static string recorrerFor2()
        {
            var locators = Botones.getPosicionLista(3);
            var elementsList = Driver.GetInstance().FindElements(locators);
            var n = 1;
            foreach (var item in elementsList)
            {
                n++;
                if (item.Text == "texto")
                {
                    var locator = By.XPath(string.Format("//table[@id='algo']//tbody[{0}]", n));
                    //var texto = Elemento.On(locator).Text;
                    //var texto = Elemento.On(locator);
                    //texto.Click();
                    //return texto;
                }
            }
            return null;
        }
    }
}