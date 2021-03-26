using OpenQA.Selenium;
using WebDriver = AnswerDigital.Driver.Driver;

namespace AnswerDigital.Pages
{
    class LoginPage : WebDriver
    {
        private IWebElement LoginPageHeader => WebDriver.FindElement(By.XPath("//div//h2[text()='Login Page']"));
        private IWebElement Username => WebDriver.FindElement(By.Id("username"));
        private IWebElement Password => WebDriver.FindElement(By.Id("password"));
        private IWebElement LoginButton => WebDriver.FindElement(By.XPath("//button[@type='submit']"));
        private IWebElement LoginErrorMsg(string message) => WebDriver.FindElement(By.XPath($"//div[@class='flash error'][contains(text(),'{message}')]"));

        public bool IsLoginPageDisplyed() => LoginPageHeader.Displayed;
        public void SendUsername(string username) => Username.SendKeys(username);
        public void SendPassword(string password) => Password.SendKeys(password);
        public void Login() => LoginButton.Click();

        public bool IsLoginErrorDisplayed(string message) => LoginErrorMsg(message).Displayed;
    }
}