using System;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class ScrlStepDefinitions
    {
        private windowsIntialize windowinitialize;

        public ScrlStepDefinitions(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }
        [Given(@"Click on  preprint item")]
        public void GivenClickOnPreprintItem()
        {
            windowinitialize.scenarioClass.clickPreprint();
        }

        [Then(@"Process the scroll function")]
        public void ThenProcessTheScrollFunction()
        {
            windowinitialize.scenarioClass.Scroll();
        }
    }
}
