using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OnlineStore.Extensions;



namespace OnlineStore.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "/html/body/p/a")] [CacheLookup]
        private IWebElement DismissBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'My Account')]")] [CacheLookup]
        private IWebElement MyAccount { get; set; }

        public void GoToMyAccountPage()
        {
            DismissBut.ClickOnIt("DismissBut");
            MyAccount.ClickOnIt("MyAccount");
        }
    }
}
