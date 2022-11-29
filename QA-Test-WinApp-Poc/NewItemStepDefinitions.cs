
using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class NewItemStepDefinition
    {
        private windowsIntialize windowinitialize;


        public NewItemStepDefinition(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }
        [Given(@"I launch the application and click the file in menu\.")]
        public void GivenILaunchTheApplicationAndClickTheFileInMenu_()
        {
            windowinitialize.homepageZotero.ClickFile();
        }

        [When(@"I click the Map from New item menu the item will be created")]
        public void WhenIClickTheMapFromNewItemMenuTheItemWillBeCreated()
        {
            windowinitialize.homepageZotero.ClickMap();
        }

        [When(@"I enter the data for the item Map")]
        public void WhenIEnterTheDataForTheItemMap()
        {
            windowinitialize.homepageZotero.enterdateinmap();
        }

        [Then(@"I verify the created item Map")]
        public void ThenIVerifyTheCreatedItemMap()
        {
            windowinitialize.homepageZotero.GettitletextforMap();
        }

        [Given(@"I launch the application and click the file  menu\.")]
        public void GivenILaunchTheApplicationAndClickTheFileMenu_()
        {
            windowinitialize.homepageZotero.ClickFile();
        }

        [When(@"I click the Newspaper from New item menu the item will be created")]
        public void WhenIClickTheNewspaperFromNewItemMenuTheItemWillBeCreated()
        {
            windowinitialize.homepageZotero.ClickNewspaper();
        }

        [When(@"I enter the data for the item Newspaper")]
        public void WhenIEnterTheDataForTheItemNewspaper()
        {
            windowinitialize.homepageZotero.enterdatainNewspaper();
        }

        [Then(@"I verify the created item Newspaper")]
        public void ThenIVerifyTheCreatedItemNewspaper()
        {
            windowinitialize.homepageZotero.GettitletextforNewspaper();
        }

        [Given(@"I launch the application and click the file menu\.")]
        public void GivenILaunchApplicationAndClickTheFileMenu_()
        {
            windowinitialize.homepageZotero.ClickFile();
        }

        [When(@"I click the Patent from New item menu the item will be created")]
        public void WhenIClickThePatentFromNewItemMenuTheItemWillBeCreated()
        {
            windowinitialize.homepageZotero.ClickPatent();
        }

        [When(@"I enter the data for the item Patent")]
        public void WhenIEnterTheDataForTheItemPatent()
        {
            windowinitialize.homepageZotero.EnterInputsforPatent();
        }

        [Then(@"I verify the created item Patent")]
        public void ThenIVerifyTheCreatedItemPatent()
        {
            windowinitialize.homepageZotero.Gettitletextforpatent();
        }

        [When(@"I click the Podcast from New item menu the item will be created")]
        public void WhenIClickThePodcastFromNewItemMenuTheItemWillBeCreated()
        {
            windowinitialize.homepageZotero.clickPodcast();
        }

        [When(@"I enter the data for the item Podcast")]
        public void WhenIEnterTheDataForTheItemPodcast()
        {
            windowinitialize.homepageZotero.EnterInputsforPodcast();
        }

        [Then(@"I verify the created item Podcast")]
        public void ThenIVerifyTheCreatedItemPodcast()
        {
            windowinitialize.homepageZotero.Gettitletextforpodcast();
        }

        [Given(@"I launch the application and i click the file menu")]
        public void GivenILaunchTheApplicationAndIClickTheFileMenu()
        {
            windowinitialize.homepageZotero.ClickFile();
        }

        [When(@"I click the Preprint in New item Menu")]
        public void WhenIClickThePreprintInNewItemMenu()
        {
            windowinitialize.homepageZotero.ClickPreprint();
        }

        [When(@"I enter the test Data")]
        public void WhenIEnterTheTestData()
        {
            windowinitialize.homepageZotero.EnterInputsforPreprint();
        }

        [Then(@"I able to see the Preprint creation in the title panel and its info in table pane")]
        public void ThenIAbleToSeeThePreprintCreationInTheTitlePanelAndItsInfoInTablePane()
        {
            windowinitialize.homepageZotero.GettitletextforPreprint();
        }
    }
}
