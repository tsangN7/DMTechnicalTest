using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TechnicalTest.PageObjects;

namespace TechnicalTest.Tests.Scenario5
{
    [TestFixture]
    class Scenario5
    {

        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        //Scenario 5 - Ensure the "enquire about our pioneer programme can be submitted"
        public void Test5()
        {
            HomePage home = new HomePage(driver);
            home.goToHomePage();
            home.EnquireButton();
            home.EnquireFirstName("this is nick");
            home.EnquireLastName("2nd name here");
            home.EnquireEmail();
            home.EnquireSubject("my Subject line");
            home.EnquireMessage("This is a message");
            //home.EnquireSubmit();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}

