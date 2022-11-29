using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Windows;
using TechTalk.SpecFlow;

namespace QA_Test_WinApp_Poc.zotero.resources.steps
{
    public class File
    {
        private windowsIntialize windowinitialize;


        public File(windowsIntialize windowIntialize)
        {
            this.windowinitialize = windowIntialize;

        }
        WindowsDriver<WindowsElement> window;
        [Given(@"Launch the ""Zotero"" Application.")]
        public void GivenLaunchtheZoteroApplication()
        {
            Console.WriteLine("Application Title >>>>");
        }

        [When(@"I click on the ""File"" button")]
        public void Wheniclickonthefilebutton()
        {
         //   windowinitialize.file.clickfilebtn();
        }

       /* [When(@"I need to click on the ""Import"" window.")]
        public void WhenIneedtoclickontheImportwindow()
        {
            windowinitialize.file.clickimport();
        }

        [When(@"I click on the ""File"" button")]
        public void WhenIclickonthefilebutton()
        {
            windowinitialize.file.clickfilebtn();
        }

        [When(@"I need to click on the ""Import from Clipboard"" window.")]
        public void WhenIneedtoclickontheImportfromClipboardwindow()
        {
            windowinitialize.file.clickimportfromclipboard();
        }

        [When(@"I click on the ""File"" button.")]
        public void WhenIclickontheFlebutton()
        {
            windowinitialize.file.clickfilebtn();

        }
        [When(@"select the ""close"" option.")]
        public void Whenselectthecloseoption()
        {
            windowinitialize.file.clickmenuClose();
        }*/
        
       
    
    }
}
