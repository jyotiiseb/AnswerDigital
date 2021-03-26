using OpenQA.Selenium;
using WebDriver = AnswerDigital.Driver.Driver;

namespace AnswerDigital.Pages
{
    class TheInternetHomePage : WebDriver
    {
        private IWebElement HomePageHeader => WebDriver.FindElement(By.XPath("//h1[@class='heading'][text()='Welcome to the-internet']"));
        private IWebElement HomePageMenu(string menu) => WebDriver.FindElement(By.XPath($"//a[text()='{menu}']"));

        public bool IsHomePageDisplayed() => HomePageHeader.Displayed;

        public void SelectMenu(string menu) => HomePageMenu(menu).Click();
    }
}