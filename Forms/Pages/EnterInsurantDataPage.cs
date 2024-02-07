using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Pages
{
    internal class EnterInsurantDataPage
    {
        private readonly IWebDriver driver;

        public EnterInsurantDataPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement Firstname => driver.FindElement(By.Id("firstname"));

        IWebElement Lastname => driver.FindElement(By.Id("lastname"));

        IWebElement Birthdate => driver.FindElement(By.Id("birthdate"));

        IWebElement Gender => driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/form/div/section[2]/div[4]/p/label[1]/span"));

        IWebElement Streetaddress => driver.FindElement(By.Id("streetaddress"));

        IWebElement Country => driver.FindElement(By.Id("country"));
        IWebElement OptionCountry=> driver.FindElement(By.XPath("//*[@id='country']/option[32]"));

        IWebElement Zipcode => driver.FindElement(By.Id("zipcode"));

        IWebElement City => driver.FindElement(By.Id("city"));

        IWebElement Occupation => driver.FindElement(By.Id("occupation"));
        IWebElement OptionOccupation => driver.FindElement(By.XPath("//*[@id='occupation']/option[4]"));

        IWebElement Hobbies =>  driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/form/div/section[2]/div[10]/p/label[5]/span"));

        IWebElement Website => driver.FindElement(By.Id("website"));

        IWebElement Picturecontainer => driver.FindElement(By.Id("picturecontainer"));

        IWebElement PictureField => driver.FindElement(By.Id("picture"));




    }
}
