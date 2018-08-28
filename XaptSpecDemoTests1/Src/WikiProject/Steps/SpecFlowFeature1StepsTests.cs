using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace XaptSpecDemo.Tests
{

    [TestClass()]
    public class SpecFlowFeature1StepsTests
    {
        /*
         * I create the Test webdriver 
         */
        private IWebDriver testDriver;

        [TestMethod()]
        public void GivenINavigateToTheTest()
        {
            //I create the firefox webdriver
            testDriver = new FirefoxDriver();
            Assert.IsNotNull(testDriver);

            // I mock out the URL
            string url = "https://www.google.hu/";
            // Than I navigate to the mocked URL
            testDriver.Navigate().GoToUrl(url);

            // Here I check the actual testWebdriver URL is equal with the excepted URL or not
            Assert.AreEqual("https://www.google.hu/",testDriver.Url);

            // Close the webdriver
            testDriver.Quit();
        }
    }
}