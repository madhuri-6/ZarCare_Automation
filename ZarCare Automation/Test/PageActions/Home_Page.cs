using AngleSharp.Dom;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ZarCare_Automation.Test.PageActions
{
    public class Home_Page : WebdriverSession
    {
        public static Home_Page_Locators HomePage = new Home_Page_Locators();

        public static Work_with_Us_pageLocators WorkWith_us = new Work_with_Us_pageLocators();

        public static ContactUsPageLocatores ContactUs = new ContactUsPageLocatores();

        public static Our_Providers_Page_Locators OurProvPage= new Our_Providers_Page_Locators();

        public static void Validate_HomePage()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(HomePage.By_BannerText);

            Reports.childLog.Log(Status.Info, "Home page is displayed");
            Generic_Utils.GetScreenshot("Home page screenshot");
        }

        public static void NavigateToConsultNow()
        {
            HomePage.Web_ConsultNow_Button.Click();
        }


        //VideoConsultPage Actions
        public static void NavigateToVideoConsultPage()
        {
            HomePage.Video_Consult_Link.Click();
        }

        //SubscribeToNewletter Actions

        public static void ValidateNewsletterSection()
        {
            Wait.WaitTillPageLoad();
            Generic_Utils.ScrollToBottom(); // How to use scroll to element here 
            Generic_Utils.IsElementDisplayed(HomePage.By_SubscribeToNewsletter_h2);

            Reports.childLog.Log(Status.Info, "Newsletter Section is displayed");
            Generic_Utils.GetScreenshot("Newsletter Section screenshot");
        }
        public static void EnterEmailToSubscibe()
        {
            HomePage.Web_EmailInputBox.SendKeys("myemail@....");

            Reports.childLog.Log(Status.Info, "Entering the Invalid Email Id");
            Generic_Utils.GetScreenshot("Invalid Email screenshot");
        }

        public static void ClickSubscribeButton()
        {
            HomePage.Web_EmailSubscribeButton.Click();
        }

        public static void GetAndValidateNewsletterErrorMessage(string OrigialErrorMessage)
        {
            string errorMessage = Generic_Utils.getText(HomePage.Web_InvalidEmailErrorMessage);
            Assert.That(OrigialErrorMessage, Is.EqualTo(errorMessage));

            Reports.childLog.Log(Status.Info, "Validating the error message");
            Generic_Utils.GetScreenshot("Error message screenshot");
        }

        //BlogPageVerification
        public static void NavigateToBlogPage()
        {
            HomePage.Web_BlogPage_Link.Click();
        }

        //WorkWithUs

        public static void NavigateToWorkWithUsPage()
        {
            HomePage.Web_WorkWithUs.Click();
        }

        //Our Providers Page

        public static void NavigateToOurProvidersPage()
        {
            HomePage.Web_OurProvidersPage.Click();

        public static void ValidateWork_with_us_Click()
        {
            HomePage.Web_Work_with_Us_Btn.Click();

            
        }

        public static void ConstactUsLinkClick()
        {
            Generic_Utils.ScrollToBottom();
               
             HomePage.Web_Contact_us_link.Click();
  
        }

        public static void LoginBtnClick()
        {
            HomePage.Web_login_Btn.Click();

            var Windows= driver.WindowHandles;

            driver.SwitchTo().Window(Windows[1]);
            
        }

        public static void EnterNewslatterEmail(string NewsLatterEmail) 
        {
            Generic_Utils.ScrollToElement(HomePage.Web_NewLatterEmailEle);

            HomePage.Web_NewLatterEmailEle.SendKeys(NewsLatterEmail);  

            HomePage.Web_NewsLatterSubBtnEle.Click();
            Thread.Sleep(1000);

        }
        public static void Validate_NewLatterEmailMessage(string ActualMessage)
        {
           

            string ExpectedMessage = driver.FindElement(HomePage.by_NewsEmailSuccessMessage).Text;

            Assert.AreEqual(ActualMessage, ExpectedMessage);
            Reports.childLog.Log(Status.Info, "success message displayed");
            Generic_Utils.GetScreenshot("Success Message screenshot");

        }
        public static void OurProviderBtnClick()
        {
            HomePage.Web_Our_providerBtn.Click();

            Wait.WaitTillPageLoad();
            Generic_Utils.IsElementDisplayed(OurProvPage.By_SearchHeader);



        }
    }
}
