using OpenQA.Selenium;

namespace Kneat_Booking_Automation.Pages
{
    public class LandingPage
    {
        //Declare Page Objects
        IWebDriver driver;
        By elLocation = By.Id("ss");
        By elCalendar = By.CssSelector("div.xp__dates.xp__group");
        By elLocationSearchButton = By.CssSelector("div.sb-searchbox-submit-col.-submit-button");

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Create functions
        public void enterLocation()
        {
            driver.FindElement(elLocation).SendKeys("Limerick");
        }
        public void selectCalendar()
        {
            driver.FindElement(elCalendar).Click();
        }
        public void searchHotels()
        {
            driver.FindElement(elLocationSearchButton).Click();
        }

    }
}
