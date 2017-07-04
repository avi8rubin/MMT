using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gui
{
    public partial class Default : System.Web.UI.Page
    {
        DB myDB = new DB();

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                myDB.DatabaseName = "mmt_db";
                myDB.IsConnect();
                Console.WriteLine("DB Connect OK!");
                Volunteer TestVolunteer = new Volunteer();
                TestVolunteer.Volunteer_Practice = 1;
                TestVolunteer.Volunteer_First_Name = "first name";
                TestVolunteer.Volunteer_Last_Name = "last name";
                TestVolunteer.Volunteer_Email = "a@a.com";
                TestVolunteer.Volunteer_phone = "052-5782802";
                TestVolunteer.Volunteer_Occupation = "sport";
                TestVolunteer.Volunteer_Reference = "sss";
                TestVolunteer.Volunteer_Area_Activity = 1;
                TestVolunteer.Volunteer_Employer = "boss";
                TestVolunteer.Volunteer_Number_Of_Activities = 0;

                Boolean check_insert = myDB.InsetNewVolunteer(TestVolunteer);
                TextBox1.Text = "Update of " + TestVolunteer.Volunteer_First_Name + "is " + check_insert;

                myDB.Close();
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
        }
    }
}