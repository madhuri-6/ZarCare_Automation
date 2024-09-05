using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageElements
{
    public class ContactUsPageLocatores : WebdriverSession
    {
        public By By_PageHeaderElement = By.XPath("//h1[contains(text(),'Contact Us')]");
        public IWebElement Web_PageHeaderText => driver.FindElement(By_PageHeaderElement);

    }
}
