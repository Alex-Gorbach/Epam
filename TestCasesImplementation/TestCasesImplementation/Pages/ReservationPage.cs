using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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


        public ReservationPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }


        
    }
}
