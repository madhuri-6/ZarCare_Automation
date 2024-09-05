namespace TestScripts
{
    public class BookAppointments : Base
    {
        public string classname = "BookAppointments";

        [Test]
        public void Book_Appointments()
        {
            var json = Json_Reader.GetDataFromJson(classname);
            string doctorName = json["Doctor_Name"].ToString();
            string appointmentDate = json["Appointment_Date"].ToString();
            string appointmentTime = json["Appointment_Time"].ToString();

            Generic_Utils.Initilize_URL(Properties.environment.ToLower(), "Platform");

            Reports.childLog = Reports.CreateNode("Step 1: Validate Home Page and Navigate to Our Provider Page");
            Home_Page.Validate_HomePage();
            Home_Page.NavigateToConsultNow();
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 2: Search doctor");
            Our_Providers_Page.Validate_OurProviderPage();
            Our_Providers_Page.Search_Doctor(doctorName);
            Our_Providers_Page.FetchDoctorFromList(doctorName);
            Reports.FlushNode(Reports.childLog);

            Reports.childLog = Reports.CreateNode("Step 3: Validate Doctor Profile and Book Appointment");
            Doctor_Profile_Page.ValidateDoctorProfile();
            Doctor_Profile_Page.BookAppointment(appointmentDate, appointmentTime);
            Reports.FlushNode(Reports.childLog);

        }
        
    }
}