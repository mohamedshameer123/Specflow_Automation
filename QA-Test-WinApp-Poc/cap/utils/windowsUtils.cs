using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace QA_Test_WinApp_Poc.cap.utils
{
    public class windowsUtils
    {
        static WindowsDriver<WindowsElement> window;

        static windowsUtils()
        {
            Console.WriteLine("\n ----> Enter into Static block :: WINDOWUtil");

            window = LaunchApp("C:\\Program Files (x86)\\Zotero\\Zotero.exe");
        }
        public static WindowsDriver<WindowsElement> getWindowInstance()
        {
            Console.WriteLine("---> Enter into Get Windows Method...");
            return window;
        }
        public static WindowsDriver<WindowsElement> LaunchApp(String _ApplicationLocation)
        {
            Console.WriteLine("\n Window Util :: Launch App Method....");
            try
            {

                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", _ApplicationLocation);
                options.AddAdditionalCapability("deviceName", "WindowsPc");
                window = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception for Launch App : " + ex.Message);
            }

            return window;
        }
        /*
        public static void takeScreenShot(string fileName, WindowsDriver<WindowsElement> window)
        {
            try
            {
                if (TestContext.Parameters["Env"] != null)
                {
                    var screenshot = window.GetScreenshot();

                    string folderPath = @"\whatever\path";
                    Directory.CreateDirectory(folderPath);

                    var filePath = folderPath + @"\" + fileName;

                    screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Line Failed: " + e.Message);
                Console.WriteLine("** COULD NOT GET SCREENSHOT ***");
            }

        } */
    }
}

