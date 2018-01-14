using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestCasesImplementation.Pages
{
    public class ReservationPage
    {
        private const string BASE_URL = "http://www.letskorail.com/ebizbf/EbizBfTicketSearch.do";
        private IWebDriver _driver;

        [FindsBy(How = How.Name,Using = "txtGoStart")]
        private IWebElement DepartureName;

        [FindsBy(How = How.Name, Using = "txtGoEnd")]
        private IWebElement ArrivalName;

        [FindsBy(How = How.Id, Using = "slt_y01")]
        private IWebElement startYear;

        [FindsBy(How = How.Id, Using = "slt_m01")]
        private IWebElement startMonth;

        [FindsBy(How = How.Id, Using = "slt_d01")]
        private IWebElement startDay;

        [FindsBy(How = How.Id, Using = "slt_h01")]
        private IWebElement startHour;

        [FindsBy(How = How.Name, Using = "txtPsgFlg_1")]
        private IWebElement AdultPassenger;

        [FindsBy(How = How.Name, Using = "txtPsgFlg_1")]
        private IWebElement ChildPassenger;

        [FindsBy(How = How.XPath, Using = "//*[@id='contents']/form/p/a/img")]
        private IWebElement submitElement;

        private IAlert alert;
        public string AlertText { get => alert.Text; }


        public ReservationPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }


        public void SetRoute(string depatrure, string arrival)
        {
            DepartureName.SendKeys(depatrure);
            ArrivalName.SendKeys(arrival);
        }


        public void SetDate(int year,int month,int day)
        {
           var setYear =new SelectElement(startYear);
            setYear.SelectByValue(Convert.ToString(year));
           var setMonth = new SelectElement(startMonth);
            setMonth.SelectByValue(Convert.ToString(month));
           var setDay = new SelectElement(startDay);
            setDay.SelectByValue(Convert.ToString(day));
        }


        public void SetHour(int hour)
        {
            var selectElement = new SelectElement(startHour);
            selectElement.SelectByValue(Convert.ToString(hour));
        }


        public void SelectAdultPassenger(int adultPassenger)
        {
            var selectElement = new SelectElement(AdultPassenger);
            selectElement.SelectByValue(Convert.ToString(adultPassenger));
        }

        public void SelectChildPassenger(int childPassenger)
        {
            var selectElement = new SelectElement(ChildPassenger);
            selectElement.SelectByValue(Convert.ToString(childPassenger));
        }

        public void Submit()
        {
            if (submitElement.Enabled)
            {
                Console.WriteLine("Submit enable");
                submitElement.Click();
            }
            else
            {
                Console.WriteLine("Submit not enable");
            }
        }

        public void SwitchToAlert()
        {
            alert = _driver.SwitchTo().Alert();
        }

        public void AcceptAlert()
        {
            alert.Accept();
            alert = null;
        }

        public string AlertErrorMessage
        {
            get
            {
                var alertErrorBlock = WaitElement(20, By.ClassName("alert-message"));
                if (alertErrorBlock != null) return alertErrorBlock.Text;
                return null;
            }

        }

        public IWebElement WaitElement(int maxWait, By findBy)
        {
            try
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(maxWait));
                var element = wait.Until(drv => _driver.FindElement(findBy));
                return element;
            }
            catch (Exception ex)
            {
                if (ex is NoSuchElementException || ex is WebDriverTimeoutException) return null;
                throw ex;
            }
        }


    }
}
