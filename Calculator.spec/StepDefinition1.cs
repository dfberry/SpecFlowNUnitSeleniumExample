using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace Calculator.spec
{
    
    [Binding]
    public class StepDefinition1
    {
        private IWebDriver driver= new FirefoxDriver();
        private StringBuilder verificationErrors= new StringBuilder();
        private string baseURL = "http://localhost:53113/Calculator";

        Calculator calc = new Calculator();

        [BeforeScenario]
        public void InitBrowser()
        {
            Trace.TraceInformation("InitBrowser was called");
            driver.Navigate().GoToUrl(baseURL + "/");
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Given(@"I am on (.*) page")]
        public void GivenIAmOnCalculatorPage(string pagename)
        {
            Assert.AreEqual(pagename.ToLower(), driver.Title.ToLower());
        }

        [Given(@"I have entered (.*) into '(.*)' of the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int result, string guiId)
        {
            driver.FindElement(By.Id(guiId)).SendKeys(result.ToString());
        }



        [When("I press '(.*)'")]
        public void WhenIPressAdd(string buttonName)
        {
            driver.FindElement(By.Id(buttonName)).Click();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.IsTrue(driver.FindElement(By.Id("calc-result-label")).Text.Contains("120"));
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
    }
}
