using Automation1.Helpers;
using Automation1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation1
{
    [TestFixture]
    class Program

    {

        [SetUp]
        static void Login()
        {
            CommonDriver.Driver = new ChromeDriver();

            //Step to login
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(CommonDriver.Driver);

            //steps to navigate to TM
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(CommonDriver.Driver);

        }

        [Test]
        static void AddTMTest()
        {
            //steps for create new TM
            TMPage tmObj = new TMPage();
            tmObj.AddTM(CommonDriver.Driver);

        }


        [Test]
        static void EditTMTest()
        {

            //steps to edit TM
            TMPage editObj = new TMPage();
            editObj.EditTM(CommonDriver.Driver);

        }


        [Test]
        static void DeleteTMTest()
        {
          //steps to delete TM
         TMPage deleteObj = new TMPage();
         deleteObj.DeleteTM(CommonDriver.Driver);

        }

        [TearDown]
        public void FlushTest()
        {
            //Close driver
            CommonDriver.Driver.Close();
        }

        static void Main(string[] args)
        {


        }

    }
}


