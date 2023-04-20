using BBCProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObject
{
    class BBCHomePage : BaseTest
    {
        private By sportMenu = By.CssSelector(".ssrcss-13tejcu-NavItemHoverState.e1gviwgp18");


        public void ClickSportMenu()
        {
           driver.FindElement(sportMenu).Click();

        }
        public bool SportPageIsDisplayed()
        {
            return driver.Url.Contains("www.bbc.co.uk/sport");
        }


    }
}
