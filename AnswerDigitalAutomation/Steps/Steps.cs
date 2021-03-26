using AnswerDigital.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AnswerDigital.Steps
{
    [Binding]
    class Steps
    {
        LoginPage loginPage = new LoginPage();
        TheInternetHomePage theInternet = new TheInternetHomePage();
        LoggedInPage loggedIn = new LoggedInPage();
        InfiniteScrollPage infiniteScroll = new InfiniteScrollPage();
        KeyPressPage keyPress = new KeyPressPage();

        [Given(@"I navigate to the internet homepage")]
        public void GivenINavigateToTheInternetHomepage()
        {
            Browser.Browser.Navigate(Environment.TheInternetUrl);
        }

        [When(@"I click '(.*)' on homepage menu")]
        public void WhenIClickOnHomepageMenu(string menu)
        {
            theInternet.SelectMenu(menu);
        }

        [Then(@"Login Page is displayed")]
        public void ThenLoginPageIsDisplayed()
        {
            Assert.IsTrue(loginPage.IsLoginPageDisplyed(), "Login page is not displayed");
        }

        [When(@"I enter '(.*)' as username")]
        public void WhenIEnterAsUsername(string username)
        {
            loginPage.SendUsername(username);
        }

        [When(@"I enter '(.*)' as password")]
        public void WhenIEnterAsPassword(string password)
        {
            loginPage.SendPassword(password);
        }

        [When(@"I click Login button")]
        public void WhenIClickLoginButton()
        {
            loginPage.Login();
        }

        [Then(@"Error message '(.*)' is displayed")]
        public void ThenErrorMessageIsDisplayed(string error)
        {
            Assert.IsTrue(loginPage.IsLoginErrorDisplayed(error), "Error msg in not displayed");
        }

        [Then(@"Logged in page is displayed")]
        public void ThenLoggedInPageIsDisplayed()
        {
            Assert.IsTrue(loggedIn.IsLoggedinPageDisplayed());
        }

        [When(@"I click logout button")]
        public void WhenIClickLogoutButton()
        {
            loggedIn.Logout();
        }

        [Then(@"Infinite Scroll text is displayed")]
        public void ThenInfiniteScrollPageIsDisplayed()
        {
            Assert.IsTrue(infiniteScroll.IsInfiniteScrollTextDisplayed());
        }

        [When(@"I scroll down to the page bottom")]
        public void WhenIScrollDownToThePageBottom()
        {
            infiniteScroll.ScrollToPageBottom();
        }

        [When(@"I scroll up to the top of the page")]
        public void WhenIScrollUpToTheTopOfThePage()
        {
            infiniteScroll.ScrollToPageTop();
        }

        [Then(@"Key Presses page is displayed")]
        public void ThenKeyPressesPageIsDisplayed()
        {
            Assert.IsTrue(keyPress.IsKeyPressPageDisplayed());
        }

        [When(@"I enter '(.*)' in text box")]
        public void WhenIEnterInTextBox(string key)
        {
            switch (key)
            {
                case "Control":
                    keyPress.EnterKeyPressText(Keys.Control);
                    break;
                case "Tab":
                    keyPress.EnterKeyPressText(Keys.Tab);
                    break;
                case "Shift":
                    keyPress.EnterKeyPressText(Keys.Shift);
                    break;
                case "Alt":
                    keyPress.EnterKeyPressText(Keys.Alt);
                    break;
                default:
                    keyPress.EnterKeyPressText(key);
                    break;
            }
            
        }

        [Then(@"'(.*)' is displayed")]
        public void ThenIsDisplayed(string result)
        {
            Assert.AreEqual(result, keyPress.GetKeyPressResult());
        }

    }
}