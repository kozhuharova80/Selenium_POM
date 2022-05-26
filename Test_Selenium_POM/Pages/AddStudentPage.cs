using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Test_Selenium_POM.Pages
{
    public class AddStudentPage : Base_Pages
    {
        public AddStudentPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/add-student";

        
        public void RegStudent(string name, string email)
        {
            AddName.SendKeys(name);
            AddEmail.SendKeys(email);
            AddButton.Click();  
        }   

    }

}
