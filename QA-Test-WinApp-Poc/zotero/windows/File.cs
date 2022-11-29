using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using QA_Test_WinApp_Poc.cap.common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QA_Test_WinApp_Poc.zotero.windows
{
    public class File : baseWindow
    {
        public File(WindowsDriver<WindowsElement> window) : base(window)
        {
            _window = this.window;
        }
        static WindowsDriver<WindowsElement> _window;

        public By Filebutton => By.Name("File");
        //public By Importbutton => By.Name("Import…\tCtrl+Shift+I");
        //public By ImportfromClipboardbutton => By.Name("Import from Clipboard\tCtrl+Shift+Alt+I");
        //public By Closebutton => By.Name("Close\tCtrl+W");

       
        public void clickfilebtn()
            
        {
            WindowsElement ComboFileButton = _window.FindElement(Filebutton);
            ComboFileButton.Click();
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.Enter);

        }
     
       /* public void clickimport()
        {
            Console.WriteLine("click on import");
            _window.FindElement(Importbutton).Click();
            
        }
        public void clickimportfromclipboard()
        {
            Console.WriteLine("click on import from clipboard");
            _window.FindElement(ImportfromClipboardbutton).Click();
        }
        public void clickmenuClose()
        {
            Console.WriteLine("user i click Close");
            _window.FindElement(Closebutton).Click();
        }*/
        
    }
}
