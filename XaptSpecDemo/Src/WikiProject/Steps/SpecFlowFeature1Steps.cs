using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;
using CoreCommonSteps;

namespace XaptSpecDemo
{

    [Binding]
    public class SpecFlowFeature1Steps
    {

        private IWebDriver driver;
        private CommonSteps comSteps = new CommonSteps();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /*
         * Open a firefox web browser and Maximize the browser size.
         */
        [Given(@"I open the firefox browser")]
        public void GivenIOpenTheFirefoxBrowser()
        {
            log.Info("Open a Firefox browser");
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        /*
         * Navigate to the given URL using the driver
         */
        [Then(@"I navigate to the ""(.*)""")]
        public void GivenINavigateToThe(string url)
        {
            log.Info("This is the site: " + url);
            driver.Navigate().GoToUrl(url);
        }

        /*
         * This step will find the appropriate element based on the parameters and clicks on it
         */
        [Then(@"I choose the ""(.*)"" language")]
        public void ThenIChooseTheLanguage(string lang)
        {
            log.Info("I clicked on the: " + lang);

            string xpath = "//div//strong[contains(.,'" + lang + "')]/../..";
            var element = driver.FindElement(By.XPath(xpath));

            true.Equals(driver.FindElement(By.XPath(xpath)).Displayed);
            comSteps.ScrollToTheElement(element,driver);
            element.Click();
        }

        /*
         * This step will find the search field and clicks into it
         */
        [Then(@"I click into the search field")]
        public void ThenIClickIntoTheSearchField()
        {
            log.Info("I clicked into the search field.");

            string xpath = "//input[@type='search']";
            var element = driver.FindElement(By.XPath(xpath));

            true.Equals(element.Displayed);
            element.Click();
        }

        /*
         * This step will write the searched text into the search field
         */
        [Then(@"I search for the following ""(.*)"" text")]
        public void ThenISearchForTheFollowingText(string searchText)
        {
            log.Info("I write in the following: " + searchText);

            string xpath = "//input[@type='search']";
            var element = driver.FindElement(By.XPath(xpath));

            true.Equals(element.Displayed);
            element.SendKeys(searchText);
        }

        /*
         * This step will click on the magnifying glass and submit the content of the search field 
         */
        [Then(@"I click on the magnifying glass icon")]
        public void ThenIClickOnTheMagnifyingGlassIcon()
        {
            log.Info("Clicking on the magnifying glass for searching.");

            string xpath = "//input[@type='submit']";
            var element = driver.FindElement(By.XPath(xpath));

            true.Equals(element.Displayed);
            element.Click();
        }

        /* 
         * This step will check if the text is findable on the site.
         */
        [Then(@"I check whether the ""(.*)"" text is contained on the site")]
        public void ThenICheckWhetherTheTextIsContainedOnTheSite(string findText)
        {
            log.Info("Checking the text is appears on the site. Text:" + findText);

            true.Equals(driver.FindElement(By.XPath("//*[contains(.,'"+ findText + "')]")).Displayed);
        }

        /*
         * This step will check whether the Test Automation Interface picture appears on the site.
         */
        [Then(@"I check whether the Test Automation Interface picture is appear on the site")]
        public void ThenICheckWhetherThePictureIsAppearOnTheSite()
        {
            log.Info("Checking the Test Automation Interface picture is appears on the site.");

            true.Equals(driver.FindElement(By.XPath("//*[@class='image' and contains(@href,'Test_Automation_Interface')]")).Displayed);
        }

        /*
         * This step will find the link which contains the Behavior driven development text
         */
        [Then(@"Finally I check the ""(.*)"" link is appear and I navigate to there")]
        public void ThenFinallyICheckTheLinkIsAppearAndINavigateToThere(string findLinkByText)
        {
            log.Info("I clicked on the: " + findLinkByText);

            string xpath = "//a[contains(.,'" + findLinkByText + "')]";
            var element = driver.FindElement(By.XPath(xpath));

            true.Equals(driver.FindElement(By.XPath(xpath)).Displayed);
            comSteps.ScrollToTheElement(element, driver);
            element.Click();
        }

        /*
         * This method will close the browser itself.         
         */
        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
        }


    }
}
