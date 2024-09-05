using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageElements
{
    public class LoginPage_Locators : WebdriverSession
    {
        public By by_LogiPageHeader = By.XPath("//div[@class='intro']/h2");

        public IWebElement Web_LoginPageHeaderText => driver.FindElement(by_LogiPageHeader);

        public By By_LogPageheaderText = By.XPath("//h3[@class='font-16']");

        public IWebElement Web_LPHadertext=>driver.FindElement(By_LogPageheaderText);



    }
}
