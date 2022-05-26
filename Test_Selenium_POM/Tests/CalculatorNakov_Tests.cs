using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test_Selenium_POM.Pages;

namespace Test_Selenium_POM.Tests
{
    public class CalculatorNakov_Tests
    {
        private IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

        [Test]
        public void TestHomePageCalc()
        {
            var calcPage = new CalculatorNakov(driver);
            calcPage.Open();
            Assert.That(driver.Url, Is.EqualTo(calcPage.GetPageUrl()));
        }

        [Test]
        public void TestHomeCalculatorHeading()
        {
            var calcPage = new CalculatorNakov(driver);
            calcPage.Open();
            Assert.That(calcPage.GetPageHeading(), Is.EqualTo("Number Calculator"));
        }

        [TestCase("5", "+", "15", "Result: 20")]
        [TestCase("1", "*", "2", "Result: 2")]
        [TestCase("1.5", "-", "1.5", "Result: 0")]
        [TestCase("@", "+", "/", "Result: invalid input")]
        [TestCase("5", "&", "5", "Result: invalid operation")]
        public void TestCalulateNumbers(string num1, string oper, string num2, string res)
        {
            var calcPage = new CalculatorNakov(driver);
            calcPage.Open();
            calcPage.Calulate(num1, num2, oper);
            Assert.That(calcPage.ResultCalc(), Is.EqualTo(res));
        }
        [Test]
        public void TestClearFiled()
        {
            var calcPage = new CalculatorNakov(driver);
            calcPage.Open();
            string expectedVal = "";
            Assert.That(expectedVal, Is.EqualTo(calcPage.ResultCalc()));
            calcPage.Calulate("5", "6", "+");
            Assert.That(expectedVal, Is.Not.EqualTo(calcPage.ResultCalc()));
            calcPage.ResetCalc();
            Assert.That(expectedVal, Is.EqualTo(calcPage.ResultCalc()));

        }
    }
}
