using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace Calculadora
{
    public class Tests
    {
        public RemoteWebDriver Driver { get; set;}

        [SetUp]
        [Obsolete]
        public void Setup()
        {
            var dc = new DesiredCapabilities();    
            dc.SetCapability("app", @"C:\Windows\System32\calc.exe");
            this.Driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc);
        }

        [Test]
        public void Calcular()
        {
            Driver.FindElement(By.Name("Um")).Click();
            Driver.FindElement(By.Name("Mais")).Click();
            Driver.FindElement(By.Name("Um")).Click();
            Driver.FindElement(By.Name("Igual a")).Click();
            Assert.AreEqual(true, Driver.FindElement(By.Id("4")).Displayed);
            Thread.Sleep(2000);
        }

        //[TearDown]
        //public void After()
        //{
         //   Driver.Close();
        //}
    }
}