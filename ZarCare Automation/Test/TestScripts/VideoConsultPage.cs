namespace TestScripts
{
    public class VideoConsultPage : Base
    {
        public string classname = "VideoConsultPage";
        

        [Test]
        public void Video_Consult_Page1()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string Original_Title = json["Original_Title"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Our Video Consult Page");
            Home_Page.Validate_HomePage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search the Title of Video Consult Page");
            Home_Page.NavigateToVideoConsultPage();
            Video_Consult_Page.Get_and_Validate_Video_Consult_Page_Title(Original_Title);
            Reports.FlushNode(Reports.childLog);

        }
    }
}
