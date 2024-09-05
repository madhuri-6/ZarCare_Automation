using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageActions
{
    public class Blog_Page : WebdriverSession
    {
        public static Blog_Page_Locators BlogPage = new Blog_Page_Locators();

        public static void Validate_BlogPage()
        {
            Generic_Utils.winHandle();
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(BlogPage.By_ZarcareBlog);

            Reports.childLog.Log(Status.Info, "Blog Page is displayed");
            Generic_Utils.GetScreenshot("Blog Page screenshot");

        }

        public static void Get_And_Validate_OurProvider_Title(string Original_Title)
        {
            string Capture_Title = Generic_Utils.getTitle();
            Assert.That(Original_Title, Is.EqualTo(Capture_Title));

            Reports.childLog.Log(Status.Info, "Validate Blog page");
            Generic_Utils.GetScreenshot("Blog Page screenshot");
        }
    }
}
