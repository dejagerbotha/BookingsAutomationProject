# Bookings.com Automation Project

This was a QA automation test, to add some automation features to the https://www.booking.com/ website with expected results based on  filter selection. 

Packages used and version (see packages.config):
- IDE: Microsoft Visual Studio Community 2019 Version 16.5.5
- "NUnit" version="3.12.0"
- "NUnit3TestAdapter" version="3.16.1"
- "Selenium.Chrome.WebDriver" version="81.0.0"
- "Selenium.WebDriver" version="3.141.0"

Custom functions were added to perform the require actions needed for the exercise:
- calendarCalculation: This was needed to navigate the calendar modal on the loading page. A do while loop was added to cycle through the month / year combination until a match was found.
- isElementPresent: This is a function to return a boolean value depending if an element is visable or not. This was needed to provide the assertions for the expected results based off the filter criteria. 

