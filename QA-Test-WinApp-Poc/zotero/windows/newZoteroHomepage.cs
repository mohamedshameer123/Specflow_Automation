using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Windows.Threading;
using Microsoft.VisualBasic.Devices;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using QA_Test_WinApp_Poc.cap.common;
using TechTalk.SpecFlow.BindingSkeletons;
using WindowsInput;
using WindowsInput.Native;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Keyboard = FlaUI.Core.Input.Keyboard;

namespace QA_Test_WinApp_Poc.zotero.windows
{
    public class newZoteroHomepage : baseWindow
    {
        public newZoteroHomepage(WindowsDriver<WindowsElement> window) : base(window)
        {
            Console.WriteLine("---> Enter into Windows Pages Class - COnstructor...");
            _window = this.window;
        }
        static WindowsDriver<WindowsElement> _window;

        //WindowsElements(pom)
        public By buttonFile
            => By.Name("File");

        public By buttonEdit
            => By.Name("Edit");

        public By buttonView
        => By.Name("View");

        public By buttonNewitem
        => By.XPath("//*[contains(@Name,'New Item')]");

        public By menuNewItem
            => By.Name("New Item");

        public By btnArt
            => By.Name("Artwork");

        public By txtTitle
            => By.XPath("//*[contains(@Name,'Title')]");

        public By panTitleart
            => By.XPath("//*[contains(@Name,'. Artwork.')]");


        public By btnFormatText
            => By.XPath("//*[contains(@Name,'Format Text')]");

        public By btnHighLightText
            => By.XPath("//*[contains(@Name,'Highlight Text')]");

        public By btnMore
            => By.XPath("//*[contains(@Name,'More')]");
        public By importcancel
            => By.Name("Cancel");


        public By ImportnewWindow
            => By.Name("Import");

        public By TitleArtWork
            => By.Name("Artwork Test Sample>>. Artwork. Artist Sample");

        public By AID => By.XPath("//*[contains(@AutomationID,'itembox-field-value-abstractNote')]");
        public void ClicknewItem()
        {
           _window.FindElement(buttonNewitem).Click();
        }


       

        public void Filebtn()
        {
                wait(7000);
            WindowsElement ComboFileButton = _window.FindElement(buttonFile);
            ComboFileButton.Click();
        }

