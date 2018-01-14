using OpenQA.Selenium;

namespace TestCasesImplementation.Steps
{
    public class Steps
    {
        private IWebDriver _driver;

        public void InitBrowser()
        {
            _driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }
        
       

    }
}
