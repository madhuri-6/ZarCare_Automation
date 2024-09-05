
namespace TestScripts
{
    public class SubscribeToNewsLetter : Base
    {
        public string classname = "SubscribeToNewsLetter";
 
        [Test]
        public void SubscribeTo_Newsletter()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string OriginalErrorMessage = json["OriginalErrorMessage"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Newsletter Section");
            Home_Page.Validate_HomePage();
            Home_Page.ValidateNewsletterSection();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Enter the Invalid Email");
            Home_Page.EnterEmailToSubscibe();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Click on Subscribe button");
            Home_Page.ClickSubscribeButton();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 4: Verify the error message");
            Home_Page.GetAndValidateNewsletterErrorMessage(OriginalErrorMessage);
            Reports.FlushNode(Reports.childLog);

        }
    }
}
