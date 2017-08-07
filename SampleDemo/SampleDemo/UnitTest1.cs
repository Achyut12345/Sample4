using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace SampleDemo
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Login test
        /// </summary>
        [TestMethod]
        public void TestLogin()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://darent82.crm.dynamics.com/main.aspx");

            driver.FindElement(By.Id("cred_userid_inputtext")).Click();
            driver.FindElement(By.Id("cred_userid_inputtext")).SendKeys("easyrepro@pfecrmonline.onmicrosoft.com");
            driver.FindElement(By.Id("cred_userid_inputtext")).SendKeys(Keys.Tab);

            driver.FindElement(By.Id("cred_password_inputtext")).SendKeys("R@ngers2017");
            driver.FindElement(By.Id("cred_password_inputtext")).SendKeys(Keys.Tab);
            driver.FindElement(By.Id("cred_password_inputtext")).Submit();
            Thread.Sleep(3000);
        }
    }
}
