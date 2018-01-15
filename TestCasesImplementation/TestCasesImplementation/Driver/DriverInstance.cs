using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Diagnostics;

namespace TestCasesImplementation.Driver
{
    public class DriverInstance
    {
        private static IWebDriver _driver;

        private DriverInstance() { }

        public static IWebDriver GetInstance()
        {
            if (_driver == null)
            {
                _driver = new FirefoxDriver();
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                _driver.Manage().Window.Maximize();
            }
            return _driver;
        }

        public static void CloseBrowser()
        {
            _driver.Quit();
            _driver = null;

            foreach (var process in Process.GetProcessesByName("geckodriver"))
            {
                process.Kill();
            }
        }
    }
}
