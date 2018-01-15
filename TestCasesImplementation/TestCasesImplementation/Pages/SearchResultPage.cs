using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestCasesImplementation.Pages
{
    public class SearchResultPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath,Using = "//*[@id'contents']/div/p[3]")]
        private IWebElement messageText;

        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public string GetMessageFromPage()
        {
            return messageText.Text;
        }
    }
}
