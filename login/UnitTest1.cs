using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace selenium_test_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void demo()
        {

            Console.WriteLine("Test is Started");

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://facebook.com");

            Thread.Sleep(2000);

        

            IWebElement eleSessionKey = driver.FindElement(By.Name("email"));

            IWebElement elePassword = driver.FindElement(By.Name("pass"));

            eleSessionKey.SendKeys("username");

            Thread.Sleep(2000);
            elePassword.SendKeys("password");
            IWebElement eleSubmitBtn = driver.FindElement(By.Name("login"));
            Thread.Sleep(1000);
            eleSubmitBtn.Click();

            Thread.Sleep(55000);

            driver.Close();
            Console.WriteLine("Test is Ended ");
        }
        
    }
}