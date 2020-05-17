using OpenQA.Selenium;

namespace Kneat_Booking_Automation.Functions
{
    class isElementPresent
    {
        public bool IsElementPresentFunc(IWebDriver driver, By locator)
        {
            try
            {
                driver.FindElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
