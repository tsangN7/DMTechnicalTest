using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechnicalTest.PageObjects;

namespace TechnicalTest.Tests.Scenario2
{
    [TestFixture]
    class Scenario2
    {

        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        //Scenario 2 - Verify that the target for the investor relations link is "http://www.deepmattergroup.com/"
        public void Test2()
        {
            HomePage home = new HomePage(driver);
            home.goToHomePage();
            IWebElement urlCheck = driver.FindElement(By.PartialLinkText("Investor relations"));
            var url = urlCheck.GetAttribute("href");
            Assert.IsTrue(url.Equals("http://www.deepmattergroup.com/"));
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
