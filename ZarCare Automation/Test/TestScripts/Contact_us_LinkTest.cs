using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.TestScripts
{
    public class Contact_us_LinkTest: Base
    {
        [Test]

        public void ValidateContactUsLink()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
            Home_Page.Validate_HomePage();
           // Home_Page.ValidateWork_with_us_link();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate & Navigate to Contact us page");
            Home_Page.ConstactUsLinkClick();
            ContactUs_Page.Validate_contact_Us_link();
            Reports.FlushNode(Reports.childLog);
        }  
    }
}
