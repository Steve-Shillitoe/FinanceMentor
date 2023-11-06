using OpenQA.Selenium.Chrome;

namespace FinanceMentor.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var url = "https://www.google.com";
            var driver = new ChromeDriver(Environment.CurrentDirectory);
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
    }
}