using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class FilemenuStepDefinitions
    {

        private windowsIntialize windowinitialize;


        public FilemenuStepDefinitions(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }


        [Then(@"I Get Root")]
        public void ThenIGetRoot()
        {

            windowinitialize.zoteromainpage.Winappdriver();

        }
    }
}
