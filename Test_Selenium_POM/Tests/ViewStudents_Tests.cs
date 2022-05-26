using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test_Selenium_POM.Pages;

namespace Test_Selenium_POM.Tests
{
    public class ViewStudents_Test
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
        public void TestVewStudentsLink()
        {
            var viewStudentsPage = new ViewStudentPage(driver);
            viewStudentsPage.Open();
            Assert.That(driver.Url, Is.EqualTo(viewStudentsPage.GetPageUrl()));

        }

        [Test]
        public void TestViewStudentHeading()
        {
            var viewStudentsPage = new ViewStudentPage(driver);
            viewStudentsPage.Open();
            Assert.That(viewStudentsPage.GetPageHeading(), Is.EqualTo("Registered Students"));
        }

        [Test]
        public void TestViewStudentsTitle()
        {
            var viewStudentsPage = new ViewStudentPage(driver);
            viewStudentsPage.Open();
            Assert.That(viewStudentsPage.GetPageTitle(), Is.EqualTo("Students"));
        }

        [Test]
        public void TestViewStudentsClick()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.ViewStudents.Click();
            Assert.That(homePage.GetPageTitle(), Is.EqualTo("Students"));
        }
        [Test]
        public void TestViewStudentsToHomeClick()
        {
            var viewStudentsPage = new ViewStudentPage(driver);
            viewStudentsPage.Open();
            viewStudentsPage.HomeLink.Click();
            Assert.That(viewStudentsPage.GetPageTitle(), Is.EqualTo("MVC Example"));
        }
    }
}