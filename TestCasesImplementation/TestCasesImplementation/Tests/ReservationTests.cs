using System;
using NUnit.Framework;

namespace TestCasesImplementation.Tests
{
    [TestFixture]
    public class ReservationTests
    {
        Steps.Steps steps = new Steps.Steps();
        string defaultDeparture = "Seoul";
        string defaultArrival = "Busan";
        private int year = DateTime.Now.Year;
        private int month = DateTime.Now.Month;
        private int day = DateTime.Now.Day;
        private int tommorow = DateTime.Now.Day +1;
        private int hour = DateTime.Now.Hour;
        private string alertStation="Please select the departure and arrival stations! ";
        private string alertDate = "You have selected the time which has now passed. Please, check again. ";
        private string alertPassenger = "Please select the number of passengers.";
        private string resultMessage = "non existing station.please input again.";
        private string invalidArrival = "Minsk";

        private int adultPassenger = 0;
        private int childPassenger = 0;


        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void EmptyDestination()
        {
            steps.SearchTicket(defaultDeparture, String.Empty);
            Assert.AreEqual(alertStation, steps.GetAlertText());
        }

        [Test]
        public void InvalidDate()
        {
            steps.SearchTicketWithDate(year, month, day - 1);
            Assert.AreEqual(alertDate, steps.GetAlertText());
        }

        [Test]
        public void InvalidTime()
        {
            steps.SearchTicketWithTime(hour);
            Assert.AreEqual(alertDate, steps.GetAlertText());
        }

        [Test]
        public void InvalidPassengerNumber()
        {
            steps.SearchWithPassangers(adultPassenger, childPassenger);
            Assert.AreEqual(alertPassenger, steps.GetAlertText());
        }

        [Test]
        public void InvalidStation()
        {
            steps.SearchTicket(defaultDeparture, invalidArrival);
            Assert.AreEqual(resultMessage, steps.GetMassegeFromResult());
        }

        [Test]
        public void SearchRoute()
        {
            steps.SearchTicket(defaultDeparture, defaultArrival);
            Assert.IsTrue(steps.GetResultTable());
        }

        [Test]
        public void SearchRouteWithTommorow()
        {
            steps.SearchTicketWithDate(year, month, tommorow);
            Assert.IsTrue(steps.GetResultTable());
        }

        [Test]
        public void SearchRouteWithManyPassengers()
        {
            steps.SearchWithPassangers(9, 9);
            Assert.IsTrue(steps.GetResultTable());
        }

        [Test]
        public void SearchRouteWithFutereHour()
        {
            steps.SearchTicketWithTime(hour + 1);
            Assert.IsTrue(steps.GetResultTable());
        }

        [Test]
        public void SearchRouteWithManyAdultPassangers()
        {
            steps.SearchWithPassangers(9, 0);
            Assert.IsTrue(steps.GetResultTable());
        }



    }
}
