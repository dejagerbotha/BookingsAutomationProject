using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kneat_Booking_Automation.Functions
{
    class guestToggle
    {
        readonly IWebDriver driver;

        public guestToggle(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void numberSelector(string guestLookUp, int required, By addElement, By removeElement)
        {

            int current = 0;
            int.TryParse(guestLookUp, out current);

            while (current != required)
            {
                if (current < required)
                {
                    //Click add button
                    driver.FindElement(addElement).Click();
                    current++;
                }
                else if (current > required)
                {
                    //Click subtract button
                    driver.FindElement(removeElement).Click();
                    current--;
                }
            }
        }
    }
}
