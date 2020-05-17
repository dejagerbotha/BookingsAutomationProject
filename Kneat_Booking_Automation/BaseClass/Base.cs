using Kneat_Booking_Automation.Functions;
using Kneat_Booking_Automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Kneat_Booking_Automation.BaseClass
{
    [TestFixture]
    class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.booking.com/");

            //Initialize required classes
            LandingPage landingPage = new LandingPage(driver);
            calendarCalculation calendarSelection = new calendarCalculation(driver);
            SearchPage search = new SearchPage(driver);

            //Set location
            landingPage.enterLocation();
            //Select Calendar
            landingPage.selectCalendar();

            //Initialize calendar and execute function
            calendarSelection.dateCalculation();
        }

        [TearDown]
        public void closeBrower()
        {
            //driver.Manage().Window.Maximize();
            driver.Close();
        }
    }
}
