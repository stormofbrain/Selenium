using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
namespace UnitTestChrome
{
    [TestClass]
    public class UnitTest1
    {
        interface TestingDriver
        {
            void TestDriver(IWebDriver d);
        }
        public const int TimeOut = 5;
        public void TestDriverEmail(IWebDriver d)
        
        {
             LogIn l = new LogIn();

             IWebDriver driver = d;//new ChromeDriver(@"C:\Users\user\Desktop\");
            driver.Navigate().GoToUrl("https://mail.google.com");
            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys(l.login);

            IWebElement pass = driver.FindElement(By.Id("Passwd"));
            pass.SendKeys(l.password);

            IWebElement singbtn = driver.FindElement(By.Id("signIn"));
            singbtn.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            IWebElement SendMess = driver.FindElement(By.XPath("//div[contains(@class, 'z0')]/div"));
           // IWebElement SendMess = driver.FindElement(By.ClassName("z0"));
            SendMess.Click();
          
            Assert.IsNotNull(SendMess);
            IWebElement who = driver.FindElement(By.ClassName("vO"));
            who.SendKeys(l.login);
            Assert.IsNotNull(who);
            IWebElement Theme = driver.FindElement(By.ClassName("aoT"));
            Theme.SendKeys("Theme demo version");
            Assert.IsNotNull(Theme);
            IWebElement txt = driver.FindElement(By.XPath("//div[contains(@class, 'Am Al editable LW-avf')]"));
            txt.SendKeys("For me");
            Assert.IsNotNull(txt);
            IWebElement confirm = driver.FindElement(By.XPath("//div[contains(@class, 'T-I J-J5-Ji aoO T-I-atl L3')]"));
            confirm.Click();
            Assert.IsNotNull(confirm);
            IWebElement cheker = driver.FindElement(By.ClassName("vh"));
            Assert.IsNotNull(cheker);

            IWebElement refresh = driver.FindElement(By.XPath("//div[contains(@class, 'asf T-I-J3 J-J5-Ji')]"));
            refresh.Click();
        }

        [TestMethod]
        public void TestChromeDriver()
        {

            TestDriverEmail(new ChromeDriver(@"C:\Users\user\Desktop\"));

        }
        [TestMethod]
        public void TestFireFoxDriver()
        {
            TestDriverEmail(new FirefoxDriver());
        }
    }
}
