using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class PreprintStepDefinitions
    {
        private windowsIntialize windowinitialize;


        public PreprintStepDefinitions(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }


        [Given(@"I launch the application and click the file menu")]
        public void GivenILaunchTheApplicationAndClickTheFileMenu()
        {
            windowinitialize.zoteromainpage.ClickFile();
        }

        [When(@"I click the Preprint in New item menu")]
        public void WhenIClickThePreprintInNewItemMenu()
        {
            //windowinitialize.zoteromainpage.ClickItem();
        }

        [When(@"I enter the test data")]
        public void WhenIEnterTheTestData()
        {
            windowinitialize.zoteromainpage.EnterInputsforPreprint();
        }

        [Then(@"I able to see the Preprint creation in the title panel and its info in tablepane")]
        public void ThenIAbleToSeeThePreprintCreationInTheTitlePanelAndItsInfoInTablepane()
        {
            windowinitialize.zoteromainpage.GettitletextforPreprint();
        }
    }
}
