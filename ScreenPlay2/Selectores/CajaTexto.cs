using OpenQA.Selenium;

namespace ScreenPlay2.Selectores
{
    public static class CajaTexto
    {
        public static By username = By.XPath("//input[@id='txtUsername']");

        public static By password = By.XPath("//input[@id='txtPassword']");

        public static By fullName = By.XPath("//input[@id='personal_txtEmpFirstName']");
        public static By middleName = By.XPath("//input[@id='personal_txtEmpMiddleName']");
        public static By lastName = By.XPath("//input[@id='personal_txtEmpLastName']");
        public static By EmployeeId = By.XPath("//input[@id='personal_txtEmployeeId']");
        public static By otherId = By.XPath("//input[@id='personal_txtOtherID']");
        public static By NroLicencia = By.XPath("//input[@id='personal_txtLicenNo']");
        public static By SNNnRO = By.XPath("//input[@id='personal_txtNICNo']");
        public static By sinNumber = By.XPath("//input[@id='personal_txtSINNo']");
        

    }
}