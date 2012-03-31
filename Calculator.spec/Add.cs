using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Calculator.spec
{
    [Binding]
    public class Add
    {
        Calculator calculator = new Calculator();

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            //TODO: implement arrange (recondition) logic
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the
            //     ScenarioContext.Current
            // collection can be used.
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            //ScenarioContext.Current.Pending();

            //DFB:Commented out above ScenarioContext and added number
            calculator.Add(number);

            int i=0;
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic

            //ScenarioContext.Current.Pending();
            calculator.Sum();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            //ScenarioContext.Current.Pending();
            Assert.AreEqual(calculator.sum, calculator.Total());
        }
    }
}
