using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using TechnicalTest.PageObjects;

namespace TechnicalTest.Tests.Scenario4
{
    [TestFixture]
    class Scenario4
    {

        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        //Scenario 4 - Take a screenshot of "How our platform works"
        public void Test4()
        {
            HomePage home = new HomePage(driver);
            home.goToHomePage();
            home.SelectHowPerformsWorks();
            Thread.Sleep(1000);
            home.TakeScreenshot();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
