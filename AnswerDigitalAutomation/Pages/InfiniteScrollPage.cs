using OpenQA.Selenium;
using WebDriver = AnswerDigital.Driver.Driver;


namespace AnswerDigital.Pages
{
    class InfiniteScrollPage : WebDriver
    {
        private IWebElement InfiniteScrollText => WebDriver.FindElement(By.XPath("//h3[text()='Infinite Scroll']"));

        public bool IsInfiniteScrollTextDisplayed() => InfiniteScrollText.Displayed;

        public void ScrollToPageBottom()
        {
            IJavaScriptExecutor javaScriptExecutor = ((IJavaScriptExecutor)WebDriver);
            javaScriptExecutor.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        
        public void ScrollToPageTop()
        {
            IJavaScriptExecutor javaScriptExecutor = ((IJavaScriptExecutor)WebDriver);
            javaScriptExecutor.ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)");
        }
    }
}