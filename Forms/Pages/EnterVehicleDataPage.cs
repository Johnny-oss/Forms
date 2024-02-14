using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;



namespace Forms.Pages
{
    internal class EnterVehicleDataPage
    {
        private readonly IWebDriver driver;

        public EnterVehicleDataPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "make")]        
        public IWebElement Make { get; set; }

        //IWebElement Make => driver.FindElement(By.Id("make"));
        [FindsBy(How = How.XPath, Using = "//*[@id='make']/option[7]")]
        public IWebElement Optionmake { get; set; }
        //IWebElement Optionmake => driver.FindElement(By.XPath("//*[@id='make']/option[7]"));


        [FindsBy(How = How.Id, Using = "model")]
        public IWebElement Model { get; set; }
        //IWebElement Model => driver.FindElement(By.Id("model"));

        [FindsBy(How = How.XPath, Using = "//*[@id='model']/option[2]")]
        public IWebElement Optionmodel { get; set; }
        //IWebElement Optionmodel => driver.FindElement(By.XPath("//*[@id='model']/option[2]"));


        [FindsBy(How = How.Id, Using = "cylindercapacity")]
        public IWebElement Cylindercapacity { get; set; }
        //IWebElement Cylindercapacity  =>  driver.FindElement(By.Id("cylindercapacity"));


        [FindsBy(How = How.Id, Using = "engineperformance")]
        public IWebElement Engineperformance { get; set; }
        //IWebElement Engineperformance =>  driver.FindElement(By.Id("engineperformance"));


        [FindsBy(How = How.Id, Using = "dateofmanufacture")]
        public IWebElement Dateofmanufacture { get; set; }
        //IWebElement Dateofmanufacture => driver.FindElement(By.Id("dateofmanufacture"));


        [FindsBy(How = How.Id, Using = "numberofseatsmotorcycle")]
        public IWebElement Numberofseatsmotorcycle { get; set; }
        //IWebElement Numberofseatsmotorcycle => driver.FindElement(By.Id("numberofseatsmotorcycle"));

        [FindsBy(How = How.XPath, Using = "//*[@id='numberofseatsmotorcycle']/option[2]")]
        public IWebElement Optionnumberofseatsmotorcycle { get; set; }
        //IWebElement Optionnumberofseatsmotorcycle => driver.FindElement(By.XPath("//*[@id='numberofseatsmotorcycle']/option[2]"));


        [FindsBy(How = How.Id, Using = "listprice")]
        public IWebElement Listprice { get; set; }
        //IWebElement Listprice => driver.FindElement(By.Id("listprice"));


        [FindsBy(How = How.Id, Using = "annualmileage")]
        public IWebElement Annualmileage { get; set; }
        //IWebElement Annualmileage => driver.FindElement(By.Id("annualmileage"));


        [FindsBy(How = How.Id, Using = "nextenterinsurantdata")]
        public IWebElement Btnnextenterinsurantdata { get; set; }
        //IWebElement Btnnextenterinsurantdata => driver.FindElement(By.Id("nextenterinsurantdata"));





    }

}
