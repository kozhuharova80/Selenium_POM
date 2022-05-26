using OpenQA.Selenium;

namespace Test_Selenium_POM.Pages
{
    public class HomePage : Base_Pages
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/";
        public IWebElement studentCount => driver.FindElement(By.CssSelector("body > p > b"));

        public int StudentCount()
        {
            return int.Parse(studentCount.Text);
        }
    }
}
