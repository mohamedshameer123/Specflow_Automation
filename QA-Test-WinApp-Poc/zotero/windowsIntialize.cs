using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Windows;
using QA_Test_WinApp_Poc.cap.utils;
using QA_Test_WinApp_Poc.zotero.windows;
using TechTalk.SpecFlow.Infrastructure;

namespace QA_Test_WinApp_Poc.zotero
{
    public class windowsIntialize
    {
        private WindowsDriver<WindowsElement> window;
        public ZoteroHomepage zoterohomepage;
        public newZoteroHomepage newzoterohomepage;
        //public RadioBroadcast radiobroadcast;
        public File file;
        public ZoteroMainPage zoteromainpage;
        public HomepageZotero homepageZotero;
        public ScenarioClass scenarioClass;


        public windowsIntialize()
        {
            Console.WriteLine("---> Enter into WindwInitialize... Constructor");
            window = windowsUtils.getWindowInstance();
            initPages();
        }
        private void initPages()
        {
            Console.WriteLine("---> Enter into Init Pages...");
            zoterohomepage =new ZoteroHomepage(window); 
            newzoterohomepage=new newZoteroHomepage(window);
            //radiobroadcast =new RadioBroadcast(window);
            zoteromainpage= new ZoteroMainPage(window);
            homepageZotero = new HomepageZotero(window);
            scenarioClass = new ScenarioClass(window);
        }
    }
}
