using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace Forms.Pages
{
    internal class EnterInsurantDataPage
    {
        private readonly IWebDriver driver;

        public EnterInsurantDataPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        //[FindsBy(How = How.Id, Using = "firstname")]
        //public IWebElement Firstname { get; set; }
        public IWebElement Firstname2 => driver.FindElement(By.Id("firstname"));


        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement Lastname { get; set; }
        //IWebElement Lastname => driver.FindElement(By.Id("lastname"));

        [FindsBy(How = How.Id, Using = "birthdate")]
        public IWebElement Birthdate { get; set; }
        //IWebElement Birthdate => driver.FindElement(By.Id("birthdate"));
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div/form/div/section[2]/div[4]/p/label[1]/span")]
        public IWebElement Gender { get; set; }
        //IWebElement Gender => driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/form/div/section[2]/div[4]/p/label[1]/span"));


        [FindsBy(How = How.Id, Using = "streetaddress")]
        public IWebElement Streetaddress { get; set; }
        //IWebElement Streetaddress => driver.FindElement(By.Id("streetaddress"));


        [FindsBy(How = How.Id, Using = "country")]
        public IWebElement Country { get; set; }
        //IWebElement Country => driver.FindElement(By.Id("country"));

        [FindsBy(How = How.XPath, Using = "//*[@id='country']/option[32]")]
        public IWebElement OptionCountry { get; set; }
        //IWebElement OptionCountry=> driver.FindElement(By.XPath("//*[@id='country']/option[32]"));


        [FindsBy(How = How.Id, Using = "zipcode")]
        public IWebElement Zipcode { get; set; }
        //IWebElement Zipcode => driver.FindElement(By.Id("zipcode"));


        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement City { get; set; }
        //IWebElement City => driver.FindElement(By.Id("city"));


        [FindsBy(How = How.Id, Using = "occupation")]
        public IWebElement Occupation { get; set; }
        //IWebElement Occupation => driver.FindElement(By.Id("occupation"));

        [FindsBy(How = How.XPath, Using = "//*[@id='occupation']/option[4]")]
        public IWebElement OptionOccupation { get; set; }
        //IWebElement OptionOccupation => driver.FindElement(By.XPath("//*[@id='occupation']/option[4]"));


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div/form/div/section[2]/div[10]/p/label[5]/span")]
        public IWebElement Hobbies { get; set; }
        //IWebElement Hobbies =>  driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/form/div/section[2]/div[10]/p/label[5]/span"));


        [FindsBy(How = How.Id, Using = "website")]
        public IWebElement Website { get; set; }
        //IWebElement Website => driver.FindElement(By.Id("website"));


        [FindsBy(How = How.Id, Using = "picturecontainer")]
        public IWebElement Picturecontainer { get; set; }
        //IWebElement Picturecontainer => driver.FindElement(By.Id("picturecontainer"));

        [FindsBy(How = How.Id, Using = "picture")]
        public IWebElement PictureField { get; set; }
        //IWebElement PictureField => driver.FindElement(By.Id("picture"));




    }
}
