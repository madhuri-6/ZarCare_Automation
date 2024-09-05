using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.TestScripts
{
    public class NewLatterEmailMessageTest : Base
    {

        public string classname2 = "NewLatterEmailMessage";
        [Test]

        public void NewLatterEmailMessageValidation()
        {
            var json = Json_Reader.GetDataFromJson(classname2);
            string ActualMessage = json["Actual_Message"].ToString();
            string News_LatterEmail = json["NewsLatterEmail"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate news latter email success message");
            Home_Page.EnterNewslatterEmail(News_LatterEmail);
            Home_Page.Validate_NewLatterEmailMessage(ActualMessage);
            Reports.FlushNode(Reports.childLog);

        }



    }
}
