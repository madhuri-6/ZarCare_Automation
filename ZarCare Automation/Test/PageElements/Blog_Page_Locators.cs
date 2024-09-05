using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageElements
{
    public class Blog_Page_Locators : WebdriverSession
    {
        public By By_ZarcareBlog = By.XPath("//div[@class='col-md-12 mt-3 mb-4']/h1");
        public IWebElement Web_ZarcareBlog => driver.FindElement(By_ZarcareBlog);
    }
}
