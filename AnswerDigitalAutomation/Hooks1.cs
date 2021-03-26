using AnswerDigital.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AnswerDigitalAutomation
{
    [Binding]
    public sealed class Hooks1
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            Browser.GetBrowser();
            Browser.ImplicitWaitTimeout();
            Browser.PageLoadTimeOut();
            Browser.ScriptTimeout();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.CloseBrowser();
        }
    }
}
