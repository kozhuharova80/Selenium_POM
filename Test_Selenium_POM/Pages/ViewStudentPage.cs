
using OpenQA.Selenium;

namespace Test_Selenium_POM.Pages
{
    public class ViewStudentPage : Base_Pages
    {
        public ViewStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/students";
    }
}
