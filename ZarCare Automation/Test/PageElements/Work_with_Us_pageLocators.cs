using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarCare_Automation.Test.PageElements
{
    public class Work_with_Us_pageLocators : WebdriverSession
    {

        public By By_PageHeader_element = By.XPath("//div[@class='heading']");
        public IWebElement Web_HeaderText => driver.FindElement(By_PageHeader_element);

        public By By_FirstNameField = By.XPath("//input[@id='txtFName']");

        public IWebElement Web_FirstName_Ele => driver.FindElement(By_FirstNameField);

        public By By_SurnameField = By.XPath("//input[@id='txtSName']");

        public IWebElement Web_Surname_ele=> driver.FindElement(By_SurnameField);

        public By By_CellPhoneField = By.XPath("//input[@id='txtContactNo']");

        public IWebElement Web_CellPhone_Ele=> driver.FindElement(By_CellPhoneField);

        public By By_EmailFiled = By.XPath("//input[@id='txtEmail']");

        public IWebElement Web_EmailFiled_ele=> driver.FindElement(By_EmailFiled);

        public By By_SpecilizationDrpDown = By.XPath("//select[@id='drpspecialization']");

        public IWebElement Web_SpecilizationDrpDown_ele=> driver.FindElement(By_SpecilizationDrpDown);

        public By By_provinceDrpDown = By.XPath("//select[@id='ddProvince']");

        public IWebElement Web_provinceDrpDown_ele=> driver.FindElement(By_provinceDrpDown);

        public By By_CityName = By.XPath("//input[@id='txtCity']");

        public IWebElement Web_CityName_ele => driver.FindElement(By_CityName);

        public By By_CurrentLocation = By.XPath("//select[@id='txtCurrentP']");

        public IWebElement Web_CurrentLocation_ele=> driver.FindElement(By_CurrentLocation);

        public By By_SubBtn = By.XPath("//button[@id='btnSubmit']");

        public IWebElement Web_SubBtn_ele=> driver.FindElement(By_SubBtn);

        public By By_workIwthUsFormSuccessMessage = By.XPath("//div[@class='modal-content']//span[@id='spnConfirmSuccess']");  
        public IWebElement Web_WorkIwthUsFormSuccessMessage_ele=> driver.FindElement(By_workIwthUsFormSuccessMessage);

        public By by_MessagePopupModel = By.XPath("//div[@class='modal-content']");

        public IWebElement Web_MessagePopupModel_ele=> driver.FindElement(by_MessagePopupModel);





    }

}
