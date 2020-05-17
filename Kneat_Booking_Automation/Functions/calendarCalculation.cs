using OpenQA.Selenium;
using System;

namespace Kneat_Booking_Automation.Functions
{
    class calendarCalculation
    {
        readonly IWebDriver driver;
        By elCurrentCalendarMonthYear = By.XPath(".//*[@class='bui-calendar__month']");
        By elCalendarNextButton = By.XPath(".//*[@data-bui-ref='calendar-next']");

        public calendarCalculation(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void dateCalculation()
        {

            
            //Months ahead of time as well as the stay duraction can be updated
            int monthsAhead = 3;
            int daysStay = 1;




            //Get current date
            DateTime localDate = Convert.ToDateTime(DateTime.Now);
            //Console.WriteLine("The current date is: " + localDate);

            //Add require months and set the future Month and Year (YYY / mmmm)
            DateTime newDate = localDate.AddMonths(monthsAhead);
            string futureMonthYear = newDate.ToString("MMMM yyyy");
            //Console.WriteLine("The future Month and Year (YYY / mmmm) date is: " + futureMonthYear);

            //Set dateFrom
            string dateFrom = newDate.ToString("yyy-MM-dd");
            //Console.WriteLine("The dateFrom day is: " + dateFrom);

            //Set dateFrom
            DateTime dateToDay = newDate.AddDays(daysStay);
            string dateTo = dateToDay.ToString("yyy-MM-dd");
            //Console.WriteLine("The dateTo day is: " + dateTo);

            //Scrolling function to get to the correct Month
            do
            {
                string getCurrentMonth = driver.FindElement(elCurrentCalendarMonthYear).Text;
                if (String.Equals(getCurrentMonth, futureMonthYear))
                {
                    break;
                }
                driver.FindElement(elCalendarNextButton).Click();
            }
            while (true);
            driver.FindElement(By.XPath(".//*[@data-date='" + dateFrom + "']")).Click();
            driver.FindElement(By.XPath(".//*[@data-date='" + dateTo + "']")).Click();
        }
    }
}
