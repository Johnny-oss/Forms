using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Pages
{
    internal class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement moto => driver.FindElement(By.Id("nav_motorcycle"));


        public void Click()
        {
            moto.Click();
        }

    }
}
