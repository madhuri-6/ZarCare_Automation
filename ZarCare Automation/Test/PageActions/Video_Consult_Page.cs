using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageActions
{
    public class Video_Consult_Page : WebdriverSession
    {
            public static Video_Consult_Page_Locators VideoConsultPage = new Video_Consult_Page_Locators();

            public static void Validate_VideoConsultPage()
            {
                Wait.WaitTillPageLoad();
                Generic_Utils.IsElementDisplayed(VideoConsultPage.video_consult_page_button);

                Reports.childLog.Log(Status.Info, "Video Consult page is displayed");
                Generic_Utils.GetScreenshot("Video Consult page screenshot");
            }

            public static void Get_and_Validate_Video_Consult_Page_Title(string Original_Title)
            {

                string Capture_Title = Generic_Utils.getTitle();
                Assert.That(Original_Title, Is.EqualTo(Capture_Title));

                Reports.childLog.Log(Status.Info, "Video Consult page is displayed");
                Generic_Utils.GetScreenshot("Video Consult page screenshot");
        }
    }
}
