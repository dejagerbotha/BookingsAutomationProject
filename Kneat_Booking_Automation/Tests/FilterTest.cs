﻿using Kneat_Booking_Automation.BaseClass;
using NUnit.Framework;
using Kneat_Booking_Automation.Pages;
using OpenQA.Selenium;
using System;

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
            Assert.IsTrue(search.LimerickStrandHotelElement());
            //George Limerick Hotel - Is Listed = True
            Assert.IsTrue(search.GeorgeLimerickHotelElement());
            //The Savoy Hotel       - Is Listed = True
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
            Assert.IsTrue(search.LimerickStrandHotelElement());
            //George Limerick Hotel - Is Listed = False
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
            Assert.IsTrue(search.TheSavoyHotelElement());
            //George Limerick Hotel - Is Listed = False
            Assert.IsFalse(search.GeorgeLimerickHotelElement());
        }

    }
}

