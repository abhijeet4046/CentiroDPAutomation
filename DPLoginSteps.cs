using System;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class DPLoginSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered username '(.*)' into the login page")]
        public void GivenIHaveEnteredUsernameIntoTheLoginPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered password '(.*)' into the login page")]
        public void GivenIHaveEnteredPasswordIntoTheLoginPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I clicked signIn")]
        public void WhenIClickedSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user able to view DeliveryPerformance dashboard")]
        public void ThenUserAbleToViewDeliveryPerformanceDashboard()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
