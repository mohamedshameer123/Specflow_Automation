using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using QA_Test_WinApp_Poc.cap.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow.BindingSkeletons;
using static System.Net.Mime.MediaTypeNames;
using Keyboard = FlaUI.Core.Input.Keyboard;
using System.Drawing.Imaging;
using OpenQA.Selenium.Appium;
using WindowsInput;
using WindowsInput.Native;
using System.Runtime.InteropServices;
using RazorEngine.Compilation.ImpromptuInterface.InvokeExt;
using TechTalk.SpecFlow.Time;
using FlaUI.Core.Input;
using FlaUI.Core.AutomationElements;
using OpenQA.Selenium.Interactions;
using Docker.DotNet.Models;

namespace QA_Test_WinApp_Poc.zotero.windows
{
    public class ScenarioClass : baseWindow
    {
        static WindowsDriver<WindowsElement> _window;

        public ScenarioClass(WindowsDriver<WindowsElement> window) : base(window)
        {
            Console.WriteLine("---> Enter into Windows Pages Class - COnstructor...");
            _window = this.window;
        }
        public By FileBtn => By.Name("File");
        public By NewItemMenu => By.Name("New Item");

        public By menuFile => By.Name("File");

        public By TitleSoftware => By.Name("Software Test Sample>>. Software.");


        public By TitlePatent => By.Name("Patent Test Sample>>. Patent.");


        public By TitlePodcast => By.Name("Podcast Test Sample>>. Podcast.");

        public By TitleStatute => By.Name("Name Of Act Sample. Statute.");

        public By TitlePreprint => By.Name("Preprint title Sample>>. Preprint.");

        public By TitleMap => By.Name("MAP Test Sample>>. Map.");
        public By TitleNewspaper => By.Name("Newspaper Sample. Newspaper Article.");

        public By TitlePresentation => By.Name("Tester sample. Presentation.");

        public By TitleRadioBroadCast => By.Name("Radio Broadcast Test Sample>>. Radio Broadcast.");

        public By TitleThesis => By.Name("Thesis Test Sample>>. Thesis.");

        public By TitleTVBroadcast => By.Name("TV Broadcast Test Sample>>. TV Broadcast.");

        public By TitleVideoRecording => By.Name("Video Recording Test Sample>>. Video Recording.");

        public By TitleAudioRecording => By.Name("Software Test Sample>>. Audio Recording.");

        public By ele = By.Name("ZZZZZ. Preprint.");

        public void FileClick()
        {
            Thread.Sleep(2000);
            WindowsElement ComboFileButton = _window.FindElement(NewItemMenu);
            ComboFileButton.Click();

        }public void Scroll()
        {
            WindowsElement elmnt = _window.FindElement(ele);
            elmnt.Click();
            /*elmnt.SendKeys(Keys.PageDown);
            Thread.Sleep(2000);
            elmnt.SendKeys(Keys.PageDown);
            Thread.Sleep(2000);
            elmnt.SendKeys(Keys.PageDown);*/
            //Mouse.Scroll
            InputSimulator inputSimulator = new InputSimulator();
            /*elmnt.Click();
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SCROLL);
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SCROLL);
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SCROLL);
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SCROLL);
            inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SCROLL);*/
            inputSimulator.Mouse.VerticalScroll(10);




        }
        /*UserName = self.browser.find_element_by_xpath("//input[@id='Username']")
        strUsername = r".\administrator"
        BasePage.enterValue(self, UserName, strUsername)
        Password = self.browser.find_element_by_xpath("//input[@id='passWord']")
        BasePage.enterValue(self, Password, "welcome123#")
        BasePage.click(self, l["btn_Login"])
         'btn_Login': (By.XPATH, "//button[contains(text(),'Log in')]"),*/


        /*public By UserName = By.XPath("//*[@id='Username']");
        public By Password = By.XPath("//*[@id='passWord']");
        public By LoginBtn = By.XPath("//contains(text(), 'Log in')");
*/

        public void ClickFile()
        {
            WindowsElement NewItem = _window.FindElement(NewItemMenu);
            NewItem.Click();

        }
        public void ClickSoftware()
        {
            int i;
            i = 0;
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

                i = i + 1;
            } while (i < 8);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowUp);

