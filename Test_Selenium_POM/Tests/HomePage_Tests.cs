using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test_Selenium_POM.Pages;

namespace Test_Selenium_POM.Tests
{
    public class HomePage_Tests
    {

        private IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

        [Test]
        public void TestHomePageLinks()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            Assert.That(driver.Url, Is.EqualTo(homePage.GetPageUrl()));

        }

        [Test]
        public void TestHomeHeading()
        {
            var homePage = new HomePage(driver);
            homePage.Open();            
            Assert.That(homePage.GetPageHeading(), Is.EqualTo("Students Registry"));

        }

        [Test]
        public void TestStudentsCount()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            Assert.True(homePage.StudentCount() >= 0);
        }

        [Test]
        public void TestHomeTitle()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            Assert.That(homePage.GetPageTitle(), Is.EqualTo("MVC Example"));
        }

        [Test]
        public void TestHomeClick()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.HomeLink.Click();
            Assert.That(homePage.GetPageTitle(), Is.EqualTo("MVC Example"));
        }
    }
}
