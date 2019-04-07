# DMTechnicalTest
To run the automation test suite, you need to download Visual Studio (currently using 2017 Enterprise) https://visualstudio.microsoft.com/downloads/

Once downloaded and installed, run Visual Studio as Adminstrator (Scenario 4 will fail if ran as a normal user) 

Open up the project(look for NickTsang.sln)

Then go to Tools> NuGet package Manager> Manage NuGet Package for Solution

Browse and install the following packages:

Nunit

Selenium.Chrome.WebDriver

Selenium.WebDriver

DotNetSeleniumExtras.PageObjects

Once istalled, the tests are ready to be ran. Test>Run>AllTests
