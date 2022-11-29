using System;
using OpenQA.Selenium.Appium.Windows;
using QA_Test_WinApp_Poc.zotero;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc
{
    [Binding]
    public class File1
    {
        private windowsIntialize windowinitialize;
       

        public File1(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }
        WindowsDriver<WindowsElement> window;
        [Given(@"I am on Zotero")]
        public void GivenIAmOnZotero()
        {
         
            Console.WriteLine("Application Title >>>>");
        }

        [Then(@"I should see Application")]
        public void ThenIShouldSeeApplication()
        {
            windowinitialize.zoterohomepage.clickfilebtn();
        }
    }
}
