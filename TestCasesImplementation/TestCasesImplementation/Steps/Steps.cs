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
            var reservationPage = new ReservationPage(_driver);
            reservationPage.OpenPage();
            reservationPage.SetRoute(departure,arrival);
            reservationPage.Submit();
        }

        public void SearchTicketWithDate(int year,int month,int day)
        {
            var reservationPage = new ReservationPage(_driver);
            reservationPage.OpenPage();
            reservationPage.SetRoute(defaultDeparture, defaultArrival);
            reservationPage.SetDate(year,month,day);
            reservationPage.Submit();
        }

        public void SearchTicketWithTime(int year, int month, int day, int hour)
        {
            var reservationPage = new ReservationPage(_driver);
            reservationPage.OpenPage();
            reservationPage.SetRoute(defaultDeparture, defaultArrival);
            reservationPage.SetDate(year, month, day);
            reservationPage.SetHour(hour);
            reservationPage.Submit();
        }

        public void SearchWithPassangers(int adultCount, int childrenCount)
        {
            var reservationPage = new ReservationPage(_driver);
            reservationPage.OpenPage();
            reservationPage.SelectAdultPassenger(adultCount);
            reservationPage.SelectChildPassenger(childrenCount);
            reservationPage.SetRoute(defaultDeparture, defaultArrival);
            reservationPage.Submit();
        }

    }
}
