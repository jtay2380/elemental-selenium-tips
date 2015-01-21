using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Selenium_Elemental
{
    [TestClass]
    public class UploadAFile
    {
        public static IWebDriver Driver { get; set; }
        private TestContext testContextInstance;

        #region Test Context Setup
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #endregion


        [TestMethod]
        public void UploadFile()
        {
        }

        [TestInitialize]
        public void StartTest()
        {
            Driver = new FirefoxDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");
        }

        [TestCleanup]
        public void EndTest()
        {
            Driver.Quit();
        }



    }
}
