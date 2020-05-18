using Kneat_Booking_Automation.Functions;
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
        By elGuestModal = By.XPath("//*[@id='xp__guests__toggle']");
        //Adult elements
        By elAdultValueLookUp = By.XPath("//*[@id='group_adults' and @value]");
        By elAdultAdd = By.XPath("//*[@id='xp__guests__inputs-container']/div/div/div[1]/div/div[2]/button[2]");
        By elAdultRemove = By.XPath("//*[@id='xp__guests__inputs-container']/div/div/div[1]/div/div[2]/button[1]");
        //Children elements
        By elChildrenValueLookUp = By.XPath("//*[@id='group_children' and @value]");
        By elChildrenAdd = By.XPath("/html/body/div[5]/div/div/div[2]/form/div[1]/div[3]/div[2]/div/div/div[2]/div/div[2]/button[2]");
        By elChildrenRemove = By.XPath("/html/body/div[5]/div/div/div[2]/form/div[1]/div[3]/div[2]/div/div/div[2]/div/div[2]/button[1]");
        //Room elements
        By elRoomsValueLookUp = By.XPath("//*[@id='no_rooms' and @value]");
        By elRoomsAdd = By.XPath("//html/body/div[5]/div/div/div[2]/form/div[1]/div[3]/div[2]/div/div/div[3]/div/div[2]/button[2]");
        By elRoomsRemove = By.XPath("/html/body/div[5]/div/div/div[2]/form/div[1]/div[3]/div[2]/div/div/div[3]/div/div[2]/button[1]");




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
        public void selectGuestRequirementModal ()
        {
            driver.FindElement(elGuestModal).Click();
        }

        //Function to select the guest requirements (Adults, Children and Rooms)
        public void requiredAdultsSelect ()
        {
            guestToggle guest = new guestToggle(driver);
            string currentPeople = driver.FindElement(elAdultValueLookUp).GetAttribute("value");
            guest.numberSelector(currentPeople, 2, elAdultAdd, elAdultRemove);
        }
        public void requiredChildrenSelect()
        {
            guestToggle guest = new guestToggle(driver);
            string currentChildren = driver.FindElement(elChildrenValueLookUp).GetAttribute("value");
            guest.numberSelector(currentChildren, 0, elChildrenAdd, elChildrenRemove);
        }
        public void requiredRoomsSelect()
        {
            guestToggle guest = new guestToggle(driver);
            string currentRooms = driver.FindElement(elRoomsValueLookUp).GetAttribute("value");
            guest.numberSelector(currentRooms, 1, elRoomsAdd, elRoomsRemove);
        }
    }
}
