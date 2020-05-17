using Kneat_Booking_Automation.BaseClass;
using NUnit.Framework;
using Kneat_Booking_Automation.Pages;

namespace Kneat_Booking_Automation
{
    [TestFixture]
    class FilterTest : Base
    {
        [Test]
        public void setupConfirmation()
        {
            //Initialize required classes
            LandingPage landingPage = new LandingPage(driver);
            SearchPage search = new SearchPage(driver);

            //Perform search on provided information
            landingPage.searchHotels();

            //Assertions:
            //Limerick Strand Hotel - Is Listed = True
            //George Limerick Hotel - Is Listed = True
            //The Savoy Hotel       - Is Listed = True
            Assert.IsTrue(search.LimerickStrandHotelElement());
            Assert.IsTrue(search.GeorgeLimerickHotelElement());
            Assert.IsTrue(search.TheSavoyHotelElement());
        }

        [Test]
        public void SaunaFilter()
        {
            //Initialize required classes
            LandingPage landingPage = new LandingPage(driver);
            SearchPage search = new SearchPage(driver);

            //Perform search on provided information
            landingPage.searchHotels();

            //Apply Sauna Filter
            search.selectSauna();

            //Assertions:
            //Limerick Strand Hotel - Is Listed = True
            //George Limerick Hotel - Is Listed = False
            Assert.IsTrue(search.LimerickStrandHotelElement());
            Assert.IsFalse(search.GeorgeLimerickHotelElement());
        }

        [Test]
        public void FiveStarFilter()
        {
            //Initialize required classes
            LandingPage landingPage = new LandingPage(driver);
            SearchPage search = new SearchPage(driver);

            //Perform search on provided information
            landingPage.searchHotels();

            //Apply 5Star Filter
            search.selectFiveStar();
   
            //Assertions:
            //The Savoy Hotel       - Is Listed = True
            //George Limerick Hotel - Is Listed = False
            Assert.IsTrue(search.TheSavoyHotelElement());
            Assert.IsFalse(search.GeorgeLimerickHotelElement());
        }

    }
}

