using BasePage;
using System;
using TechTalk.SpecFlow;

namespace Lab_2.StepDefinitions
{
    [Binding]
    public class SearchCustomerStepDefinitions : BaseSteps
    {
        private Page page;

        [Given(@"the user is on the homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login";
            page = new Page(driver);
        }

        [When(@"the user clicks on the Bank Manager Login")]
        public void WhenTheUserClicksOnTheBankManagerLogin()
        {
            page.ClickBtnBankManagerLogin();
        }

        [When(@"the user clicks on Customers")]
        public void WhenTheUserClicksOn()
        {
            page.ClickBtnCustomers();
        }


        [When(@"the user enters the customer")]
        public void WhenTheUserEntersTheCustomer()
        {
            page.InputText("Harry");
        }

        [Then(@"the result Customer should display")]
        public void ThenTheResultCustomerShouldDisplay()
        {
            page.CheckThatAlertMessageContainsText("harry");
        }
    }
}
