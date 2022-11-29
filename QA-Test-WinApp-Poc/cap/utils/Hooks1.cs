using QA_Test_WinApp_Poc.cap.common;
using QA_Test_WinApp_Poc.cap.helpers;
using System.Reflection;
using System;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.MarkupUtils;
using OpenQA.Selenium.Appium.Windows;

namespace QA_Test_WinApp_Poc.cap.utils
{
    [Binding]
    public sealed class Hooks1
    {
        //Global Variable for Extent report
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        static WindowsDriver<WindowsElement> window;
        



        private ITestRunner testRunner1;


        [BeforeTestRun]
        public static void InitializeReport()
        {
            string strExtentReportXMLFilePath = System.AppDomain.CurrentDomain.BaseDirectory + "Cap\\";
            strExtentReportXMLFilePath = strExtentReportXMLFilePath.Replace("\\bin\\Debug", "");
            strExtentReportXMLFilePath = strExtentReportXMLFilePath + "extent-config.xml";
            Console.WriteLine("\n >> >> strExtentReportXMLFilePath: " + strExtentReportXMLFilePath);
            DateTime dateAndTime = DateTime.Now;

            string strReportsFolderpath = System.AppDomain.CurrentDomain.BaseDirectory + constants.REPORTS_FOLDER_PATH;
            strReportsFolderpath = strReportsFolderpath.Replace(constants.BIN_DEBUG_FOLDER_PATH, "");
            Console.WriteLine("\n >> >> Final Report PAth :: : " + strReportsFolderpath);

            var htmlReporter = new ExtentHtmlReporter(strReportsFolderpath + "ExtentReport.html");

            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            htmlReporter.LoadConfig(strExtentReportXMLFilePath);

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }



        [AfterStep]
        public void InsertReportingSteps()
        {
            try
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepInstance.StepDefinitionKeyword.ToString();

                PropertyInfo pInfo = typeof(ScenarioContext).GetProperty(nameof(ScenarioContext.Current.ScenarioExecutionStatus), BindingFlags.Public | BindingFlags.Instance);

                MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
                object TestResult = getter.Invoke(ScenarioContext.Current, null);

                MediaEntityModelProvider mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath
                    (baseWindow.takeScreenShot()).Build();


                if (ScenarioContext.Current.TestError == null)
                {
                    if (stepType == "Given")
                    {
                        var test = scenario.CreateNode<Given>("Given " + ScenarioStepContext.Current.StepInfo.Text)
                        .Log(Status.Pass, MarkupHelper.CreateLabel("", ExtentColor.Green));
                        test.Log(Status.Pass, "");
                    }
                    else if (stepType == "When")
                    {
                        var testWhen = scenario.CreateNode<When>("When " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Pass, MarkupHelper.CreateLabel("", ExtentColor.Green));
                        testWhen.Log(Status.Pass, "");
                    }
                    else if (stepType == "Then")
                    {
                        var testThen = scenario.CreateNode<Then>("Then " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Pass, MarkupHelper.CreateLabel("", ExtentColor.Green));
                        testThen.Log(Status.Pass, "", mediaModel);
                    }
                    else if (stepType == "And")
                    {
                        var testAnd = scenario.CreateNode<And>("And " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Pass, MarkupHelper.CreateLabel("", ExtentColor.Green));
                        testAnd.Log(Status.Pass, "");

                    }
                }
                else if (ScenarioContext.Current.TestError != null)
                {
                    String strStackTrace = ScenarioContext.Current.TestError.Message;
                    if (stepType == "Given")
                    {
                        var test = scenario.CreateNode<Given>("Given " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Fail, MarkupHelper.CreateLabel(strStackTrace, ExtentColor.Red));
                        test.Log(Status.Fail, "", mediaModel);
                        test.Log(Status.Pass, "");
                    }
                    else if (stepType == "And")
                    {
                        var test = scenario.CreateNode<And>("And " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Fail, MarkupHelper.CreateLabel(strStackTrace, ExtentColor.Red));
                        test.Log(Status.Fail, "", mediaModel);
                    }
                    else if (stepType == "When")
                    {
                        var test = scenario.CreateNode<When>("When " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Fail, MarkupHelper.CreateLabel(strStackTrace, ExtentColor.Red));
                        test.Log(Status.Fail, "", mediaModel);
                    }
                    else if (stepType == "Then")
                    {
                        var test = scenario.CreateNode<Then>("Then " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Fail, MarkupHelper.CreateLabel(strStackTrace, ExtentColor.Red));
                        test.Log(Status.Fail, "", mediaModel);
                    }
                }
                

                // Else Finel Skip and pending Parts
                else
                 {
                     if (stepType == "Given")
                         scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Log(Status.Skip, MarkupHelper.CreateLabel("", ExtentColor.Blue));
                     else if (stepType == "When")
                         scenario.CreateNode<When>("When " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Skip, MarkupHelper.CreateLabel("", ExtentColor.Blue));
                     else if (stepType == "Then")
                         scenario.CreateNode<Then>("Then " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Skip, MarkupHelper.CreateLabel("", ExtentColor.Blue));
                     else if (stepType == "And")
                     {
                         scenario.CreateNode<And>("And " + ScenarioStepContext.Current.StepInfo.Text).Log(Status.Skip, MarkupHelper.CreateLabel("", ExtentColor.Blue));
                         scenario.Log(Status.Fail, ScenarioContext.Current.TestError.Message.ToString());
                     }
                 } 

                //Pending Status
                if (TestResult.ToString() == "StepDefinitionPending")
                {
                    if (stepType == "Given")
                        scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                    else if (stepType == "When")
                        scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                    else if (stepType == "Then")
                        scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                    else if (stepType == "And")
                        scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n >>----> Exception2: " + e.StackTrace);
            }

        }

        [BeforeScenario]
        public void Initialize()
        {
            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void getAfterScenario()
        {
            Console.WriteLine("After scenario" + ScenarioContext.Current.ScenarioExecutionStatus);
        }




    }
}