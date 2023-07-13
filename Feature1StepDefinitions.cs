using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V112.Security;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Policy;
using TechTalk.SpecFlow;
using System.Collections.Generic;

namespace TestProjectUI
{
    [Binding]
    public class Feature1StepDefinitions
    {

        IWebDriver driver;

        [Given(@"I go to LabCorp.com")]
        public void GivenIGoToGoogle()
        {

            ChromeOptions options = new ChromeOptions()
            {
                BinaryLocation = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"
            };

            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.labcorp.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        //I click on Careers

      
        [Then(@"I click on Careers")]
        public void ThenIClickOnCareers()
        {
            driver.FindElement(By.XPath("//div[@class='grid-container extrawide-grid logo-utility-container']//a[.='Careers']")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"I search for a QA Job and Verify the Job details ""([^""]*)""")]
        public void ThenISearchForAQAJobAndVerifyTheJobDetails(string jobTitle)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Search job title or location']")).SendKeys("QA Automation Engineer");
           

            IList<IWebElement> listOfJobs = driver.FindElements(By.XPath("//div[@data-ph-at-id='suggested-jobs']//ul//li"));
            foreach (IWebElement each in listOfJobs)
            {
                each.Click();
                break;
            }

            IWebElement jobTitletToVerify = driver.FindElement(By.XPath("//h1[contains(text(),'"+jobTitle+"')]"));
            Assert.IsTrue(jobTitletToVerify.Displayed,"The job title is not displayed");


            IWebElement jobID = driver.FindElement(By.XPath("//span[@class='au-target jobId']"));
            Assert.IsTrue(jobID.Displayed, "The job ID is not displayed");
            Assert.IsTrue(jobID.Text.Contains("2322968"));



            driver.FindElement(By.XPath("//button[@click.delegate='openMultiLocationModal()']")).Click();
            Assert.IsTrue(jobTitletToVerify.Displayed, "The job title is not displayed");

            IList<IWebElement> jobInformationDetails = driver.FindElements(By.XPath("//div[@class='popup-content-block']//div"));
            foreach (IWebElement each in jobInformationDetails) { Assert.IsNotNull(each);  }

            driver.FindElement(By.XPath("//div[@class='popup-content-block']//i[@class='icon icon-cancel']")).Click();

    


            string actualvalue = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[1]/div[2]/section/div/div/div/div[1]/h1")).Text;
            Assert.IsTrue(actualvalue.Contains("Test Automation Engineer"), actualvalue + "Error");
      



            string actualvalue2 = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[1]/div[2]/section/div/div/div/div[1]/section/div/div[1]/span[3]/span")).Text;
            Assert.IsTrue(actualvalue2.Contains("2322968"), actualvalue2 + "Error");


            string actualvalue3 = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[2]/div/div/div[1]/section[1]/div/div/div[2]/div[2]/ul[1]/li[3]")).Text;
            Assert.IsTrue(actualvalue3.Contains("software"), actualvalue3 + "Error");


            string actualvalue4 = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[2]/div/div/div[1]/section[1]/div/div/div[2]/div[2]/ul[1]/li[2]")).Text;
            Assert.IsTrue(actualvalue4.Contains("5+ years hands-on experience building test automation solutions for UI or service and/or transferrable software development experience"), actualvalue4 + "Error");


            string actualvalue5 = driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[2]/div/div/div[1]/section[1]/div/div/div[2]/div[2]/ul[1]/li[5]")).Text;
            Assert.IsTrue(actualvalue5.Contains("Cucumber/BDD"), actualvalue5 + "Error");


          

        }



        [Then(@"I switch to the job posting and verify details")]
        public void ThenISwitchToTheJobPostingAndVerifyDetails()
        {
            Thread.Sleep(1000);

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//html/body/div[2]/div[2]/div/div[1]/div[2]/section/div/div/div/div[2]/div/a/ppc-content")).Click();

            Thread.Sleep(1000);
          
            
        }

        [Then(@"I click on Home Page")]
        public void ThenIClickOnHomePage()
        {

            Thread.Sleep(1000);
            IList<String> windowHandles = driver.WindowHandles.ToList();
            Console.WriteLine(windowHandles);
            driver.SwitchTo().Window(windowHandles[1]);


            driver.FindElement(By.XPath("//button[@data-automation-id='navigationItem-Careers Home']")).Click();



            ////button[@data-automation-id='navigationItem-Careers Home']


            //driver.SwitchTo().Window(driver.WindowHandles.Last());

            //handles = driver.window_handles
            //driver.switch_to.window(handles[1])


            Thread.Sleep(1000);
            driver.Quit();
        }



    }
}
