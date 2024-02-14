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
using SeleniumExtras.PageObjects;

namespace Forms.Tests
{
    [TestFixture]
    public class PreencherFormulario
    {
        private IWebDriver driver;
        private IWebDriver radioElement;
        private string baseURL;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

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
            HomePage homepage = new HomePage(driver);

            homepage.Click();            
            Thread.Sleep(2000);



            //EnterVehicleDataPage
            //Make
            EnterVehicleDataPage form1 = new EnterVehicleDataPage(driver);            

            form1.Make.Click();
            form1.Optionmake.Click();

            //Model
            form1.Model.Click();
            form1.Optionmodel.Click();

            //Cylinder Capacity
            form1.Cylindercapacity.SendKeys("300");

            //Engine Performance
            form1.Engineperformance.SendKeys("1500");


            //Date of Manufacture
            form1.Dateofmanufacture.SendKeys("02/01/2022");           
            Thread.Sleep(2000);

            //Number of Seats*
            form1.Numberofseatsmotorcycle.Click();
            form1.Optionnumberofseatsmotorcycle.Click();

            //List Price
            form1.Listprice.SendKeys("20000");


            //Annual Mileage
            form1.Annualmileage.SendKeys("10000");           
            Thread.Sleep(5000);

            //Button Next
            form1.Btnnextenterinsurantdata.Click();
                       
            
            //Espera
            WebDriverWait espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            espera.PollingInterval = TimeSpan.FromMilliseconds(500);

            IWebElement meuElemento = espera.Until(d => d.FindElement(By.Id("firstname")));


            //EnterInsurantDataPage            
            //First Name
            EnterInsurantDataPage form2 = new EnterInsurantDataPage(driver);

            form2.Firstname2.SendKeys("Josh");
           

            //Last Name
            form2.Lastname.SendKeys("Silva");
            
            //Date of Birth
            form2.Birthdate.SendKeys("02/01/2000");
            

            //Gender
            form2.Gender.Click();                      

            //Street Address
            form2.Streetaddress.SendKeys("Rua A");
            
            //Country
            form2.Country.Click();
            form2.OptionCountry.Click();            

            //Zip Code
            form2.Zipcode.SendKeys("2222");
            
            //City
            form2.City.SendKeys("Recife");
            
            //Occupation
            form2.Occupation.Click();
            form2.OptionOccupation.Click();
            
            //Hobbies
            form2.Hobbies.Click();
            
            //Website
            //Espera 
            //WebDriverWait  wait = new WebDriverWait(driver, new TimeSpan(0,0,10));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("website")));

            form2.Website.SendKeys("https://www.linkedin.com/in/johnnysoaresdemelo/");
            
            //Picture
            String Filepath = @"C:/Users/johnn/COMECOME.jpg";
            
            form2.Picturecontainer.SendKeys(Filepath);           
            Thread.Sleep(3000);

            IWebElement elementos = form2.PictureField;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(elementos.GetAttribute("title").Equals("COMECOME.jpg"));
            
            
            
            
        }



        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }



    }
}
