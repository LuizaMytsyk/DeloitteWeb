using System;
using NUnit.Framework;
using DeloitteWeb;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DeloitteTest
{
    [TestFixture]
    public class UnitTest2
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage login;
        WebDriverWait wait;

        [OneTimeSetUp]
        public void SetUpTest()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Url = @"https://perf.exalinkservices.com";
            login = new LoginPage(driver);
        }

        [Test]
        public void TestMethod1()
        {
            login.SingIn("jack", "Dummy#123");
            Assert.IsTrue(driver.FindElement(By.XPath("//span[contains(text(),'Jack Clayton')]")).Displayed);
        }

    }
}
