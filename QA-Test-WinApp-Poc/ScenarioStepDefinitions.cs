using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class ScenarioStepDefinitions
    {
        private windowsIntialize windowinitialize;

        public ScenarioStepDefinitions(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }
        [Given(@"I launch the application and click the Map in the New Item")]
        public void GivenILaunchTheApplicationAndClickTheMapInTheNewItem()
        {
            windowinitialize.scenarioClass.clickMap();
        }

        [When(@"I enter the data for the Item Map")]
        public void WhenIEnterTheDataForTheItemMap()
        {
            windowinitialize.scenarioClass.enterdatainMap();
        }

        [Then(@"I verify the created Item Map")]
        public void ThenIVerifyTheCreatedItemMap()
        {
            windowinitialize.scenarioClass.gettitletextforMap();
        }

        [Given(@"I am on the created Map Item")]
        public void GivenIAmOnTheCreatedMapItem()
        {
            windowinitialize.scenarioClass.verifyMapcreation();
        }

        [When(@"I click the button on the Map info tab")]
        public void WhenIClickTheButtonOnTheMapInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Map")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForMap()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the Newspaper Article in the File Menu")]
        public void GivenIClickOnTheNewspaperArticleInTheFileMenu()
        {
            windowinitialize.scenarioClass.clickNewspaper();
        }

        [When(@"I enter the data for the Item Newspaper")]
        public void WhenIEnterTheDataForTheItemNewspaper()
        {
            windowinitialize.scenarioClass.enterdatainNewspaper();
        }

        [Then(@"I verify the created Item Newspaper")]
        public void ThenIVerifyTheCreatedItemNewspaper()
        {
            windowinitialize.scenarioClass.gettitletextforNewspaper();
        }

        [Given(@"I am on the created Newspaper Article Item")]
        public void GivenIAmOnTheCreatedNewspaperArticleItem()
        {
            windowinitialize.scenarioClass.verifyNewspaperarticlecreation();
        }

        [When(@"I click the button on the Newspaper Article info tab")]
        public void WhenIClickTheButtonOnTheNewspaperArticleInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Newspaper Article")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForNewspaperArticle()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the Patent")]
        public void GivenIClickOnThePatent()
        {
            windowinitialize.scenarioClass.clickPatent();
        }

        [When(@"I enter the data for the Item Patent")]
        public void WhenIEnterTheDataForTheItemPatent()
        {
            windowinitialize.scenarioClass.enterinputsforPatent();
        }

            [Then(@"I verify the created Item Patent")]
        public void ThenIVerifyTheCreatedItemPatent()
        {
            windowinitialize.scenarioClass.gettitletextforPatent();
        }

        [Given(@"I am on the created Patent Item")]
        public void GivenIAmOnTheCreatedPatentItem()
        {
            windowinitialize.scenarioClass.verifyPatentcreation();
        }

        [When(@"I click the button on the Patent info tab")]
        public void WhenIClickTheButtonOnThePatentInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Patent")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForPatent()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the Podcast")]
        public void GivenIClickOnThePodcast()
        {
            windowinitialize.scenarioClass.clickPodcast();
        }

        [When(@"I enter the data for the Item Podcast")]
        public void WhenIEnterTheDataForTheItemPodcast()
        {
            windowinitialize.scenarioClass.enterinputsforPodcast();
        }

        [Then(@"I verify the created Item Podcast")]
        public void ThenIVerifyTheCreatedItemPodcast()
        {
            windowinitialize.scenarioClass.gettitletextforPodcast();
        }

        [Given(@"I am on the created Podcast Item")]
        public void GivenIAmOnTheCreatedPodcastItem()
        {
            windowinitialize.scenarioClass.verifyPodcastcreation();
        }

        [When(@"I click the button on the Podcast info tab")]
        public void WhenIClickTheButtonOnThePodcastInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Podcast")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForPodcast()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the Preprint")]
        public void GivenIClickOnThePreprint()
        {
            windowinitialize.scenarioClass.clickPreprint();
        }

        [When(@"I enter the Test Data for the item preprint")]
        public void WhenIEnterTheTestDataForTheItemPreprint()
        {
            windowinitialize.scenarioClass.enterinputsforPreprint();
        }

        [Then(@"I verify the created Item Preprint")]
        public void ThenIVerifyTheCreatedItemPreprint()
        {
            windowinitialize.scenarioClass.gettitletextforPreprint();
        }

        [Given(@"I am on the created Preprint Item")]
        public void GivenIAmOnTheCreatedPreprintItem()
        {
            windowinitialize.scenarioClass.verifyPreprintcreation();
        }

        [When(@"I click the button on the Preprint info tab")]
        public void WhenIClickTheButtonOnThePreprintInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Preprint")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForPreprint()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the TV Broadcast")]
        public void GivenIClickOnTheTVBroadcast()
        {
            windowinitialize.scenarioClass.clickTVbroadcast();
        }

        [When(@"I enter the test data for the item TV broadcast")]
        public void WhenIEnterTheTestDataForTheItemTVBroadcast()
        {
            windowinitialize.scenarioClass.enterdatainTVbroadcast();
        }

        [Then(@"I verify the created Item TV Broadcast")]
        public void ThenIVerifyTheCreatedItemTVBroadcast()
        {
            windowinitialize.scenarioClass.gettitletextforTVbroadcast();
        }

        [Given(@"I am on the created TV Broadcast Item")]
        public void GivenIAmOnTheCreatedTVBroadcastItem()
        {
            windowinitialize.scenarioClass.verifyTVbroadcastcreation(); 
        }

        [When(@"I click the button on the TV Broadcast info tab")]
        public void WhenIClickTheButtonOnTheTVBroadcastInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for TV Broadcast")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForTVBroadcast()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the Video Recording")]
        public void GivenIClickOnTheVideoRecording()
        {
            windowinitialize.scenarioClass.clickVideorecording();
        }

        [When(@"I enter the test data for the item Video recording")]
        public void WhenIEnterTheTestDataForTheItemVideoRecording()
        {
            windowinitialize.scenarioClass.enterdatainVideorecording();
        }

        [Then(@"I verify the created Item Video Recording")]
        public void ThenIVerifyTheCreatedItemVideoRecording()
        {
            windowinitialize.scenarioClass.gettitletextforVideorecording();
        }

        [Given(@"I am on the created Video Recording Item")]
        public void GivenIAmOnTheCreatedVideoRecordingItem()
        {
            windowinitialize.scenarioClass.verifyVideorecordingcreation();
        }

        [When(@"I click the button on the Video Recording info tab")]
        public void WhenIClickTheButtonOnTheVideoRecordingInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Video Recording")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForVideoRecording()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

            [Given(@"I click on the Radio Broadcast")]
        public void GivenIClickOnTheRadioBroadcast()
        {
            windowinitialize.scenarioClass.ClickRadioBroadCast();
        }

        [When(@"I enter the test data for the item Radio broadcast")]
        public void WhenIEnterTheTestDataForTheItemRadioBroadcast()
        {
            windowinitialize.scenarioClass.EnterDataInRadioBroadCast();
        }

        [Then(@"I verify the created Item Radio Broadcast")]
        public void ThenIVerifyTheCreatedItemRadioBroadcast()
        {
            windowinitialize.scenarioClass.GettitletextforRadioBroadcast();
        }

        [Given(@"I am on the created Radio Broadcast Item")]
        public void GivenIAmOnTheCreatedRadioBroadcastItem()
        {
            windowinitialize.scenarioClass.verifyRadiobroadcastcreation();
        }

        [When(@"I click the button on the Radio Broadcast info tab")]
        public void WhenIClickTheButtonOnTheRadioBroadcastInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Radio Broadcast")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForRadioBroadcast()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the Software")]
        public void GivenIClickOnTheSoftware()
        {
            windowinitialize.scenarioClass.ClickSoftware();
        }

        [When(@"I enter the data for the Item Software")]
        public void WhenIEnterTheDataForTheItemSoftware()
        {
            windowinitialize.scenarioClass.enterinputsforSoftware();
        }

        [Then(@"I verify the created Item Software")]
        public void ThenIVerifyTheCreatedItemSoftware()
        {
            windowinitialize.scenarioClass.gettitletextforSoftware();
        }

        [Given(@"I am on the created Software Item")]
        public void GivenIAmOnTheCreatedSoftwareItem()
        {
            windowinitialize.scenarioClass.verifySoftwarecreation();
        }

        [When(@"I click the button on the Software info tab")]
        public void WhenIClickTheButtonOnTheSoftwareInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Software")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForSoftware()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I on click the Statute")]
        public void GivenIOnClickTheStatute()
        {
            windowinitialize.scenarioClass.clickStatute();
        }

        [When(@"I enter the data for the Item Statute")]
        public void WhenIEnterTheDataForTheItemStatute()
        {
            windowinitialize.scenarioClass.enterinputsforStatute();
        }

        [Then(@"I verify the created Item Statute")]
        public void ThenIVerifyTheCreatedItemStatute()
        {
            windowinitialize.scenarioClass.gettitletextforStatute();
        }

        [Given(@"I am on the created Statue Item")]
        public void GivenIAmOnTheCreatedStatueItem()
        {
            windowinitialize.scenarioClass.verifyStatutecreation();
        }

        [When(@"I click the button on the Statue info tab")]
        public void WhenIClickTheButtonOnTheStatueInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Statue")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForStatue()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the Presentation")]
        public void GivenIClickOnThePresentation()
        {
            windowinitialize.scenarioClass.ClickPresentation();
        }

        [When(@"I enter Data for the item Presentation")]
        public void WhenIEnterDataForTheItemPresentation()
        {
            windowinitialize.scenarioClass.enterinputsforPresentation();
        }

        [Then(@"I verify created Item for Presentation")]
        public void ThenIVerifyCreatedItemForPresentation()
        {
            windowinitialize.scenarioClass.GettitletextforPresentation();
        }

        [Given(@"I am on the created Presentation Item")]
        public void GivenIAmOnTheCreatedPresentationItem()
        {
            windowinitialize.scenarioClass.verifyPresentationcreation();
        }

        [When(@"I click the button on the Presentation info tab")]
        public void WhenIClickTheButtonOnThePresentationInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Presentation")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForPresentation()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }

        [Given(@"I click on the Thesis")]
        public void GivenIClickOnTheThesis()
        {
            windowinitialize.scenarioClass.ClickThesis();
        }

        [When(@"I enter Data for the item Thesis")]
        public void WhenIEnterDataForTheItemThesis()
        {
            windowinitialize.scenarioClass.EnterDataInThesis();
        }

        [Then(@"I verify created Item for Thesis")]
        public void ThenIVerifyCreatedItemForThesis()
        {
            windowinitialize.scenarioClass.gettitletextforThesis();
        }

        [Given(@"I am on the created Thesis Item")]
        public void GivenIAmOnTheCreatedThesisItem()
        {
            windowinitialize.scenarioClass.verifyThesiscreation();
        }

        [When(@"I click the button on the Thesis info tab")]
        public void WhenIClickTheButtonOnTheThesisInfoTab()
        {
            windowinitialize.scenarioClass.switchtoFields();
        }

        [Then(@"I verify the functionality of the buttons for Thesis")]
        public void ThenIVerifyTheFunctionalityOfTheButtonsForThesis()
        {
            windowinitialize.scenarioClass.addDeleteprogrammer();
        }
    }
}
