using System;
using System.IO;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.Extensions;
using QA_Test_WinApp_Poc.cap.helpers;
using QA_Test_WinApp_Poc.cap.utils;

namespace QA_Test_WinApp_Poc.cap.common
{
    public class baseWindow
    {
        public WindowsDriver<WindowsElement> window;
        public baseWindow(WindowsDriver<WindowsElement> window)
        {
            Console.WriteLine("---> Base Window... Constructor..");
            this.window = window;
        }
        public WindowsDriver<WindowsElement> getWindowInstance(String _ApplicationLocation)
        {
            // Window window = null;
            try
            {
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", "C:\\Program Files (x86)\\Zotero\\Zotero.exe");
                options.AddAdditionalCapability("deviceName", "WindowsPc");
                window = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
                Console.WriteLine("---> Windows App launched ... Successfuly.... :) ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception for getWindowInstance : " + ex.Message);
            }

            return window;
        }




        public static String takeScreenShot()
        {
            WindowsDriver<WindowsElement> window;
            String strImagePath = "";
            try
            {
                string strExtentReportScreenShotFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "Reports\\";
                strExtentReportScreenShotFilePath = strExtentReportScreenShotFilePath.Replace(constants.BIN_DEBUG_FOLDER_PATH, "");
                var counter = DateTime.Now.Ticks.ToString();
                strImagePath = strExtentReportScreenShotFilePath + counter + ".png";
                //Takes a screenshot of the entire desktop, and saves it to disk
                Screenshot screenshot = windowsUtils.getWindowInstance().GetScreenshot();




                //window.TakeScreenshot(strExtentReportScreenShotFilePath + counter + ".png", System.Drawing.Imaging.ImageFormat.Png);
                var screenCapture = windowsUtils.getWindowInstance().GetScreenshot();
                screenCapture.SaveAsFile(strImagePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return strImagePath;
        }


        /* public  void takeScreenShot()
        {

           try
            {
                 string fileName = "C:\\Users\\Codoid\\source\\repos\\QA-Test-WinApp-Poc\\QA-Test-WinApp-Poc\\Reports";

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
        */
    }
}


    


 