        public void MenuNewItem()
        {
            wait(7000);
            WindowsElement ComboFileButton = _window.FindElement(menuNewItem);
            ComboFileButton.Click();
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowRight);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.Enter);

        }

       
        public void enterNote()
        {
            Console.WriteLine("Entering the notes in editor windo>>>>");
            Keyboard.Type("TestSample");
           WindowsElement AfterEntertextclassname = _window.FindElement(By.Name("TestSample"));
             //AfterEntertextclassname.SendKeys(OpenQA.Selenium.Keys.LeftCo);
           WindowsElement bttnEdit = _window.FindElement(By.Name("Edit"));
            bttnEdit.Click();
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(2000);
            bttnEdit.SendKeys(OpenQA.Selenium.Keys.Enter);

 }

        public void newNoteEditButton()
        {
            //for format click
            WindowsElement NewNoteEditBtn = _window.FindElement(btnFormatText);
            NewNoteEditBtn.Click();
            NewNoteEditBtn.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            NewNoteEditBtn.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            NewNoteEditBtn.SendKeys(OpenQA.Selenium.Keys.Enter);
            bool buttondisplayed = NewNoteEditBtn.Enabled;
            Console.WriteLine("Text Is Enabled>>>>" + buttondisplayed);
            Thread.Sleep(2000);



            //click Highlight Text
            WindowsElement HighlightTextbtn = _window.FindElement(btnHighLightText);
            HighlightTextbtn.Click();
            _window.FindElement(By.Name("Yellow")).Click();
            bool HighLightEnabled = HighlightTextbtn.Enabled;
            Console.WriteLine("HighLight button is enabled>>>>" + HighLightEnabled);
            Thread.Sleep(2000);

        }

        public void btnmoreClick()
        {
           WindowsElement btnMoreicon = _window.FindElement(btnMore);
            Thread.Sleep(2000);
            btnMoreicon.Click();
            btnMoreicon.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            btnMoreicon.SendKeys(OpenQA.Selenium.Keys.Enter);


        }

        public void afterclickmore()
        {
            var WindowHandlesaftermore = _window.WindowHandles;
            Console.WriteLine("Window Handles>>>" + WindowHandlesaftermore);

        }
        public void Filebutton()
        {
            WindowsElement ComboFileButton = _window.FindElement(buttonFile);
            ComboFileButton.Click();
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);

        }

        public void cancelimport()
        {
            /* var WindowHandlesafterclose = _window.WindowHandles;
             //ArrayList Handles = new ArrayList(WindowHandlesafterclose);
           WindowsElement impNewWin=  _window.FindElement(ImportnewWindow);
             _window.SwitchTo().Frame(impNewWin);

             Console.WriteLine("Window Handles After Clicking>>>>" + WindowHandlesafterclose);
             var windowscount=WindowHandlesafterclose.Count();
             //_window.SwitchTo().Window(WindowHandlesafterclose[0]);
            string Titleapp= _window.Title;
             Console.WriteLine("Application presentwindow Title>>>"+Titleapp);
             Thread.Sleep(2000);
            // _window.CloseApp();
           _window.FindElement(importcancel).Click();
             */
            Console.WriteLine("Need To Add Scrip");
        }
        
        public void afterclsimport()
        {
            var WindowHandlesafterclose = _window.WindowHandles;
            Console.WriteLine("Window Handles>>>" + WindowHandlesafterclose);
        }

        public void creationofARtwork()
        {
            WindowsElement NewItemButton=_window.FindElement(btnMore);
            NewItemButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            NewItemButton.SendKeys(OpenQA.Selenium.Keys.Enter);
            Console.WriteLine("Artwork Created>>>><>><><><");

        }

        public void enterdateinartwork()
        {
            Thread.Sleep(2000);
            Keyboard.Type("Artwork Test Sample>>");

           /* WindowsElement CFB = _window.FindElementByName("Artwork Test Sample>>");
            /*CFB.SendKeys(OpenQA.Selenium.Keys.Tab);
            CFB.SendKeys(OpenQA.Selenium.Keys.Tab);
            CFB.SendKeys(OpenQA.Selenium.Keys.Tab);
            CFB.SendKeys(OpenQA.Selenium.Keys.Tab);*/
            InputSimulator Sample = new InputSimulator();
            Sample.Keyboard.KeyPress(VirtualKeyCode.TAB);

            WindowsElement TitleNameforTab=_window.FindElement(By.Name("Artwork Test Sample>>. Artwork."));
            WindowsElement TitleNamefortab = window.FindElement(AID);
            TitleNamefortab.SendKeys(OpenQA.Selenium.Keys.Tab);
            //Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            //Keyboard.Type(OpenQA.Selenium.Keys.Tab); 
            Thread.Sleep(1000);
            Keyboard.Type("Artist Sample");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Medium Sample");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Artwork Size Sample");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Language Sample Test<>><><");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Short Title>>> Sample>>");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Archive>>> Sample>>");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Loc>>> Sample>>");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("library Catalog  >>> Sample>>");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("0987654413");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("zoterosample.com");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Accessed>>>Sample>>>");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("RightSample >>>Sample>>>");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Sample Extra>>>>");
            Thread.Sleep(1000);
            Keyboard.Type(OpenQA.Selenium.Keys.Escape);
            Thread.Sleep(1000);
            Thread.Sleep(2000);

        }

        public void Gettitletext()
        {
            string Titeletext = _window.FindElement(TitleArtWork).Text;
            Console.WriteLine("Title of artwork>>>"+Titeletext);

        }

        static void wait()
        {
            Task output = Task.Factory.StartNew(LongRunningOperation);
            Console.WriteLine(output.Exception);
        }
        private static int LongRunningOperation()
        {
            Thread.Sleep(7000);
            return 7000;
        }

        public static void DelayAction(int milliseconds, Action action)
{
    var timer = new DispatcherTimer();
    timer.Tick += delegate

      
    {
        action.Invoke();
        timer.Stop();
    };

    timer.Interval = TimeSpan.FromMilliseconds(milliseconds);
    timer.Start();
}

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}

