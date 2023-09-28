using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace LumaProj.StepDefinitions
{
    [Binding]
    public class Feature2StepDefinitions
    {
        public static IWebDriver driver;
        public Feature2StepDefinitions()

        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }
        [Given(@"click on the what's new button")]
        public void GivenClickOnTheWhatsNewButton()
        {
            driver.FindElement(By.Id("ui-id-3")).Click();
        }

        [When(@"click on orders and returns")]
        public void WhenClickOnOrdersAndReturns()
        {
            driver.FindElement(By.LinkText("Orders and Returns")).Click();
        }

        [When(@"provide the order id")]
        public void WhenProvideTheOrderId()
        {
            driver.FindElement(By.Id("oar-order-id")).SendKeys("12345");
        }

        [When(@"provide the billing last name")]
        public void WhenProvideTheBillingLastName()
        {
            driver.FindElement(By.Id("oar-billing-lastname")).SendKeys("Samaleti");
        }

        [When(@"click on find order by dropdown")]
        public void WhenClickOnFindOrderByDropdown()
        {
            driver.FindElement(By.Id("quick-search-type-id")).Click();
        }

        [When(@"select the email option")]
        public void WhenSelectTheEmailOption()
        {
            driver.FindElement(By.XPath("//select[@id='quick-search-type-id']/option[@value='email']")).Click();
        }

        [When(@"provide the email on email text box")]
        public void WhenProvideTheEmailOnEmailTextBox()
        {
            driver.FindElement(By.Id("oar_email")).SendKeys("samaleti@gmail.com");
        }

        [Then(@"click on continue button")]
        public void ThenClickOnContinueButton()
        {
            driver.FindElement(By.XPath("//button[@class='action submit primary']")).Click();
        }

        [Given(@"click on the write for us component")]
        public void GivenClickOnTheWriteForUsComponent()
        {
            driver.FindElement(By.LinkText("Write for Us")).Click();
        }
        [When(@"provide the text data on first name text box")]
        public void WhenProvideTheTextDataOnFirstNameTextBox()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.Id("222202263308443")));
            driver.FindElement(By.Id("first_1")).SendKeys("chandu");
        }
        [Given(@"provide the text data on last name text box")]
        public void GivenProvideTheTextDataOnLastNameTextBox()
        {
            driver.FindElement(By.Id("last_1")).SendKeys("samaleti");
            driver.SwitchTo().DefaultContent();
        }

        [Given(@"write the email on email text field")]
        public void GivenWriteTheEmailOnEmailTextField()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.Id("222202263308443")));
            driver.SwitchTo().Frame(driver.FindElement(By.Id("customFieldFrame_22")));
            driver.FindElement(By.Id("mail")).SendKeys("chandu@gmail.com");
        }

        [Given(@"click on verify email button")]
        public void GivenClickOnVerifyEmailButton()
        {
            //driver.FindElement(By.Id("mailSubmit")).Click();
            driver.SwitchTo().DefaultContent();
        }

        [Given(@"provide the link in website text box")]
        public void GivenProvideTheLinkInWebsiteTextBox()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.Id("222202263308443")));
            driver.FindElement(By.Id("input_4")).Clear();
            driver.FindElement(By.Id("input_4")).SendKeys("abcd@1234");
        }

        [Given(@"click on the upload your article choose file button")]
        public void GivenClickOnTheUploadYourArticleChooseFileButton()
        {
            driver.FindElement(By.Id("input_14")).SendKeys(@"C:\Users\SamaletiPurnachander\Documents\Udemy Cource C #.txt");
        }

        [Given(@"select the file path")]
        public void GivenSelectTheFilePath()
        {
            //driver.FindElement(By.Id("input_14")).SendKeys(@"C: \Users\SamaletiPurnachander\Pictures\Screenshots\Screenshot_20221026_112834.png");
        }

        [Given(@"click on the upload featured image choose file button")]
        public void GivenClickOnTheUploadFeaturedImageChooseFileButton()
        {
            driver.FindElement(By.Id("input_16")).SendKeys(@"C:\Users\SamaletiPurnachander\Documents\Udemy Cource C #.txt");
        }

        [Given(@"provide text data on author bio text box")]
        public void GivenProvideTextDataOnAuthorBioTextBox()
        {
            driver.FindElement(By.Id("input_6")).SendKeys("Author Bio");
        }

        [Given(@"click on upload an author bio choose file button")]
        public void GivenClickOnUploadAnAuthorBioChooseFileButton()
        {
            driver.FindElement(By.Id("input_13")).SendKeys(@"C:\Users\SamaletiPurnachander\Documents\Udemy Cource C #.txt");
        }

        [Given(@"provide the text data on tags or labels text field")]
        public void GivenProvideTheTextDataOnTagsOrLabelsTextField()
        {
            driver.FindElement(By.Id("input_11")).SendKeys("Tags or Labels");
        }
        [Then(@"click on submit button")]
        public void ThenClickOnSubmitButton()
        {
            driver.FindElement(By.Id("input_2")).Click();
        }

    }
}
