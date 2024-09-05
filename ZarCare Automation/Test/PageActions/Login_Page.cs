using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageActions
{
    public class Login_Page : WebdriverSession
    {
        public static LoginPage_Locators Login_pages=new LoginPage_Locators();

        public static void Validate_LoginPage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(Login_pages.by_LogiPageHeader);

            Reports.childLog.Log(Status.Info, "Login page displayed");
            Generic_Utils.GetScreenshot("Login page screenshot");
            
        }



    }
}
