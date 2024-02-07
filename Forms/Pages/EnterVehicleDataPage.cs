using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Pages
{
    internal class EnterVehicleDataPage
    {
        private readonly IWebDriver driver;

        public EnterVehicleDataPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement Make => driver.FindElement(By.Id("make"));
        IWebElement Optionmake => driver.FindElement(By.XPath("//*[@id='make']/option[7]"));

        IWebElement Model => driver.FindElement(By.Id("model"));
        IWebElement Optionmodel => driver.FindElement(By.XPath("//*[@id='model']/option[2]"));

        IWebElement Cylindercapacity  =>  driver.FindElement(By.Id("cylindercapacity"));

        IWebElement Engineperformance =>  driver.FindElement(By.Id("engineperformance"));

        IWebElement Dateofmanufacture => driver.FindElement(By.Id("dateofmanufacture"));

        IWebElement Numberofseatsmotorcycle => driver.FindElement(By.Id("numberofseatsmotorcycle"));
        IWebElement Optionnumberofseatsmotorcycle => driver.FindElement(By.XPath("//*[@id='numberofseatsmotorcycle']/option[2]"));

        IWebElement Listprice => driver.FindElement(By.Id("listprice"));

        IWebElement Btnnextenterinsurantdata => driver.FindElement(By.Id("nextenterinsurantdata"));



    }

}
