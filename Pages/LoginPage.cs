using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.Pages
{
    class LoginPage
    {

        //Steps to login to TurnUp portal
        public void loginSteps(IWebDriver driver)
        {


            //Enter the URL
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");

            //Maximise the window
            driver.Manage().Window.Maximize();

            //Enter the Username
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Enter the Password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //Click on login button
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginButton.Click();

            //Verify if the user is logged in successfully
            IWebElement helloHariHome = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHariHome.Text == "Hello hari!")
            {
                System.Console.WriteLine("Test Passed, logged in successfully");
            }
            else
            {
                System.Console.WriteLine("Test Failed, login unsuccessful");
            }


        }
    }
}
