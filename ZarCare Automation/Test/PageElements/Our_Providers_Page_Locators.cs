namespace ZarCare_Automation.Test.PageElements
{
    public class Our_Providers_Page_Locators : WebdriverSession
    {
        public By By_SearchHeader = By.Id("//div[@class='card-header open-search']/h4");
        public IWebElement Web_SearchHeader => driver.FindElement(By_SearchHeader);
        
        public By By_Doctor_SearchBox = By.Id("txtSearchString");
        public IWebElement Web_Doctor_SearchBox => driver.FindElement(By_Doctor_SearchBox);

        public By By_Doctor_SearchButton = By.XPath("//div[@class='btn-search']/button");
        public IWebElement Web_Doctor_SearchButton => driver.FindElement(By_Doctor_SearchButton);

        public By By_Doctor_List = By.XPath("//div[@class='card mb-4 history-list']/div");
        public IWebElement Web_Doctor_List => driver.FindElement(By_Doctor_List);

        
        public By By_Doctor_Name = By.XPath("//div[@class='card mb-4 history-list']/div //h4[@class='doc-name']/a");

        public IWebElement Web_Doctor_Name => driver.FindElement(By_Doctor_Name);

        //Doctors Category Locators

        public By By_AllDoctors_CategoryList = By.XPath("//ul[@class='filter-list']/li");
        public IList<IWebElement> Web_AllDoctors_CategoryList => driver.FindElements(By_AllDoctors_CategoryList);

        public By By_Select_Specific_Category = By.XPath("//a[contains(text(),'Counsellor')]");
        public IWebElement Web_Select_Specific_Category => driver.FindElement(By_Select_Specific_Category);

        public By By_Category_Title = By.XPath("//h5[@class='doc-department']/i");
        public IWebElement Web_Category_Title => driver.FindElement(By_Category_Title);

        public By By_Category_Clear_Button = By.XPath("//h4[@class='position-relative']/button");
        public IWebElement Web_Category_Clear_Button => driver.FindElement(By_Category_Clear_Button);





        public IList<IWebElement> Web_Doctor_Name = driver.FindElements(By.XPath("//div[@class='card mb-4 history-list']/div //h4[@class='doc-name']/a"));

        public By By_DrJashanKumr= By.XPath("//a[contains(text(),'Jashan Kumar')]");

        public IWebElement Web_DrJashan_kumar_Ele=> driver.FindElement(By_DrJashanKumr);

        public By By_BookOppntbtn = By.XPath("//a[@class='apt-btn book-appointment']");
        public IWebElement Web_BookOptn_ele => driver.FindElement(By_BookOppntbtn);


        public IList<IWebElement> BookOtpbtnList = driver.FindElements(By.XPath("//div[@class='clinic-booking']//a[contains(@class, 'apt-btn book-appointment collapsed') or contains(@class, 'apt-btn book-appointment')]")); //a[@class='apt-btn book-appointment']

       



}
