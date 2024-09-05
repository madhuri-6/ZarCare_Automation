using AventStack.ExtentReports.Gherkin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageActions
{
    public class Work_with_us_Pagecs : WebdriverSession
    {
        public static Work_with_Us_pageLocators WorkWithUs = new Work_with_Us_pageLocators();

        public static void Validate_Work_with_Us()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(WorkWithUs.By_PageHeader_element);

            Reports.childLog.Log(Status.Info, "Work with us page displayed");
            Generic_Utils.GetScreenshot("Work with us page screenshot");
        }

        public static void WorkWithUsFormFill(string FirstName,string LastName, string CellPhoneNumber,string EmailAddress,string CityName, string ExpeSuccMesssage)
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(WorkWithUs.By_PageHeader_element);

            Reports.childLog.Log(Status.Info, "Work with us form displayed");
            Generic_Utils.GetScreenshot("Work with us form screenshot");

            WorkWithUs.Web_FirstName_Ele.SendKeys(FirstName);

            WorkWithUs.Web_Surname_ele.SendKeys(LastName);

            WorkWithUs.Web_CellPhone_Ele.SendKeys(CellPhoneNumber);

           WorkWithUs.Web_EmailFiled_ele.SendKeys(EmailAddress);

            WorkWithUs.Web_CityName_ele.SendKeys(CityName);

            Generic_Utils.DropwoenHandle_with_text(WorkWithUs.Web_SpecilizationDrpDown_ele, "Dentist");

            Thread.Sleep(1000);

            Generic_Utils.Dropdown_Handle_With_Value(WorkWithUs.Web_provinceDrpDown_ele, "Western Cape");

            Thread.Sleep(1000);

            Generic_Utils.DropDownHandle_with_index(WorkWithUs.Web_CurrentLocation_ele, 1);

            Thread.Sleep(1000);

            WorkWithUs.Web_SubBtn_ele.Click();
            

            Wait.WaitTillPageLoad();
            Wait.ElementIsVisible(WorkWithUs.By_workIwthUsFormSuccessMessage, 4);

            string ActualSuccMessage= WorkWithUs.Web_WorkIwthUsFormSuccessMessage_ele.Text;

            Assert.AreEqual(ExpeSuccMesssage, ActualSuccMessage);

            
            Reports.childLog.Log(Status.Info, "Work with us form displayed");
            Generic_Utils.GetScreenshot("Work with us form fill filled");
        }

    }
}
