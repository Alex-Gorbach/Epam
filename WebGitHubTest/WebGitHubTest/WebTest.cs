using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace WebGitHubTest
{
    [TestFixture]
    public class WebTest
    {
        FirefoxDriver driver;
        [Test]
        public void OneCanLogGitHub()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://github.com/");
            driver.FindElementByXPath(".//a[text() = 'Sign in']").Click();
            driver.FindElementById("login_field").SendKeys("testautomationuser");
            driver.FindElementById("password").SendKeys("Time4Death!");
            driver.FindElementByName("commit").Click();

        }
    }
}
