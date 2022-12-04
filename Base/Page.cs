using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePage
{
    public class Page : Base
    {
        private static WebDriverWait wait;

        public Page(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
        }
        public IWebElement BtnBankManagerLogin => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[1]/div[2]/button")));
        public IWebElement BtnCustomers => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[1]/button[3]")));
        public IWebElement InputSearchCustomer => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/form/div/div/input")));
        private IWebElement FoundElement => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div/table/tbody/tr/td[1]")));

        public void CheckThatAlertMessageContainsText(string message) => Assert.That(FoundElement.Text.ToLower().Contains(message));
        public void ClickBtn(string Button) => driver.FindElement(By.Name(Button)).Click();
        public void ClickBtnBankManagerLogin() => BtnBankManagerLogin.Click();
        public void ClickBtnCustomers() => BtnCustomers.Click();
        public void InputText(string text)
        {
            InputSearchCustomer.Click();
            InputSearchCustomer.SendKeys(text);
        }

    }
}
