
﻿namespace ZarCare_Automation.Test.PageElements
{
    public class Work_With_Us_Locators : WebdriverSession
    {
        public By By_Work_With_Us_Text = By.XPath("//div[@class='heading']/h1");
        public IWebElement Web_Work_With_Us_Text => driver.FindElement(By_Work_With_Us_Text);

        public By By_Submit_Button = By.XPath("//*[@id='btnSubmit']");
        public IWebElement Web_Submit_Button => driver.FindElement(By_Submit_Button);

        public By By_FirstName_Textbox = By.Id("//input[@id='txtFName']");
        public IWebElement Web_FirstName_Textbox => driver.FindElement(By_FirstName_Textbox);

        public By By_SurName_Textbox = By.Id("//input[@id='txtSName']");
        public IWebElement Web_SurName_Textbox => driver.FindElement(By_SurName_Textbox);

        public By By_ContactNo_Textbox = By.Id("//input[@id='txtContactNo']");
        public IWebElement Web_ContactNo_Textbox => driver.FindElement(By_ContactNo_Textbox);

        public By By_Email_Textbox = By.Id("//input[@id='txtEmail']");
        public IWebElement Web_Email_Textbox => driver.FindElement(By_Email_Textbox);


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


        public By By_Province_List = By.Id("//select[@id='ddProvince']");
        public IWebElement Web_Province_List => driver.FindElement(By_Province_List);

        public By By_City_Textbox = By.Id("//input[@id='txtCity']");
        public IWebElement Web_City_Textbox => driver.FindElement(By_City_Textbox);

        public By By_WorkPlace_List = By.Id("//select[@id='txtCurrentP']");
        public IWebElement Web_WorkPlace_List => driver.FindElement(By_WorkPlace_List);

        public By By_FirstName_Error = By.XPath("//span[@id='firstNameError']");
        public IWebElement Web_FirstName_Error => driver.FindElement(By_FirstName_Error);

        public By By_SurName_Error = By.XPath("//span[@id='lastNameError']");
        public IWebElement Web_SurName_Error => driver.FindElement(By_SurName_Error);

        public By By_CellPhone_Error = By.XPath("//span[@id='phoneNoError']");
        public IWebElement Web_CellPhone_Error => driver.FindElement(By_CellPhone_Error);

        public By By_Email_Error = By.XPath("//span[@id='emailError']");
        public IWebElement Web_Email_Error => driver.FindElement(By_Email_Error);

        public By By_Profession_Error = By.XPath("//span[@id='drpspecializationError']");
        public IWebElement Web_Profession_Error => driver.FindElement(By_Profession_Error);

        public By By_Province_Error = By.XPath("//span[@id='provinceError']");
        public IWebElement Web_Province_Error => driver.FindElement(By_Province_Error);

        public By By_City_Error = By.XPath("//span[@id='cityError']");
        public IWebElement Web_City_Error => driver.FindElement(By_City_Error);

        public By By_Current_WorkPlace_Error = By.XPath("//span[@id='CurrentWorkPlaceError']");
        public IWebElement Web_Current_WorkPlace_Error => driver.FindElement(By_Current_WorkPlace_Error);

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
