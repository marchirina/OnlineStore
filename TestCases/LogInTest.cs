using NUnit.Framework;
using OnlineStore.PageObjects;
using OnlineStore.WrapperFactory;
using OpenQA.Selenium;
using System.Configuration;

namespace OnlineStore.TestCases
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            BrowserFactory.InitBrowser("Firefox");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            BrowserFactory.OpenFullScreen();

            Page.Home.GoToMyAccountPage();
       
            Page.Login.LoginToApplication("LoginTest");

            // Close the driver
            BrowserFactory.CloseAllDrivers();
        }
    }
}
