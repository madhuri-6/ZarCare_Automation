using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.TestScripts
{
    public class Work_With_usTest :Base
    {

        [Test]

        public void ValidateWorkWithUsLink()
        {
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
            Home_Page.Validate_HomePage();
            Home_Page.ValidateWork_with_us_Click();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate & Navigate to work with us page");
            Work_with_us_Pagecs.Validate_Work_with_Us();
            Reports.FlushNode(Reports.childLog);

        }
    }
}
