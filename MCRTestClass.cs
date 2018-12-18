using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JMSeleniumAutomation
{
    [TestClass]
    public class MCRTestClass
    {
        [TestMethod]
        //This test simply opens Chrome browser, navigates to MCR Search, maximizes, then closes. 
        public void MCRSearchMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://cerrsng.test.cognosante.cc/webresources/cog_/MCRSearchv2/Index.html#!/search");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
        }
    }
}
