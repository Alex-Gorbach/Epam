using System;
using OpenQA.Selenium;
using TestCasesImplementation.Pages;

namespace TestCasesImplementation.Steps
{
    public class Steps
    {
        private IWebDriver _driver;

        private Pages.ReservationPage reservationPage;


        string defaultDeparture = "Seoul";
        string defaultArrival = "Busan";

        public void InitBrowser()
        {
            _driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void SearchTicket(string departure, string arrival)
        {
            reservationPage = new ReservationPage(_driver);
            reservationPage.OpenPage();
            reservationPage.SetRoute(departure,arrival);
            reservationPage.Submit();
           
            
        }

        public string GetAlertText()
        {
            reservationPage.SwitchToAlert();
            var text = reservationPage.AlertText;
            return text;
        }
        internal double IsSubmit()
        {
            throw new NotImplementedException();
        }


        public void SearchTicketWithDate(int year,int month,int day)
        {
            var reservationPage = new ReservationPage(_driver);
            reservationPage.OpenPage();
            reservationPage.SetDate(year,month,day);
            reservationPage.Submit();
        }

        public void SearchTicketWithTime( int hour)
        {
            var reservationPage = new ReservationPage(_driver);
            reservationPage.OpenPage();
            reservationPage.SetHour(hour);
            reservationPage.Submit();
        }

        public void SearchWithPassangers(int adultCount, int childrenCount)
        {
            var reservationPage = new ReservationPage(_driver);
            reservationPage.OpenPage();
            reservationPage.SelectAdultPassenger(adultCount);
            reservationPage.SelectChildPassenger(childrenCount);
            reservationPage.Submit();
        }

        public string GetMassegeFromResult()
        {
            var searchResultPage=new SearchResultPage(_driver);
            return searchResultPage.GetMessageFromPage();
        }

        public bool GetResultTable()
        {
           var result= reservationPage.CheckResultTable();
            return result;
        }

    }
}
