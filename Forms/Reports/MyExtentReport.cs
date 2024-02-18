using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Reflection;
using OpenQA.Selenium;

namespace Forms.Reports
{
    public class MyExtentReports
    {
        private static ExtentReports extent;
        private static string reportPath = @"C:\Users\johnn\OneDrive\Área de Trabalho\johnny\Relatorios\extent.html";

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                var htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();                
                extent.AttachReporter(htmlReporter);
            }
            return extent;
        }
       
        public static void LogScreenshot(IWebDriver driver, ExtentTest test)
        {
            // Capture a tela como uma imagem
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            // Salve a captura de tela em um local temporário
            string screenshotPath = @"C:\Users\johnn\OneDrive\Área de Trabalho\johnny\Relatorios\Screenshot.png";
            screenshot.SaveAsFile(screenshotPath);

            // Adicione a captura de tela ao relatório
            test.AddScreenCaptureFromPath(screenshotPath);

            // Adicione uma mensagem ao relatório
            test.Info("Captura de tela do teste");

        }
    }
}
