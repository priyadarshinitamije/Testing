using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace Automation1.Pages
{
    class HomePage
    {
        //Function to navigate to TM page
        public void NavigateToTM(IWebDriver driver)
        {



            //Click on Administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //Select Time & Materials from drop-down

            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }
    }
}
