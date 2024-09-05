using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageElements
{
    public class Work_With_Us_Locators : WebdriverSession
    {
        public By By_ValidateWorkWithUsPage = By.XPath("//div[@class='heading']/h1");
        public IWebElement Web_ValidateWorkWithUsPage => driver.FindElement(By_ValidateWorkWithUsPage);

        //PersonalDetails

        public By By_FirstName = By.Id("txtFName");
        public IWebElement Web_FirstName => driver.FindElement(By_FirstName);

        public By By_SurName = By.Id("txtSName");
        public IWebElement Web_SurName => driver.FindElement(By_SurName);

        public By By_CellphoneNumber = By.Id("txtContactNo");
        public IWebElement Web_CellphoneNumber => driver.FindElement(By_CellphoneNumber);

        public By By_EmailAddress = By.Id("txtEmail");
        public IWebElement Web_EmailAddress => driver.FindElement(By_EmailAddress);

        //OpportunityDetails

        public By By_Profession_List = By.XPath("//select[@id='drpspecialization']");
        public IWebElement Web_Profession_List => driver.FindElement(By_Profession_List);

        public By By_Province_List = By.XPath("//select[@id='ddProvince']");
        public IWebElement Web_Province_List => driver.FindElement(By_Province_List);

        public By By_City_Name = By.Id("txtCity");
        public IWebElement Web_City_Name => driver.FindElement(By_City_Name);

        public By By_Offer_Services = By.XPath("//select[@id='txtCurrentP']");
        public IWebElement Web_Offer_Services => driver.FindElement(By_Offer_Services);

        public By By_Submit_Button_WorkWithUs = By.Id("btnSubmit");
        public IWebElement Web_Submit_Button_WorkWithUs => driver.FindElement(By_Submit_Button_WorkWithUs);

        //SubmitForm Error Message

        public By By_WorkWithUs_Error_Message = By.XPath("//span[@id='emailcheckerror']");
        public IWebElement Web_WorkWithUs_Error_Message => driver.FindElement(By_WorkWithUs_Error_Message);

        //Comment Added
    }
}
