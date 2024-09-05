using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.TestScripts
{
    public class WorkWithUsFormFillTest : Base
    {
        public string classname3 = "WorkWithUs";

        [Test]

        public void ValidatWorkWithUuFormFill()
        {
            var json = Json_Reader.GetDataFromJson(classname3);
            string FirstName = json["First_Name"].ToString();
            string LastName = json["Last_Name"].ToString();
            string CellPhoneNumber = json["Cellphone_Number"].ToString();
            string EmailAddress = json["Email_Address"].ToString();
            string CityName = json["City"].ToString();
            string ExpeSuccMesssage = json["Expected_SuccMessage"].ToString();


            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");
            Reports.childLog = Reports.CreateNode("Step 1: Open and validate home page");
            Home_Page.Validate_HomePage();
            Home_Page.ValidateWork_with_us_Click();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate work with us form fill");
            Work_with_us_Pagecs.WorkWithUsFormFill(FirstName,LastName,CellPhoneNumber, EmailAddress,CityName, ExpeSuccMesssage);
            Reports.FlushNode(Reports.childLog);
        }

    }
}
