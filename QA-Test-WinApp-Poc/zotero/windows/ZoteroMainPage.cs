using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using QA_Test_WinApp_Poc.cap.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Keyboard = FlaUI.Core.Input.Keyboard;
using System.Drawing.Imaging;
using OpenQA.Selenium.Appium;
using WindowsInput;
using WindowsInput.Native;
using System.Runtime.InteropServices;
using RazorEngine.Compilation.ImpromptuInterface.InvokeExt;

namespace QA_Test_WinApp_Poc.zotero.windows
{
    public class ZoteroMainPage : baseWindow
    {
        static WindowsDriver<WindowsElement> _window;
        public ZoteroMainPage(WindowsDriver<WindowsElement> window) : base(window)
        {
            Console.WriteLine("---> Enter into Windows Pages Class - Constructor...");
            _window = window;
        }
        public By NewItemMenu => By.Name("New Item");
        public By TitlePreprint => By.Name("Preprint title Sample>>. Preprint.");

        public void ClickFile()
        {
            Thread.Sleep(3000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);

        }
        public void ClickItem()
        {
            /*Thread.Sleep(3000);
            WindowsElement Newitem = _window.FindElement(FileBtn);
            Newitem.Click();
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000)*/
            ;
        }
        public void EnterInputsforPreprint()
        {
            Thread.Sleep(2000);
            Keyboard.Type("Preprint title Sample>>");

            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Author Program");



            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Genre Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Repository Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Archive ID Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Place Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Series Sample<>><><");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Series Number >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("DOI >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Citation key >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("URLzoterosample.com");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("12/5/78>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Archive >>> Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Loc.in Archive >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Short title >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Language>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Library Catalog example Extra>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Call Number Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Rights Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Extra sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Thread.Sleep(2000);

        }

        public void GettitletextforPreprint()
        {

            string titlename = _window.FindElement(TitlePreprint).Text;
            Console.WriteLine("Title of Software>>>" + titlename);
            string PageItems = window.PageSource;
            Console.WriteLine("PageSource>>>>" + PageItems);

        }

        public WindowsDriver<WindowsElement> Winappdriver()

            {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", "C:\\Program Files (x86)\\Zotero\\Zotero.exe");
            options.AddAdditionalCapability("deviceName", "WindowsPc");
            window = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
            Console.WriteLine("---> Windows App launched ... Successfuly.... :) ");
            return window;
            Console.WriteLine("Num>>>>>" + window);
        }

    
            

        }


        }





    
