using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Forms.Pages;

namespace Forms.Tests
{
    [TestFixture]
    public class PreencherFormulario
    {
        private IWebDriver driver;
        private IWebDriver radioElement;
        private string baseURL;
        private StringBuilder verificationErrors;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            baseURL = "https://sampleapp.tricentis.com/101/";
            driver.Navigate().GoToUrl(baseURL);
            verificationErrors = new StringBuilder();
            

        }


        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("", verificationErrors.ToString());

        }


        [Test]
        public void PreencherFormularioTest()
        {   
            //HomePage
            Thread.Sleep(2000);
            driver.FindElement(By.Id("nav_motorcycle")).Click();
            Thread.Sleep(2000);



            //EnterVehicleDataPage
            //Make
            driver.FindElement(By.Id("make")).Click();
            driver.FindElement(By.XPath("//*[@id='make']/option[7]")).Click();

            //Model
            driver.FindElement(By.Id("model")).Click();
            driver.FindElement(By.XPath("//*[@id='model']/option[2]")).Click();

            //Cylinder Capacity
            driver.FindElement(By.Id("cylindercapacity")).SendKeys("300");

            //Engine Performance
            driver.FindElement(By.Id("engineperformance")).SendKeys("1500");

            //Date of Manufacture
            driver.FindElement(By.Id("dateofmanufacture")).SendKeys("02/01/2022");
            Thread.Sleep(2000);

            //Number of Seats*
            driver.FindElement(By.Id("numberofseatsmotorcycle")).Click();
            driver.FindElement(By.XPath("//*[@id='numberofseatsmotorcycle']/option[2]")).Click();

            //List Price
            driver.FindElement(By.Id("listprice")).SendKeys("20000");

            //Annual Mileage
            driver.FindElement(By.Id("annualmileage")).SendKeys("10000");
            Thread.Sleep(5000);

            //Button Next
            driver.FindElement(By.Id("nextenterinsurantdata")).Click();
                        


            //EnterInsurantDataPage            
            //First Name
            driver.FindElement(By.Id("firstname")).SendKeys("Josh");

            //Last Name
            driver.FindElement(By.Id("lastname")).SendKeys("Silva");

            //Date of Birth
            driver.FindElement(By.Id("birthdate")).SendKeys("02/01/2000");

            //Gender
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/form/div/section[2]/div[4]/p/label[1]/span")).Click();           

            //Street Address
            driver.FindElement(By.Id("streetaddress")).SendKeys("Rua A");

            //Country
            driver.FindElement(By.Id("country")).Click();
            driver.FindElement(By.XPath("//*[@id='country']/option[32]")).Click();

            //Zip Code
            driver.FindElement(By.Id("zipcode")).SendKeys("2222");

            //City
            driver.FindElement(By.Id("city")).SendKeys("Recife");

            //Occupation
            driver.FindElement(By.Id("occupation")).Click();
            driver.FindElement(By.XPath("//*[@id='occupation']/option[4]")).Click();

            //Hobbies
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/form/div/section[2]/div[10]/p/label[5]/span")).Click();

            //Website    
            driver.FindElement(By.Id("website")).SendKeys("https://www.linkedin.com/in/johnnysoaresdemelo/");

            //Picture
            String Filepath = @"C:/Users/johnn/COMECOME.jpg";
            
            driver.FindElement(By.Id("picturecontainer")).SendKeys(Filepath);
            Thread.Sleep(3000);

            IWebElement elemento = driver.FindElement(By.Id("picture"));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(elemento.GetAttribute("title").Equals("COMECOME.jpg"));
            
            

            
        }



    }
}
