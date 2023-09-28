using Gherkin.Ast;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LumaProj.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
       public static IWebDriver driver;

        [BeforeTestRun]
        public static void Beforetest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(50));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
        [BeforeFeature]
        public static void Beforefeaure()
        {
            Console.WriteLine("Luma Application");
        }
        [BeforeScenario("@mytag1")]

        public void Beforescenario1()
        {
            ScenarioContext.Current.Add("currentDriver", driver);
            Console.WriteLine("Test the Men Module");
        }
        [BeforeScenario("@mytag2")]
        public void Beforescenario2()
        {
            ScenarioContext.Current.Add("currentDriver", driver);
            Console.WriteLine("Test the Women module");
        }
        [BeforeScenario("@mytag3")]
        public void Beforescenario3()
        {
            ScenarioContext.Current.Add("currentDriver", driver);
            Console.WriteLine("Test the Gear module");
        }
        [BeforeScenario("@What'snew")]
        public void Whatsnew()
        {
            ScenarioContext.Current.Add("currentDriver", driver);
            Console.WriteLine("Test the whats new module");
        }
        [BeforeScenario("@Writeforus")]
        public void Writeforus()
        {
            ScenarioContext.Current.Add("currentDriver", driver);
            Console.WriteLine("Test the write for us module");
        }
        [AfterScenario("@mytag1")]
        public void AfterScenario1()
        {
            Console.WriteLine("Close the Men module");
        }
        [AfterScenario("@mytag2")]
        public void AfterScenario2()
        {
            Console.WriteLine("Close the Women module");
        }
        [AfterScenario("@mytag3")]
        public void AfterScenario3()
        {
            Console.WriteLine("Close the Gear module");
        }
        [AfterScenario("@Whatsnew")]
        public void whatsnew()
        {
            Console.WriteLine("Close the whats new module");
        }
        [AfterScenario("@Writeforus")]
        public void writeforus()
        {
            Console.WriteLine("Close the write for us module");
        }
        [AfterFeature]
        public static void Afterfuture()
        {
            Console.WriteLine("Completed the future");
        }
        [AfterTestRun]
        public static void Aftertestrun()
        {
            Console.WriteLine("Open the next scenario");
            driver.Quit();
        }
    }
}