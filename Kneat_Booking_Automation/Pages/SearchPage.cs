using Kneat_Booking_Automation.Functions;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Kneat_Booking_Automation.Pages
{
    public class SearchPage
    {
        //Declare Page Objects
        IWebDriver driver;
        By elGeorgeLimerickHotel = By.XPath("//*[@id='hotellist_inner']/div[20]/div[2]/div[1]/div[1]/div[1]/h3/a/span[1]");
        By elTheSavoyHotel = By.XPath("//*[@id='hotellist_inner']/div[1]/div[2]/div[1]/div[1]/div[1]/h3/a/span[1]");
        By elLimerickStrandHotel = By.XPath("//*[@id='hotellist_inner']/div[2]/div[2]/div[1]/div[1]/div[1]/h3/a/span[1]");
        By elSaunaElement = By.XPath("//*[@id='filter_popular_activities']/div[2]/a[3]/label/div/span[1]");
        By elFiveStarElement = By.XPath("//*[@id='filter_class']/div[2]/a[3]/label/div/span[1]");

        public SearchPage (IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool GeorgeLimerickHotelElement()
        {
            Thread.Sleep(1000);
            return new isElementPresent().IsElementPresentFunc(driver, elGeorgeLimerickHotel);
        }
        public bool TheSavoyHotelElement()
        {
            Thread.Sleep(1000);
            return new isElementPresent().IsElementPresentFunc(driver, elTheSavoyHotel);
        }
        public bool LimerickStrandHotelElement()
        {
            Thread.Sleep(1000);
            return new isElementPresent().IsElementPresentFunc(driver, elLimerickStrandHotel);
        }

        public void selectSauna()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement element = driver.FindElement(elSaunaElement);
            element.Click();
        }

        public void selectFiveStar()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement element = driver.FindElement(elFiveStarElement);
            element.Click();
        }
    }
}