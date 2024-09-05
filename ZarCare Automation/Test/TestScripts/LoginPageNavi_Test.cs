using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.TestScripts
{
    public class LoginPageNavi_Test : Base
    {
        [Test]

        public void ValidateLoginBtnNavigation()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate & Navigate to login page");
            Home_Page.LoginBtnClick();
            Login_Page.Validate_LoginPage();
            Reports.FlushNode(Reports.childLog);
            
        }
    }
}
