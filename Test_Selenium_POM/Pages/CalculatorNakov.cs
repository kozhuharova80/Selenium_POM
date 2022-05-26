using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Selenium_POM.Pages
{
    public class CalculatorNakov : Base_Pages
    {
        public CalculatorNakov(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://number-calculator.nakov.repl.co/";

        public void Calulate (string num1, string num2, string oper)
        {
            AddNum1.SendKeys(num1);
            AddNum2.SendKeys(num2);
            Operator.SendKeys(oper);
            Calculate.Click();
        }

        public void ResetCalc ()
        {
            ResetButton.Click();
        }

        public string ResultCalc ()
        {
            return Result.Text;
        }
       
    }
}
