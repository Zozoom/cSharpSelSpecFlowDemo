using System;
using OpenQA.Selenium;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;

namespace CoreCommonSteps
{
    public class CommonSteps
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /*
         * Private Scroll to the element method, this method will scroll to the selected element.
         * @element - this is the element that you want to scroll to.
         */
        public void ScrollToTheElement(IWebElement element, IWebDriver driver)
        {
            try
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Perform();
            }
            catch (Exception e)
            {
                log.Info("Error message: " + e);
            }
        }
    }
}
