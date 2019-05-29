using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation1.Pages
{
    class TMPage
    {

        //Function to create TM
        public void AddTM(IWebDriver driver)
        {

            //Create a new material

            //Click on Create New button
            OpenQA.Selenium.IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewButton.Click();

            //Click on TypeCode
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label")).Click();

            //Select Material from drop-down

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();


            //Enter the Code
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("Automation");


            //Enter the Description
            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("Coding");

            //Enter the Price per unit
            IWebElement Price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Price.SendKeys("17");


            //Click on Save button
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SaveButton.Click();

            Thread.Sleep(1000);

            ////Verify the creation of time and material record

            ////Navigate to the last page
            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            //IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[6]/a[4]"));

            //if (actualCode.Text == "Automation")
            //{
            //    Console.WriteLine("Test Passed, material created successully");
            //}
            //else
            //{
            //    Console.WriteLine("Test Failed!");
            //}

            //select the record to be deleted
        }



        public void EditTM(IWebDriver driver)
        {

            //go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            //click edit button
            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[5]/a[1]"));
            EditButton.Click();

            //Click on TypeCode
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label")).Click();

            //Select Time from drop-down
            driver.FindElement(By.XPath("///*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();

        }




        public void DeleteTM(IWebDriver driver)
        { 

            //Enter the Code


            //click Delete
            driver.FindElement(By.XPath("//*//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[5]/a[2]")).Click();


            //click ok button
            driver.SwitchTo().Alert().Accept();

        }
    }
}


