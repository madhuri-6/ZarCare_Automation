using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageActions
{
    public class ContactUs_Page : WebdriverSession
    {
       
    
        public static ContactUsPageLocatores contact_Us= new ContactUsPageLocatores();

        public static void Validate_contact_Us_link()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(contact_Us.By_PageHeaderElement);

            Reports.childLog.Log(Status.Info, "Contact us page displayed");
            Generic_Utils.GetScreenshot("Contact us page screenshot");
        }


    }
}