                i = i + 1;
            } while (i < 5);
            Thread.Sleep(2000);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

        }



        public void clickTVbroadcast()
        {
            int i;
            i = 0;
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

                i = i + 1;
            } while (i < 8);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowUp);

                i = i + 1;
            } while (i < 2);
            Thread.Sleep(2000);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

        }


        public void enterdatainTVbroadcast()
        {
            Thread.Sleep(2000);
            Keyboard.Type("TV broadcast Test Sample>>");
            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Keyboard.Type("Director Sample");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            /*WindowsElement Add = _window.FindElementByName("+");
            Add.Click();
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);
            //(OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
            Minus.Click();*/


            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Progarm Title");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Episode Number 12");
            Thread.Sleep(1000);


            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Format 1234");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("place");
            Thread.Sleep(1000);


            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Network Airtel");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Running Time");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Language Sample Test<>><><");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Short Title>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("https://www.zotero.org/");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Accessed");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Archive>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Loc.Archive>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("library Catalog  >>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("0987654413");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("RightSample >>>Sample>>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Sample Extra>>>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);


        }

        public void gettitletextforTVbroadcast()
        {

            string titlename = _window.FindElement(TitleTVBroadcast).Text;
            Console.WriteLine("Title of TV Broadcast>>>" + titlename);

        }

        public void verifyTVbroadcastcreation()
        {
            WindowsElement Titletext = _window.FindElementByName("TV Broadcast Test Sample>>. TV Broadcast.");
            Titletext.Click();
        }
        public async void clickVideorecording()
        {
            int i;
            i = 0;
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

                i = i + 1;
            } while (i < 8);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowUp);

                i = i + 1;
            } while (i < 1);
            Thread.Sleep(2000);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

        }



        public void enterdatainVideorecording()
        {
            Thread.Sleep(2000);
            Keyboard.Type("Video Recording Test Sample>>");
            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Task.Delay(1000).Wait();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Task.Delay(5000).Wait();
            Task.Delay(1000).Wait();

            Keyboard.Type("Mystic Magic");
            Thread.Sleep(1000);

           /* inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            WindowsElement Toggle = _window.FindElement(By.Name("Switch to two fields"));
            Toggle.Click();

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            WindowsElement Button = _window.FindElement(By.Name("+"));
            Button.Click();*/


           /* Keyboard.Type("Great ");
            Thread.Sleep(1000);



            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Warrior");
            Thread.Sleep(1000);*/

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            /* WindowsElement Add = _window.FindElementByName("+");
             Add.Click();
             Thread.Sleep(1000);
             inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
             Thread.Sleep(1000);
             inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
             Thread.Sleep(1000);
             Mouse.Click();
             Thread.Sleep(1000);
             //(OpenQA.Selenium.Keys.Enter);
             WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
             Minus.Click();
 */
            //nputSimulator.Mouse.LeftButtonClick();

            /* inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);*/
            //Thread.Sleep(1000);



            //WindowsElement Btn = _window.FindElement(By.Name("Delete"));
            //Btn.Click();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Wonderful Day");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Format Histroy");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Series Friends");
            Thread.Sleep(1000);


            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Volume 4");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Volume #4");
            Thread.Sleep(1000);


            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Earth Place");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Alpha Studio");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Running Speed");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Markup C#<>><><");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("ISBN Standard");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Short Title>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("https://www.zotero.org/");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Delete>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Permanently>>> Delete>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("library Catalog  >>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("8800225544");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("All >>>Rights>>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Extra Over>>>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);


        }

        public void gettitletextforVideorecording()
        {

            string titlename = _window.FindElement(TitleVideoRecording).Text;
            Console.WriteLine("Title of Video Recording>>>" + titlename);

        }

        public void verifyVideorecordingcreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Video Recording Test Sample>>. Video Recording.");
            Titletext.Click();
        }
        public void enterinputsforSoftware()
        {
            Thread.Sleep(1000);
            Keyboard.Type("Software Test Sample>>");

            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);

            Keyboard.Type("Programmer Sample");


            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

           /* WindowsElement Add = _window.FindElementByName("+");
            Add.Click();
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);
            //(OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
            Minus.Click();*/

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Series Title Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Version Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("System Sample Test<>><><");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Place >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Company >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Prog. Language >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("ISBN >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Short title >>> Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("URLzoterosample.com");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Right Sample >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Archive Sample >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Loc in Archive example Extra>>>>");

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Library Catalog example Extra>>>>");

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("123456654321");

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("12/5/67>>>>");

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Extra sample");

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);


            Thread.Sleep(1000);

        }

        public void gettitletextforSoftware()
        {

            string titlename = _window.FindElement(TitleSoftware).Text;
            Console.WriteLine("Title of Software>>>" + titlename);

        }

        public void verifySoftwarecreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Software Test Sample>>. Software.");
            Titletext.Click();  
             
        }


        public void clickStatute()
        {
            int i;
            i = 0;
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

                i = i + 1;
            } while (i < 8);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowUp);

                i = i + 1;
            } while (i < 4);
            Thread.Sleep(2000);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

        }


        public void enterinputsforStatute()
        {

            Thread.Sleep(1000);
            Keyboard.Type("Name Of Act Sample");
            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);


            Thread.Sleep(1000);
            Keyboard.Type("Author Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

           /* WindowsElement Add = _window.FindElementByName("+");
            Add.Click();
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);
            //(OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
            Minus.Click();*/

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Code  Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("1234567899987654321");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Pub. L. 93-406");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Date Enacted Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Pages123  Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Section >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Session >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("History >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Language >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Short title >>> Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("URLzoterosample.com");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("12/5/67>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Rights >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type(" Extra>>>>sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);


        }


        public void gettitletextforStatute()
        {
            string Titletext = _window.FindElement(TitleStatute).Text;
            Console.WriteLine("Title of Statute>>>" + Titletext);

        }

        public void verifyStatutecreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Patent Test Sample>>. Patent.");
            Titletext.Click();
        }

        public void clickPatent()
        {
            /* WindowsElement ComboFileButton = _window.FindElement(NewItemMenu);
             ComboFileButton.Click();
             ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
             ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
             ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
             ComboFileButton.SendKeys(OpenQA.Selenium.Keys.Enter);*/
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);
        }


        public void enterinputsforPatent()
        {
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Thread.Sleep(1000);
            Keyboard.Type("Patent Test Sample>>");

            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Inventor Sample");
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            //WindowsElement Add = _window.FindElementByName("+");
            //Add.Click();
            //Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            /*inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);
            //(OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
            Minus.Click();*//*
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);*/
            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Place Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Country Sample");
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Asignee Sample Test<>><><");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Issuing Authority >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("1234567890");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Pages123  Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Application 1234567890");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Priority 1234567890");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Date Issued>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Reference >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Legal Status >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Language >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Short title >>> Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("URLzoterosample.com");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Accessed>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Rights >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type(" Extra>>>>sample");
            Thread.Sleep(1000);
            Thread.Sleep(2000);

        }

        public void gettitletextforPatent()

        {

            string titlename = _window.FindElement(TitlePatent).Text;
            Console.WriteLine("Title of Patent>>>" + titlename);

        }

        public void verifyPatentcreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Patent Test Sample>>. Patent.");
            Titletext.Click();
        }

        public void clickPodcast()
        {
            /*WindowsElement ComboFileButton = _window.FindElement(NewItemMenu);
            ComboFileButton.Click();
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

            ComboFileButton.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);*/
            Thread.Sleep(1000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(1000);
        }

        public void enterinputsforPodcast()
        {
            Thread.Sleep(1000);
            Keyboard.Type("Podcast Test Sample>>");

            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Podcastor Sample");
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            /* WindowsElement Add = _window.FindElementByName("+");
             Add.Click();
             Thread.Sleep(1000);
             inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
             Thread.Sleep(1000);
             inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
             Thread.Sleep(1000);
             Mouse.Click();
             Thread.Sleep(1000);
             //(OpenQA.Selenium.Keys.Enter);
             WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
             Minus.Click();
             Thread.Sleep(1000);
             Mouse.Click();
             Thread.Sleep(1000);*/


            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Series title Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("123");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("File Type >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Time sample>>>" + DateTime.Now.ToString("3:10 pm"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("URLzoterosample.com");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Accessed>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Language >>> English>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Short title >>> Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Rights >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type(" Extra>>>>sample");
            Thread.Sleep(1000);
            Thread.Sleep(2000);
        }

        public void gettitletextforPodcast()
        {

            string titlename = _window.FindElement(TitlePodcast).Text;
            Console.WriteLine("Title of Podcast>>>" + titlename);

        }

        public void verifyPodcastcreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Podcast Test Sample>>. Podcast.");
            Titletext.Click();
        }
        public void verifyRadiobroadcastcreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Radio Broadcast Test Sample>>. Radio Broadcast.");
            Titletext.Click();
        }


        public void clickPreprint()
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
            Newitem.SendKeys("ZZZZZ");
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

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
        public void enterinputsforPresentation()
        {
            Thread.Sleep(2000);
            Keyboard.Type("Presentation title Sample>>");

            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Presenter");

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

           /* WindowsElement Add = _window.FindElementByName("+");
            Add.Click();
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);
            //(OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
            Minus.Click();*/

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Type Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Type Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Meeting Name Sample");
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

            Keyboard.Type("Language>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Short title >>>Sample>>>");
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



        }
        public void enterinputsforPreprint()
        {
            Thread.Sleep(2000);
            Keyboard.Type("Preprint title Sample>>");

            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Author Program");

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            /*WindowsElement Add = _window.FindElementByName("+");
            Add.Click();
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);
            //(OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
            Minus.Click();

            /*inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);*/

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

        public void gettitletextforPreprint()
        {

            string titlename = _window.FindElement(TitlePreprint).Text;
            Console.WriteLine("Preprint title Sample>>. Preprint." + titlename);

        }

        public void verifyPreprintcreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Preprint title Sample>>. Preprint.");
            Titletext.Click();
        }


        public void ClickPresentation()
        {
            int i;
            i = 0;
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

                i = i + 1;
            } while (i < 8);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowUp);

                i = i + 1;
            } while (i < 8);
            Thread.Sleep(2000);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

        }



        public void GettitletextforPresentation()
        {

            string titlename = _window.FindElement(TitlePresentation).Text;
            Console.WriteLine("Title of Software>>>" + titlename);

        }


        public void clickMap()
        {
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

        }
        public void clickNewspaper()
        {
            Thread.Sleep(1000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(2000);
        }

        public void enterdatainNewspaper()
        {
            Thread.Sleep(2000);
            //Keyboard.Type("Artwork Test Sample>>");
            //WindowsElement TitleNamefortab = _window.FindElement(By.Name("Artwork Test Sample>>. Artwork."));
            InputSimulator inputSimulator = new InputSimulator();
            //TitleNamefortab.SendKeys(OpenQA.Selenium.Keys.Tab);
            //Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            //Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            Thread.Sleep(1000);
            Keyboard.Type("Newspaper Sample");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Author Program");

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            /*WindowsElement Add = _window.FindElementByName("+");
            Add.Click();
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);
            //(OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
            Minus.Click();
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);*/
            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Publication Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Place Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Edition Sample Test<>><><");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type(DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Section>>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("234");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("language  >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Short Title<<<<<>>>>Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("ISSN>>>>> sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("https://github.com/microsoft/WinAppDriver/blob/master/Docs/FAQ.md");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Accessed >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Archive >>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Loc.in Archive >>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Library catalog >>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Call numbers>>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Rights >>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Extra >>>Sample>>>>");
            Thread.Sleep(2000);
        }

        public void gettitletextforNewspaper()
        {
            string titlename = _window.FindElement(TitleNewspaper).Text;
            Console.WriteLine("Title of Newspaper>>>" + titlename);
        }

        public void verifyNewspaperarticlecreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Newspaper Sample. Newspaper Article.");
            Titletext.Click();
        }


        public void enterdatainMap()
        {
            Thread.Sleep(2000);
            Keyboard.Type("MAP Test Sample>>");
            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            //WindowsElement TitleNamefortab = _window.FindElement(By.Name("Artwork Test Sample>>. Artwork."));

            //TitleNamefortab.SendKeys(OpenQA.Selenium.Keys.Tab);
            //Keyboard.Type(OpenQA.Selenium.Keys.Tab);
            //Keyboard.Type(OpenQA.Selenium.Keys.Tab);

            Keyboard.Type("Cartographer Sample");
            Thread.Sleep(2000);

            /*inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.TextEntry("Scott Tiger");*/
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            //WindowsElement Add = _window.FindElementByName("+");
            //Add.Click();

            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            /*Thread.Sleep(1000);
            (OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*[@Name='Delete'])[2]");
            Minus.Click();
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);*/
            Keyboard.Type("Abstract Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Type Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Scale Sample");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Series title Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Edition Sample Test<>><><");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Place>>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Publisher>>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("12/02/1997" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("language  >>> Sample>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("0987654413");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("short title >>>>> sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("https://github.com/microsoft/WinAppDriver/blob/master/Docs/FAQ.md");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("12/02/1997 >>>Sample>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Archive >>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Loc.in Archive >>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Library catalog >>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Call numbers>>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Rights >>>Sample>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Extra >>>Sample>>>>");
            Thread.Sleep(2000);
            WindowsElement Map = _window.FindElement(By.Name("MAP Test Sample>>. Map."));
            Map.Click();
        }

        public void gettitletextforMap()
        {

            string titlename = _window.FindElement(TitleMap).Text;
            Console.WriteLine("Title of Map>>>" + titlename);

        }

        public void verifyMapcreation()
        {
            WindowsElement Titletext = _window.FindElementByName("MAP Test Sample>>. Map.");
            Titletext.Click();
        }

        public void verifyPresentationcreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Tester sample. Presentation.");
            Titletext.Click();
        }





        public void ClickCreatedItem()
        {
            WindowsElement Titletext = _window.FindElementByName("Software Test Sample>>. Software.");
            Titletext.Click();
        }

        public void switchtoFields()
        {

            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.TextEntry("Scott Tiger");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            WindowsElement TwoFields = _window.FindElementByName("Switch to two fields");
            TwoFields.Click();
            Thread.Sleep(3000);
            WindowsElement SingleField = _window.FindElementByName("Switch to single field");
            SingleField.Click();


        }
        public void addDeleteprogrammer()
        {
            /*WindowsElement Titletext = _window.FindElementByName("Software Test Sample>>. Software. Artist Sample");
            Titletext.Click();*/
            Thread.Sleep(2000);
            InputSimulator inputSimulator = new InputSimulator();
            /*inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.TextEntry("Scott Tiger");
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);*/
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            WindowsElement Add = _window.FindElementByName("+");
            Add.Click();
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Mouse.Click();
            Thread.Sleep(1000);
            //(OpenQA.Selenium.Keys.Enter);
            WindowsElement Minus = _window.FindElementByXPath("(//*contains[@Name(),'Delete'])[index][2]");
            Minus.Click();


        }


        public void ClickreatedItem()
        {
            WindowsElement Titletext = _window.FindElementByName("Patent Test Sample>>. Patent.");
            Titletext.Click();
        }

        public void ClickRadioBroadCast()
        {
            int i;
            i = 0;
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

                i = i + 1;
            } while (i < 8);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowUp);

                i = i + 1;
            } while (i < 7);
            Thread.Sleep(2000);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

        }



        public void EnterDataInRadioBroadCast()
        {
            Thread.Sleep(2000);
            Keyboard.Type("Radio Broadcast Test Sample>>");
            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);

            Keyboard.Type("Director Sample");
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
            Keyboard.Type("Program Title");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Episode Number");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Format");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("place");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Network");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Running Time");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Language Sample Test<>><><");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Short Title>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("https://www.zotero.org/");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Accessed");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Archive>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Loc.Archive>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("library Catalog  >>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("0987654413");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("RightSample >>>Sample>>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Sample Extra>>>>");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Thread.Sleep(2000);

        }
        public void GettitletextforRadioBroadcast()
        {

            string titlename = _window.FindElement(TitleRadioBroadCast).Text;
            Console.WriteLine("Title of RadioBroadcast>>>" + titlename);

        }
        public void ClickThesis()
        {
            int i;
            i = 0;
            Thread.Sleep(2000);
            WindowsElement Newitem = _window.FindElement(NewItemMenu);
            Newitem.Click();
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowDown);

                i = i + 1;
            } while (i < 8);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);
            do
            {
                Newitem.SendKeys(OpenQA.Selenium.Keys.ArrowUp);

                i = i + 1;
            } while (i < 3);
            Thread.Sleep(2000);
            Newitem.SendKeys(OpenQA.Selenium.Keys.Enter);

        }


        public void EnterDataInThesis()
        {
            Thread.Sleep(2000);
            Keyboard.Type("Thesis Test Sample>>");
            InputSimulator inputSimulator = new InputSimulator();
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Keyboard.Type("Author Sample");
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
            Keyboard.Type("Type");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("University");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("place");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Date Sample>>>" + DateTime.Now.ToString("M/d/yyyy"));
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("# of Pages");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Language Sample Test<>><><");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Short Title>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("https://www.zotero.org/");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Accessed");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Archive>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Loc.Archive>>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("library Catalog  >>> Sample>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("0987654413");
            Thread.Sleep(1000);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("RightSample >>>Sample>>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
            Keyboard.Type("Sample Extra>>>>");
            Thread.Sleep(1000);

            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(1000);
        }

        public void gettitletextforThesis()
        {

            string titlename = _window.FindElement(TitleMap).Text;
            Console.WriteLine("Title of Thesis" + titlename);

        }
        public void verifyThesiscreation()
        {
            WindowsElement Titletext = _window.FindElementByName("Thesis Test Sample>>. Thesis.");
            Titletext.Click();

        }






    }
}





