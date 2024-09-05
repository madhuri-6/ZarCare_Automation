using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScripts
{
    public class BlogPageVerification : Base
    {
        public string classname = "BlogPageVerification";
        //public static Blog_Page_Locators Test_Locator = new Blog_Page_Locators();

        [Test]

        public void Blog_Page1()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Original_Title"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);


            Reports.childLog = Reports.CreateNode("Step 2: Navigate to Zarcare Blog Page");
            Blog_Page.Validate_BlogPage();
            Home_Page.NavigateToBlogPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Validate the Blog Page with Title");
            //Thread.Sleep(3000);// added because the page was loading and no screen shot taken: not working
            Blog_Page.Get_And_Validate_OurProvider_Title(Original_Title);
            //Console.WriteLine(Test_Locator.Web_ZarcareBlog.Text);
            Reports.FlushNode(Reports.childLog);

        }
    }
}
