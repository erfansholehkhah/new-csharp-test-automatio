using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace LatestAutomation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver  = GetChromeDriver();
            driver.Navigate().GoToUrl("");
            
        }
        private IWebDriver GetChromeDriver() 
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
