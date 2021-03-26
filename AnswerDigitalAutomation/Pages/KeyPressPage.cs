using OpenQA.Selenium;
using System;
using System.ComponentModel;
using WebDriver = AnswerDigital.Driver.Driver;

namespace AnswerDigital.Pages
{
    class KeyPressPage : WebDriver
    {
        private IWebElement KeyPressPageHeader => WebDriver.FindElement(By.XPath("//h3[text()='Key Presses']"));
        private IWebElement KeyPressTextbox => WebDriver.FindElement(By.Id("target"));
        private IWebElement KeyPressResult => WebDriver.FindElement(By.Id("result"));

        public bool IsKeyPressPageDisplayed() => KeyPressPageHeader.Displayed;

        public void EnterKeyPressText(string text) => KeyPressTextbox.SendKeys(text);
        
        public string GetKeyPressResult() => KeyPressResult.Text;
    }
}