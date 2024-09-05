using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageActions
{
    public class Work_With_Us : WebdriverSession
    {
        public static Work_With_Us_Locators WorkWithUs = new Work_With_Us_Locators();
        public static void ValidateWorkWithUsPage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(WorkWithUs.By_ValidateWorkWithUsPage);

            Reports.childLog.Log(Status.Info, "Work With US Page is displayed");
            Generic_Utils.GetScreenshot("Work With Us Screenshot");
        }
        public static void FillWorkWIthUsForm()
        {
            WorkWithUs.Web_FirstName.SendKeys("Work");
            WorkWithUs.Web_SurName.SendKeys("Data");
            WorkWithUs.Web_CellphoneNumber.SendKeys("305205205");
            WorkWithUs.Web_EmailAddress.SendKeys("publicbook5@gmail.com");

            Generic_Utils.Dropdown_Handle_With_Value(WorkWithUs.Web_Profession_List, "23");
            Generic_Utils.Dropdown_Handle_With_Index(WorkWithUs.Web_Province_List, 5);
            WorkWithUs.Web_City_Name.SendKeys("Capetown");
            Generic_Utils.Dropdown_Handle_With_Text(WorkWithUs.Web_Offer_Services, "Nursing Home or Hospice");

            Reports.childLog.Log(Status.Info, "Work With Us Form is Filled Successfully");
            Generic_Utils.GetScreenshot("Work With Us Screenshot");

        }

        public static void SubmitButton()
        {
            Thread.Sleep(1500);
            WorkWithUs.Web_Submit_Button_WorkWithUs.Click();
        }

        public static void Get_And_Validate_ErrorMessage_WorkWithUs(string WorkWithUsErrorMessage)
        {
            Thread.Sleep(2000);
            string Capture_ErrorMessage = Generic_Utils.getText(WorkWithUs.Web_WorkWithUs_Error_Message);
            Assert.That(WorkWithUsErrorMessage, Is.EqualTo(Capture_ErrorMessage));

            Reports.childLog.Log(Status.Info, "Error Message is displayed when user enters existing detials in form");
            Generic_Utils.GetScreenshot("Work With Us Form Error Message Screenshot");
        }

    }
}
