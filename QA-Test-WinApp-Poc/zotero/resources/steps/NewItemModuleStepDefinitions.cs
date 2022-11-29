using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class NewItemModuleStepDefinitions
    {
 
            private windowsIntialize windowinitialize;


            public NewItemModuleStepDefinitions(windowsIntialize windowIntialize)
            {
                this.windowinitialize = windowIntialize;

            }
            [Given(@"As a User i launch the zotero application and click file button in zotero homepage\.")]
        public void GivenAsAUserILaunchTheZoteroApplicationAndClickFileButtonInZoteroHomepage_()
        {
            windowinitialize.newzoterohomepage.Filebtn();
        }

        [When(@"i click the new item \.")]
        public void WhenIClickTheNewItem_()
        {
            windowinitialize.newzoterohomepage.MenuNewItem();
        }

        [When(@"i create a new artwork and enter the data")]
        public void WhenICreateANewArtworkAndEnterTheData()
        {
            windowinitialize.newzoterohomepage.creationofARtwork();
            windowinitialize.newzoterohomepage.enterdateinartwork();
            Console.WriteLine("Data Created In Artwork");

        }

        [Then(@"I verify created artwork\.")]
        public void ThenIVerifyCreatedArtwork_()
        {

            
        }
    }
}
