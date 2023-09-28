using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace LumaProj.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        public IWebDriver driver;
       
        Actions act;
        [Obsolete]

        public Feature1StepDefinitions()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }
        [Given(@"click on men dropdown")]
        public void GivenClickOnMenDropdown()
        {
            act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.XPath("(//span[@class='ui-menu-icon ui-icon ui-icon-carat-1-e'])[4]"))).Click();
            driver.FindElement(By.XPath("(//span[@class='ui-menu-icon ui-icon ui-icon-carat-1-e'])[4]")).Click();
        }

        [When(@"click on jackets")]
        public void WhenClickOnJackets()
        {
            driver.FindElement(By.LinkText("Jackets")).Click();
        }

        [When(@"click on style dropdown")]
        public void WhenClickOnStyleDropdown()
        {
            driver.FindElement(By.ClassName("filter-options-title")).Click();
        }

        [When(@"click on soft shell")]
        public void WhenClickOnSoftShell()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Soft Shell')]")).Click();
        }

        [When(@"click on size dropdown")]
        public void WhenClickOnSizeDropdown()
        {
            driver.FindElement(By.XPath("//div[starts-with(text(),'Si')]")).Click();
        }

        [When(@"select M size")]
        public void WhenSelectMSize()
        {
            driver.FindElement(By.XPath("(//div[@class='swatch-option text '])[3]")).Click();
            //driver.FindElement(By.XPath("//a[@class='swatch-option-link-layered']/child::div[starts-with(text(),'M')]")).Click();
        }

        [When(@"click on colors dropdown")]
        public void WhenClickOnColorsDropdown()
        {
            driver.FindElement(By.XPath("//div[starts-with(text(),'Color')]")).Click();
            // driver.FindElement(By.XPath("//div[@class='filter-options-item allow active']")).Click();
        }

        [When(@"select blue color")]
        public void WhenSelectBlueColor()
        {
            driver.FindElement(By.XPath("(//div[@class='swatch-option color'])[2]")).Click();
        }

        [When(@"click on add to cart in third column that is lando gym jacket")]
        public void WhenClickOnAddToCartInThirdColumnThatIsLandoGymJacket()
        {
            driver.FindElement(By.ClassName("product-item-details")).Click();
        }

        [When(@"provide the mail address in email text box")]
        public void WhenProvideTheMailAddressInEmailTextBox()
        {
            driver.FindElement(By.Id("newsletter")).SendKeys("Chandu@123");
        }

        [Then(@"click on subscribe button")]
        public void ThenClickOnSubscribeButton()
        {
            driver.FindElement(By.XPath("//span[text()='Subscribe']")).Click();
        }

        [Given(@"click on women dropdown module")]
        public void GivenClickOnWomenDropdownModule()
        {
            driver.FindElement(By.Id("ui-id-4")).Click();
        }

        [When(@"click on hoodies and sweatshirts")]
        public void WhenClickOnHoodiesAndSweatshirts()
        {
            driver.FindElement(By.LinkText("Hoodies & Sweatshirts")).Click();
        }

        [When(@"clcik on style dropdown")]
        public void WhenClcikOnStyleDropdown()
        {
            driver.FindElement(By.XPath("//div[@class='filter-options-item'][1]")).Click();
        }

        [When(@"select the full zip option")]
        public void WhenSelectTheFullZipOption()
        {
            driver.FindElement(By.XPath("(//ol[@class='items'])[1]//li[@class='item'][1]")).Click();
        }

        [When(@"click on material dropdown")]
        public void WhenClickOnMaterialDropdown()
        {
            driver.FindElement(By.XPath("(//div[@class='filter-options-title'])[5]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"select the cotton option")]
        public void WhenSelectTheCottonOption()
        {
            driver.FindElement(By.XPath("(//div[@class='filter-options-content'])[5]//li[@class='item'][1]")).Click();
        }

        [When(@"click on position dropdown")]
        public void WhenClickOnPositionDropdown()
        {
            driver.FindElement(By.XPath("(//select[@id='sorter'])[1]")).Click();
        }

        [When(@"select the product name")]
        public void WhenSelectTheProductName()
        {
            driver.FindElement(By.XPath("(//select[@id='sorter'])[1]//option[@value='name']")).Click();
        }

        [When(@"click on email text box")]
        public void WhenClickOnEmailTextBox()
        {
            driver.FindElement(By.Id("newsletter")).Click();
        }

        [Then(@"provide the username on text email box")]
        public void ThenProvideTheUsernameOnTextEmailBox()
        {
            driver.FindElement(By.Id("newsletter")).SendKeys("Chandu@Ariqt");
        }


        [Given(@"click on gear module")]
        public void GivenClickOnGearModule()
        {
            driver.FindElement(By.XPath("//li[@class='level0 nav-4 category-item level-top parent ui-menu-item']")).Click();
        }

        [When(@"click on bags component")]
        public void WhenClickOnBagsComponent()
        {
            driver.FindElement(By.LinkText("Bags")).Click();
        }

        [When(@"click on acticity dropdown")]
        public void WhenClickOnActicityDropdown()
        {
            driver.FindElement(By.XPath("(//div[@class='filter-options-title'])[4]")).Click();
        }

        [When(@"click on gyp component")]
        public void WhenClickOnGypComponent()
        {
            //driver.FindElement(By.XPath("(//li[@class='item'])[16]")).Click();
            driver.FindElement(By.PartialLinkText("Gym")).Click();
        }

        [When(@"click on driven backpack")]
        public void WhenClickOnDrivenBackpack()
        {
            driver.FindElement(By.XPath("(//img[@class='product-image-photo'])[1]")).Click();
        }

        [When(@"click on quantity")]
        public void WhenClickOnQuantity()
        {
            driver.FindElement(By.Id("qty")).Click();
        }

        [When(@"enter the data as (.*) number")]
        public void WhenEnterTheDataAsNumber(int p0)
        {
            driver.FindElement(By.Id("qty")).Clear();
            driver.FindElement(By.Id("qty")).SendKeys("2");
        }

        [Then(@"click on add to cart")]
        public void ThenClickOnAddToCart()
        {
            driver.FindElement(By.Id("product-addtocart-button")).Click();
        }
        [Given(@";huiu")]
        public void GivenHuiu()
        {
            throw new PendingStepException();
        }

        [When(@"nk;v")]
        public void WhenNkV()
        {
            throw new PendingStepException();
        }

        [When(@"buyc")]
        public void WhenBuyc()
        {
            throw new PendingStepException();
        }

        [When(@"bgcvhk")]
        public void WhenBgcvhk()
        {
            throw new PendingStepException();
        }

        [Then(@"bvchkjl")]
        public void ThenBvchkjl()
        {
            throw new PendingStepException();
        }

    }
}
