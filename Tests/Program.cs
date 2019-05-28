using Automation1.Helpers;
using Automation1.Pages;
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
    class Program

    {


        static void Main(string[] args)
        {
            CommonDriver.driver = new ChromeDriver();

            //Step to login
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(CommonDriver.driver);

            //steps to navigate to TM
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(CommonDriver.driver);

            //steps for create new TM
            TMPage tmObj = new TMPage();
            tmObj.addTM(CommonDriver.driver);

            //steps to edit TM
            TMPage editObj = new TMPage();
            editObj.editTM(CommonDriver.driver);

            //steps to delete TM
            TMPage deleteObj = new TMPage();
            deleteObj.deleteTM(CommonDriver.driver);








        }
    }
}
