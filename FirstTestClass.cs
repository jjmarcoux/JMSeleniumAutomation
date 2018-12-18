using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JMSeleniumAutomation
{
    [TestClass]
    public class FirstTestClass
    {
        [TestMethod]
        //This test simply opens Chrome browser, navigates to Google, maximizes, then closes. 
        public void ChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
        }
    }
}
