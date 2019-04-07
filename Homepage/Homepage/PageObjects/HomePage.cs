using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;

namespace TechnicalTest.PageObjects
{
    class HomePage
    {
        
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        
        //signup fields
        [FindsBy(How = How.Name, Using = "fname")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Name, Using = "lname")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".button.sqs-system-button.sqs-editable-button")]
        private IWebElement submitButton { get; set; }

        //Enquire fields
        [FindsBy(How = How.Id, Using = "block-yui_3_17_2_1_1526466173423_89535")]
        private IWebElement enquire { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/form/div/fieldset/div[2]/label/input")]
        private IWebElement enquireFirstname{ get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/form/div/fieldset/div[3]/label/input")]
        private IWebElement enquireLastname { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[3]/textarea")]
        private IWebElement enquireMessage { get; set; }

        [FindsBy(How = How.Id, Using = "text-yui_3_17_2_1_1526466173423_81520-field")]
        private IWebElement enquireSubject { get; set; }


        public void goToHomePage()
        {
            driver.Navigate().GoToUrl("https://www.deepmatter.io/");
        }

       

        public void PopulateFirstname(string fname)
        {
            firstName.Clear();
            firstName.SendKeys(fname);
        }
        public void PopulateLastname(string lname)
        {
            lastName.Clear();
            lastName.SendKeys(lname);
        }

        public void SelectSubmit()
        {
            submitButton.Click();
        }

        public void SelectHowPerformsWorks()
        {
            driver.FindElements(By.ClassName("Index-nav-item"))[3].Click();

        }

        public void EnquireButton()
        {
            enquire.Click();
        }
        public void EnquireFirstName(string EnquireFname)
        {
            enquireFirstname.Clear();
            enquireFirstname.SendKeys(EnquireFname);
        }

        public void EnquireLastName(string EnquireLname)
        {
            enquireLastname.Clear();
            enquireLastname.SendKeys(EnquireLname);
        }

        public void EnquireEmail()
        {
            driver.FindElements(By.Name("email"))[1].SendKeys("emailtest@test.com");

        }
        public void EnquireSubject(String EnquireSub)
        {
            enquireSubject.Clear();
            enquireSubject.SendKeys(EnquireSub);
        }
        public void EnquireMessage(string EnquireMess)
        {
            enquireMessage.Clear();
            enquireMessage.SendKeys(EnquireMess);
        }

        public void EnquireSubmit()
        {
             driver.FindElement(By.XPath("//input[@class='button sqs-system-button']")).Click();
        }

        public void TakeScreenshot()
        {
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile("C:/Users/Screenshot.png", ScreenshotImageFormat.Png);
        }      
    }
}

