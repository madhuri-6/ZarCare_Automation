namespace ZarCare_Automation.Test.PageElements
{
    public class Doctor_Profile_Page_Locators : WebdriverSession
    {
        public By By_ProfileHeader = By.XPath("//div[@class='widget about-widget']/h4");
        public IWebElement Web_ProfileHeader => driver.FindElement(By_ProfileHeader);

        public By By_BookingDateHeader_CurrentDate = By.XPath("//div[@class='owl-item active current']/div/h4");
        public IWebElement Web_BookingDateHeader_CurrentDate => driver.FindElement(By_BookingDateHeader_CurrentDate);

        public By By_BookingDateHeader_NextDate = By.XPath("//div[@class='owl-item current active']/div/h4");
        public IWebElement Web_BookingDateHeader_NextDate => driver.FindElement(By_BookingDateHeader_NextDate);

        public By By_BookingDate_ForwardButton = By.XPath("//button[@class='owl-next']/span");
        public IWebElement Web_BookingDate_ForwardButton => driver.FindElement(By_BookingDate_ForwardButton);

        public By By_BookingSlot_Currentday = By.XPath("//div[@class='owl-item active'] //div[@class='c-day-session-slot-blue']");

        public IList<IWebElement> Web_BookingSlot_Currentday => driver.FindElements(By_BookingSlot_Currentday);




        
    }
}
