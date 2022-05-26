using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Selenium_POM.Pages
{
    public class Base_Pages
    {
        protected readonly IWebDriver driver;

        public virtual string PageUrl { get; }

        //Constructor
        public Base_Pages(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public IWebElement HomeLink => driver.FindElement(By.LinkText("Home"));
        public IWebElement ViewStudents => driver.FindElement(By.LinkText("View Students"));
        public IWebElement AddStudents => driver.FindElement(By.LinkText("Add Student"));
        public IWebElement PageHeading => driver.FindElement(By.CssSelector("body > h1"));
        public IWebElement AddName => driver.FindElement(By.Id("name"));
        public IWebElement AddEmail => driver.FindElement(By.Id("email"));
        public IWebElement AddButton => driver.FindElement(By.CssSelector("body > form > button"));
        public IWebElement AddNum1 => driver.FindElement(By.Id("number1"));
        public IWebElement AddNum2 => driver.FindElement(By.Id("number2"));
        public IWebElement Operator => driver.FindElement(By.CssSelector("#operation"));
        public IWebElement Calculate => driver.FindElement(By.Id("calcButton"));
        public IWebElement ResetButton => driver.FindElement(By.Id("resetButton"));
        public IWebElement Result => driver.FindElement(By.Id("result"));



        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }

        public bool IsOpen()
        {
            return driver.Url == (this.PageUrl);
        }

        public string GetPageUrl()
        {
            return driver.Url;
        }

        public string GetPageHeading()
        {
            return PageHeading.Text;
        }
        public string GetPageTitle()
        {
            return driver.Title;
        }
    }
}
