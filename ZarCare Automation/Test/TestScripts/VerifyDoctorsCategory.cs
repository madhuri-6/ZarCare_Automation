namespace TestScripts
{
    public class VerifyDoctorsCategory : Base
    {
        public string classname = "OurProvider";

        //public static By By_Category_Title { get; private set; }

        [Test]
        public void Verify_Doctors_Category()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doc_category = json["doc_category"].ToString();
            string OriginalCategoryTitle = json["OriginalCategoryTitle"].ToString();
            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Our Providesr Page.");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToOurProvidersPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Validate Our Providers Page");
            Our_Providers_Page.Validate_OurProviderPage();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Select the Doctor Specific Category");
            Our_Providers_Page.ValidateAllCategory_And_Click_Category(doc_category);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 4: Validate if Specific Category Doctors Visible");
            Our_Providers_Page.ValidateSelectedCategory(OriginalCategoryTitle);
            Reports.FlushNode(Reports.childLog);

        }
    }
}
