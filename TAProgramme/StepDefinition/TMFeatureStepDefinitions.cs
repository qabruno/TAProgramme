using System;
using TechTalk.SpecFlow;

namespace TAProgramme.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a time record")]
        public void WhenICreateATimeRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
