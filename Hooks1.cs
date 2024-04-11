using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlow_VEN
{
    [Binding]
    public class Hooks1
    {
        IWebDriver driver;


        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            BasicClass.driver = driver;

        }

        [BeforeScenario(Order = 2)]
        public void FirstBeforeScenario1()
        {
            Console.WriteLine("every first scenario run..");
        }

        [AfterScenario("@google")]
        public void AfterScenario()
        {
            driver.Close();
        }

        [AfterScenario(Order = 1)]
        public void AfterScenerio1() => Console.WriteLine("End of the Program");
    }
}