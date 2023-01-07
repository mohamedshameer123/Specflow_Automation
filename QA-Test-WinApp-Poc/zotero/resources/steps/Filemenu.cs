using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class Filemenu
    {
        private windowsIntialize windowinitialize;


        public Filemenu(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }
        [Given(@"As a User i launch Zotero Application and click Import in FileMenu")]
        public void GivenAsAUserILaunchZoteroApplicationAndClickImportInFileMenu()
        {
            windowinitialize.newzoterohomepage.Filebutton();
        }

        [When(@"I click on close the import window")]
        public void WhenIClickOnCloseTheImportWindow()
        {
            windowinitialize.newzoterohomepage.cancelimport();
        }

        [Then(@"The import window should close")]
        public void ThenTheImportWindowShouldClose()
        {
            windowinitialize.newzoterohomepage.afterclsimport();
        }
        [Then(@"I Get Root")]
        public void ThenIGetRoot()
        {
            windowinitialize.zoteromainpage.Winappdriver();
        }


    }
}
