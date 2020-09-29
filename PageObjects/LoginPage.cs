using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OnlineStore.TestDataAccess;
using OnlineStore.Extensions;


namespace OnlineStore.PageObjects
{
    class LoginPage
    { 

        [FindsBy(How = How.Id, Using = "username")]
        [CacheLookup]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        private IWebElement Submit { get; set; }

        public void LoginToApplication(string testName)
        {
            var userData = ExcelDataAccess.GetTestData(testName);
            UserName.EnterText(userData.Username, "Username");
            Password.EnterText(userData.Password, "Password");
            Submit.ClickOnIt("SubmitButton");
        }
    }


}
