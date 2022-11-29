using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.BindingSkeletons;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class NewNoteModuleStepDefinitions1
    {
        private windowsIntialize windowinitialize;


        public NewNoteModuleStepDefinitions1(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }
        [Given(@"As a User i launch Zotero Application and click NewNote in FileMenu\.")]
        public void GivenAsAUserILaunchZoteroApplicationAndClickNewNoteInFileMenu_()
        {
            windowinitialize.newzoterohomepage.Filebtn();
        }

        [When(@"I enter the text in Zotero Note Editor\.")]
        public void WhenIEnterTheTextInZoteroNoteEditor_()
        {
            windowinitialize.newzoterohomepage.enterNote();
        }

        [When(@"I check the all buttons functionality present in zotero note editor\.")]
        public void WhenICheckTheAllButtonsFunctionalityPresentInZoteroNoteEditor_()
        {

            windowinitialize.newzoterohomepage.newNoteEditButton();
        }

        [When(@"I click the More Option\.")]
        public void WhenIClickTheMoreOption_()
        {
            windowinitialize.newzoterohomepage.btnmoreClick();


        }

        [Then(@"I verify the Edit Seperete Window\.")]
        public void ThenIVerifyTheEditSepereteWindow_()
        {
            windowinitialize.newzoterohomepage.afterclickmore();
        }
    }
}
