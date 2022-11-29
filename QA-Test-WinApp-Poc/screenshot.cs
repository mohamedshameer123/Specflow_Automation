using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using Microsoft.Extensions.Options;
using OpenQA.Selenium.Support.Extensions;

namespace QA_Test_WinApp_Poc
{
    public class screenshot
    {
        protected WindowsDriver<WindowsElement> window;
         
        AppiumOptions options = new AppiumOptions();

        public void screen()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", "C:\\Program Files (x86)\\Zotero\\Zotero.exe");
            options.AddAdditionalCapability("deviceName", "WindowsPc");
            window = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
            Console.WriteLine("---> Windows App launched ... Successfuly.... :) ");
            window.TakeScreenshot();
        }


    }

}
