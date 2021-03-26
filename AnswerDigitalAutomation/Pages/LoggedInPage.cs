using OpenQA.Selenium;
using WebDriver = AnswerDigital.Driver.Driver;

namespace AnswerDigital.Pages
{
    public class LoggedInPage : WebDriver
    {
        private IWebElement LoggedinPageHeader => WebDriver.FindElement(By.XPath("//div[@class='flash success']"));
        private IWebElement LogoutButton => WebDriver.FindElement(By.XPath("//a[@href='/logout']"));

        public bool IsLoggedinPageDisplayed() => LoggedinPageHeader.Displayed;
        public void Logout() => LogoutButton.Click();
    }
}