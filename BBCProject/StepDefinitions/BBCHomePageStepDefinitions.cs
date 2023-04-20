using BBCProject.Hooks;
using BBCProject.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class BBCHomePageStepDefinitions : BaseTest
    {
        BBCHomePage bBCHomePage = new BBCHomePage();

        [Given(@"a user navigate to the website ""([^""]*)""")]
        public void GivenAUserNavigateToTheWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        [When(@"a user click on sport menu")]
        public void WhenAUserClickOnSportMenu()
        {
            bBCHomePage.ClickSportMenu();
        }

        [Then(@"the sport page is displayed")]
        public void ThenTheSportPageIsDisplayed()
        {
           Assert.IsTrue(bBCHomePage.SportPageIsDisplayed());
        }



    }
}
