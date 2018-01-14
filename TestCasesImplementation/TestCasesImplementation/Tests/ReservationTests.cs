using NUnit.Framework;

namespace TestCasesImplementation.Tests
{
    [TestFixture]
    public class ReservationTests
    {
        Steps.Steps steps = new Steps.Steps();


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
    }
}
