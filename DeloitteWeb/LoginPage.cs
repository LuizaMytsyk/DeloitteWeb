using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DeloitteWeb
{
    class LoginPage
    {
        protected IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void SingIn(string userName, string password)
        {
            _username.SendKeys(userName);
            _password.SendKeys(password);
            _singInButton.Click();
        }

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement _username;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        private IWebElement _password;

        [FindsBy(How = How.Id, Using = "login-submit")]
        private IWebElement _singInButton;
    }
}
