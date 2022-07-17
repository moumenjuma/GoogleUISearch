using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace GoogleUITest

{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void TestSearch()
        {
            string search="Black Ops cold war";//input what you want to search up 
            int waitingTime = 200;
            int waitingTimeRead = 2000;

            By googleSearchBar = By.Name("q");//Identifies Googles Searchbar
            By googleSearchButton = By.Name("btnK");//Identifies Googles Search button

            IWebDriver webDriver = new ChromeDriver();//opens ChromeDriver

            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://www.google.com");//Navigates to Google

            Thread.Sleep(waitingTime);

            webDriver.Manage().Window.Maximize();//Maximizes Window

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchBar).SendKeys(search);//enters what is in the string->search 

            Thread.Sleep(waitingTime);

            webDriver.FindElement(googleSearchButton).Click();//clicks on the Search button in google

            Thread.Sleep(waitingTime);

            Thread.Sleep(waitingTimeRead);

            webDriver.Quit();//closes Chrome
        }
    }
}
