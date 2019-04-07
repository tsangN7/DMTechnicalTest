using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using TechnicalTest.PageObjects;

namespace TechnicalTest.Tests.Scenario3
{
    [TestFixture]
    class Scenario3
    {

        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        //Scenario 3 - Verify that the error text contains "Email address is required"
        public void Test3()
        {
            HomePage home = new HomePage(driver);
            home.goToHomePage();
            home.PopulateFirstname("fnametest");
            home.PopulateLastname("lnametest");
            home.SelectSubmit();
            Thread.Sleep(2000);
            Assert.IsNotNull(driver.FindElement(By.XPath("//div[normalize-space()='Email Address is required.']")));          
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
