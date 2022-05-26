using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test_Selenium_POM.Pages;

namespace Test_Selenium_POM.Tests
{
    public class AddStudentsTests
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
        public void TestAddStudentsLink()
        {
            var addStudentsPage = new AddStudentPage(driver);
            addStudentsPage.Open();
            Assert.That(driver.Url, Is.EqualTo(addStudentsPage.GetPageUrl()));

        }
        public void TestAddStudentHeading()
        {
            var addStudentsPage = new AddStudentPage(driver);
            addStudentsPage.Open();
            Assert.That(addStudentsPage.GetPageHeading(), Is.EqualTo("Register New Student"));
        }

        public void TestAddStudentsClick()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            homePage.ViewStudents.Click();
            Assert.That(homePage.GetPageTitle(), Is.EqualTo("Add student"));
        }
        [Test]
        public void TestAddStudentsToHomeClick()
        {
            var addStudentsPage = new ViewStudentPage(driver);
            addStudentsPage.Open();
            addStudentsPage.HomeLink.Click();
            Assert.That(addStudentsPage.GetPageTitle(), Is.EqualTo("MVC Example"));
        }

        [Test]
        public void TestAddNewStudent()
        {
            var homePage = new HomePage(driver);
            homePage.Open();
            int count = homePage.StudentCount();                   
            var addStudentsPage = new AddStudentPage(driver);
            addStudentsPage.Open();
            addStudentsPage.RegStudent("Ivan" , "ivan@abv.bg");
            Assert.That(addStudentsPage.GetPageTitle(), Is.EqualTo("Students"));
            homePage.Open();
            Assert.That(homePage.StudentCount(), Is.EqualTo(count + 1));

        }

        [Test]
        public void TestCheckAddedtudent()
        {
            
            var homePage = new HomePage(driver);
            homePage.Open();
            var num = homePage.StudentCount();
            var newel = "body > ul > li:nth-child(" +num +")";
            var viewStudentsPage = new ViewStudentPage(driver);
            viewStudentsPage.Open();                      
            Assert.That(driver.FindElement(By.CssSelector(newel)).Text, Is.EqualTo("Ivan (ivan@abv.bg)"));

        }
    }
}
