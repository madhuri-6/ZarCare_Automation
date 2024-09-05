using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageElements
{
    public class Video_Consult_Page_Locators : WebdriverSession
    {
        public By video_consult_page_button = By.XPath("//a[@class='link primary-button cta']");
        public IWebElement Video_Consult_Page_Button => driver.FindElement(video_consult_page_button);

        /*
        public By video_consult_link = By.XPath("//ul[@class='top-menu']/li[2]");
        public IWebElement Video_Consult_Link => driver.FindElement(video_consult_link);
        */
    }
}
