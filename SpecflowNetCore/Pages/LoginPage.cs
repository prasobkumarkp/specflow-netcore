using System;
using OpenQA.Selenium;

namespace SpecflowNetCore.Pages
{
    public class LoginPage
    {

        public IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        // UI Elements
        public IWebElement LnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement TxtUserName => WebDriver.FindElement(By.Name("UserName"));
        public IWebElement TxtPassword => WebDriver.FindElement(By.Name("Password"));
        public IWebElement BtnLogin => WebDriver.FindElement(By.CssSelector("Login"));
        public IWebElement LnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => LnkLogin.Click();

        public void Login(string userName, string password)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => BtnLogin.Submit();

        public bool IsEmployeeDetailsExist() => LnkEmployeeDetails.Displayed;
    }
}
