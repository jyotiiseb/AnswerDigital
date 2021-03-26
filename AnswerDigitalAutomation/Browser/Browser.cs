using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using WebDriver = AnswerDigital.Driver.Driver;

namespace AnswerDigital.Browser
{
    public class Browser : WebDriver
    {
        public static void GetBrowser()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--incognito", "--start-maximized");
            WebDriver = new ChromeDriver(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName, chromeOptions);
        }

        public static void Navigate(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public static void CloseBrowser() => WebDriver.Quit();

        public static void ImplicitWaitTimeout() => WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        public static void PageLoadTimeOut() => WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);

        public static void ScriptTimeout() => WebDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);
    }
}