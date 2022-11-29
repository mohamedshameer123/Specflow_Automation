using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;
using QA_Test_WinApp_Poc.cap.common;
using QA_Test_WinApp_Poc.cap.utils;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow.Infrastructure;
using How = SeleniumExtras.PageObjects.How;

namespace QA_Test_WinApp_Poc.zotero.windows
{
    public class ZoteroHomepage : baseWindow
    {
        static WindowsDriver<WindowsElement> _window;

        //WindowsElements(pom)
        public By buttonFile
            => By.Name("File");

        public By buttonEdit
            => By.Name("Edit");

        public By buttonView
        => By.Name("View");

        public By buttonNewitem
        => By.XPath("//Menu[contains(@Name,'New Item')]");

        public By txt_projectAdmin = By.Name("Project Admin");
        public By txt_projectName = By.Name("UNIT1_TTPS");
        public By btn_apply = By.Name("Apply");
        public By btn_ok = By.Name("OK");
        public By txt_system = By.Name("SYSTEM");
        public By txt_settings = By.Name("Settings");
        public By txt_synchronize = By.Name("Synchronize");
        public By txt_operationConsole = By.Name("Operations Console");
        public By chkBox_selectAll = ByAccessibilityId.Name("ChkAll");
        public By btn_sync = By.Name("Sync");
        public By btn_Login = By.XPath("//button[contains(text(),'Log in')]");
        public By txt_EdvHomepage = By.XPath("(//div[normalize-space()='Engineering Viewer - UNIT1_TTP'])[1]");






        public WindowsElement btnFile => _window.FindElement(By.Name("File"));
        static WindowsElement btnEdit => _window.FindElement(By.Name("Edit"));
        static WindowsElement btnView => _window.FindElement(By.Name("View"));

        static WindowsElement menuNewItem => _window.FindElement(By.Name("New Item"));

        //static WindowsElement menuartwork => _window.FindElement(By.Name("Artwork"));

        static WindowsElement itemtype => _window.FindElementByWindowsUIAutomation("item-type-menu");
        static WindowsElement artworktitleinpanel => _window.FindElement(By.Name(". Artwork."));

        static WindowsElement btnNewItem => _window.FindElement(By.Name("New Item"));

        static WindowsElement optionArtwork => _window.FindElementByName("Artwork");

        static WindowsElement txtboxTitle => _window.FindElement(By.Name("Title"));

        By btnArt
            =>
       By.XPath("//*[contains(@Name,'Artwork')]");

        public ZoteroHomepage(WindowsDriver<WindowsElement> window) : base(window)
        {
            Console.WriteLine("---> Enter into Windows Pages Class - COnstructor...");
            _window = this.window;
        }
        public void clickfilebtn()
        {
            Console.WriteLine("Clicking File Button>>>>");
            Console.WriteLine("---> Win Title: " + window.Title);
            btnFile.Click();
            var btnResult = btnFile.GetType();
            Console.WriteLine("Type of File>>>>" + btnResult);
            // _window.FindElement(By.Name("File")).Click();
            Thread.Sleep(2000);
            window.FindElementByName("New Item").Click();
            Thread.Sleep(2000);
           window.FindElement(btnArt).Click();
           var Handles= window.WindowHandles;
            Console.WriteLine("Windows Handles>>>>" + Handles);
            Console.WriteLine("Count of WindowsHAndles>>>>>>" + Handles.Count);



        }

        public void clickEditbtn()
        {
            Console.WriteLine("Clicking EditButton>>>>");
            btnEdit.Click();
            Thread.Sleep(2000);

        }
        public void clickView()
        {
            Console.WriteLine("Clicking ViewButton>>>>");
            btnView.Click();
            Thread.Sleep(2000);

        }

        public void clickNewitemmenu()
        {
            Console.WriteLine("user i click new item menu");
            // Actions move = new Actions(_window);
            //move.MoveToElement(menuNewItem);
            menuNewItem.Click();

        }
       // public void clickartworkmenu()
       // {
         //   Console.WriteLine("user click a artwork menu in new item menu>>>>");
           // menuartwork.Click();

      //  }

        public void verifyitemtype()
        {
            bool Result = artworktitleinpanel.Enabled;
            if (Result.Equals(true))
            {
                Console.WriteLine("Artwork Is created >>>>");
            }
            else
            {
                throw new Exception("failed");
            }

        }

        public void clickNewitembutton()

        {
            Console.WriteLine("Click New Item Button>>>>>");
            btnNewItem.Click();
            Thread.Sleep(1000);

        }

        public void clickArtworkOption()
        {
            Console.WriteLine("Click Artwork Option >>>>>");
           bool ArtworkDis= optionArtwork.Displayed;
            Console.WriteLine("Artwork is displayes>>>>" + ArtworkDis);



        }

        public void entertitle()
        {
            Console.WriteLine("Enter the title >>>>");
            txtboxTitle.SendKeys("Test123");

        }
        public void VerifyNewItembutton()
        {
          bool Result =  btnNewItem.Displayed;
            Console.WriteLine("Verify Element>>>>" + Result);



        }

        public void applicationTitle()
        {

            string Title = window.Title;
            Console.WriteLine("Application Title>>>>>"+Title);
        }


    }
}
