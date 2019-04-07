using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TechnicalTest.Tests.Scenario1
{
    [TestFixture]
    class Scenario1
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        // Scenario 1 - Verify the that deepmatter site is present in the search results
        public void Test1()
        {
            driver.Url = "https://www.google.com/";
            IWebElement searchengine = driver.FindElement(By.Name("q"));
            searchengine.SendKeys("Deepmatter");
            searchengine.Submit();
            var urlToFind = "https://www.deepmatter.io/";

            IWebElement Verify = driver.FindElement(By.PartialLinkText(urlToFind));

            Assert.IsTrue(Verify.Text.Contains(urlToFind));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}




