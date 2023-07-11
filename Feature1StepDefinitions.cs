using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V112.Security;
using System;
using System.Reflection.Metadata;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace TestProjectUI
{
    [Binding]
    public class Feature1StepDefinitions
    {

        IWebDriver driver;

        [Given(@"I go to Google")]
        public void GivenIGoToGoogle()
        {

           // IWebDriver driver;

            ChromeOptions options = new ChromeOptions()
            {
                BinaryLocation = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"
            };

            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://www.labcorp.com/");

            Thread.Sleep(1000);
            Thread.Sleep(1000);

            Thread.Sleep(1000);

            driver.Manage().Window.Maximize();

         }


        //I click on Careers

      
        [Then(@"I click on Careers")]
        public void ThenIClickOnCareers()
        {
            driver.FindElement(By.XPath("//html/body/div[1]/div/header/div/div/div[2]/div[3]/div[1]/ul/li[3]/a")).Click();
            Thread.Sleep(1000);

            Thread.Sleep(1000);

        }



        [Then(@"I search for a QA Job and Verify the Job details")]
        public void ThenISearchForAQAJobAndVerifyTheJobDetails()
        {
            driver.FindElement(By.XPath("//html/body/div[1]/section[2]/div/div/header/div[1]/div/div[4]/section/div/form/div[2]/div/div/div[1]/input")).SendKeys("QA Automation Engineer");
            Thread.Sleep(1000);
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//html/body/div[1]/section[2]/div/div/header/div[1]/div/div[4]/section/div/form/div[2]/div/div/div[1]/input")).SendKeys(Keys.ArrowDown);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//html/body/div[1]/section[2]/div/div/header/div[1]/div/div[4]/section/div/form/div[2]/div/div/div[1]/input")).SendKeys(Keys.Enter);

            Thread.Sleep(1000);

            Thread.Sleep(1000);


            string actualvalue = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[1]/div[2]/section/div/div/div/div[1]/h1")).Text;
            Assert.IsTrue(actualvalue.Contains("Test Automation Engineer"), actualvalue + "Error");
            Thread.Sleep(1000);



            string actualvalue2 = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[1]/div[2]/section/div/div/div/div[1]/section/div/div[1]/span[3]/span")).Text;
            Assert.IsTrue(actualvalue2.Contains("2322968"), actualvalue2 + "Error");


            string actualvalue3 = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[2]/div/div/div[1]/section[1]/div/div/div[2]/div[2]/ul[1]/li[3]")).Text;
            Assert.IsTrue(actualvalue3.Contains("software"), actualvalue3 + "Error");


            string actualvalue4 = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[2]/div/div/div[1]/section[1]/div/div/div[2]/div[2]/ul[1]/li[2]")).Text;
            Assert.IsTrue(actualvalue4.Contains("5+ years hands-on experience building test automation solutions for UI or service and/or transferrable software development experience"), actualvalue4 + "Error");


            string actualvalue5 = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[2]/div/div/div[1]/section[1]/div/div/div[2]/div[2]/ul[1]/li[5]")).Text;
            Assert.IsTrue(actualvalue5.Contains("Cucumber/BDD"), actualvalue5 + "Error");


            Thread.Sleep(1000);

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[1]/div[2]/section/div/div/div/div[2]/div/a/ppc-content")).Click();

            Thread.Sleep(1000);
            Thread.Sleep(1000);


            var windowHandles = driver.WindowHandles.ToList();

            Console.WriteLine(windowHandles);

            driver.SwitchTo();
            Thread.Sleep(1000);
            Thread.Sleep(1000);

        }


        [Then(@"I switch to the job posting and verify details")]
        public void ThenISwitchToTheJobPostingAndVerifyDetails()
        {
            Thread.Sleep(1000);

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[1]/div[2]/section/div/div/div/div[2]/div/a/ppc-content")).Click();

            Thread.Sleep(1000);
            Thread.Sleep(1000);


            var windowHandles = driver.WindowHandles.ToList();

            Console.WriteLine(windowHandles);

            driver.SwitchTo();
            Thread.Sleep(1000);
            Thread.Sleep(1000);
        }

        [Then(@"I click on Home Page")]
        public void ThenIClickOnHomePage()
        {
            driver.Quit();
        }



    }
}
