using System;
using TechTalk.SpecFlow;

namespace SpecFlow_VEN.StepDefinitions
{
    [Binding]
    public class AutomationStepDefinitions
    {
        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            Console.WriteLine("All before line");
        }

        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            Console.WriteLine("No:1");
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            Console.WriteLine("No:2");
        }

        [When(@"Enter the Username")]
        public void WhenEnterTheUsername()
        {
            Console.WriteLine("No:3");
        }

        [When(@"Enter the Password")]
        public void WhenEnterThePassword()
        {
            Console.WriteLine("No:4");
        }

        [When(@"Click the Submit button")]
        public void WhenClickTheSubmitButton()
        {
            Console.WriteLine("No:5");
        }

        [Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            Console.WriteLine("No:6");
        }

        [When(@"Enter the invalidUsername")]
        public void WhenEnterTheInvalidUsername()
        {
            Console.WriteLine("No:7");
        }

        [When(@"Enter the invalidcPassword")]
        public void WhenEnterTheInvalidcPassword()
        {
            Console.WriteLine("No:8");
        }
    }
}
