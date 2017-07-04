using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace gui
{
    class Volunteer
    {
        public int Volunteer_ID { get; set; }
        public int Volunteer_Practice { get; set; }
        public string Volunteer_First_Name { get; set; }
        public string Volunteer_Last_Name { get; set; }
        public string Volunteer_Email { get; set; }
        public string Volunteer_phone { get; set; }
        public string Volunteer_Occupation { get; set; }
        public string Volunteer_Reference { get; set; }
        public int Volunteer_Area_Activity { get; set; }
        public string Volunteer_Employer { get; set; }
        public int Volunteer_Number_Of_Activities { get; set; }

        public Volunteer(DataRow row)
        {
            Volunteer_ID = int.Parse(row["Volunteer_ID"].ToString());
            Volunteer_Practice = int.Parse(row["Volunteer_Practice"].ToString());
            Volunteer_First_Name = row["Volunteer_First_Name"].ToString();
            Volunteer_Last_Name = row["Volunteer_Last_Name"].ToString();
            Volunteer_Email = row["Volunteer_Email"].ToString();
            Volunteer_phone = row["Volunteer_phone"].ToString();
            Volunteer_Occupation = row["Volunteer_Occupation"].ToString();
            Volunteer_Reference = row["Volunteer_Reference"].ToString();
            Volunteer_Area_Activity = int.Parse(row["Volunteer_Area_Activity"].ToString());
            Volunteer_Employer = row["Volunteer_Employer"].ToString();
            Volunteer_Number_Of_Activities = int.Parse(row["Volunteer_Number_Of_Activities"].ToString());
        }
        public Volunteer() { }
    }
}