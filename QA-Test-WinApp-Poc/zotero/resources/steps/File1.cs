using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class File
    {
        [Given(@"launch the Zotero Application\.")]
        public void GivenLaunchTheZoteroApplication_()
        {
            Console.WriteLine("zotero");
        }

        [When(@"i click on the File button\.")]
        public void WhenIClickOnTheFileButton_()
        {
         //   windowsIntialize.clickfilebtn();
        }

        [When(@"i need to click on the Import window\.")]
        public void WhenINeedToClickOnTheImportWindow_()
        {
            throw new PendingStepException();
        }

        [Then(@"new window should be opened for import\.")]
        public void ThenNewWindowShouldBeOpenedForImport_()
        {
            throw new PendingStepException();
        }
    }
}
