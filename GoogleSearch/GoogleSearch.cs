using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace GoogleSearch
{
    [TestClass]
    public class GoogleSearch
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Test Change

            var driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://accounts.google.com/ServiceLogin");

            //Login
            driver.FindElement(By.Id("Email")).SendKeys("test.26.05.test");
            driver.FindElement(By.Id("Passwd")).SendKeys("Pa$$word1234567890");
            driver.FindElement(By.Id("signIn")).Click();
            driver.Navigate().GoToUrl("http://www.gmail.com");

            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            IWebElement elem = wait.Until<IWebElement>((d) => d.FindElement(By.Id("")));

            //New Mail
            driver.FindElement(By.CssSelector("div[class='T-I J-J5-Ji T-I-KE L3']")).Click();
            driver.FindElement(By.Name("to")).SendKeys("test.26.05.test@gmail.com");
            driver.FindElement(By.Name("subjectbox")).SendKeys("This is a test");
            //
            //driver.FindElement(By.CssSelector("div[class='Ar Au Ao']")).SendKeys("This is a test");
            //
            driver.FindElement(By.CssSelector("div[class='T-I J-J5-Ji aoO T-I-atl L3']")).Click();
            driver.FindElement(By.CssSelector("a[href*='inbox']")).Click();

#if true
            //Logout
            driver.FindElement(By.XPath("//div[@id='gb']/div/div/div/div[3]/div/a")).Click();
            driver.FindElement(By.Id("gb_71")).Click();

            //Close Browser
            driver.Quit();
#endif

        }
        
    }
}
