using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace gui.Models
{
    public class Workshop
    {
        public int WorkShop_ID { get; set; }
        public int WorkShop_Status { get; set; }
        public DateTime WorkShop_Date { get; set; }
        public string WorkShop_Teacher_Name { get; set; }
        public string WorkShop_Teacher_phone { get; set; }
        public string WorkShop_Teacher_Second_phone { get; set; }
        public string WorkShop_Teacher_Email { get; set; }
        public int WorkShop_School_ID { get; set; }
        public int WorkShop_Primary_Volunteer { get; set; }
        public int WorkShop_Volunteer1 { get; set; }
        public int WorkShop_Volunteer2 { get; set; }
        public int WorkShop_Volunteer3 { get; set; }
        public int WorkShop_Number_Of_StudentPredicted { get; set; }
        public int WorkShop_Number_Of_StudentAmount { get; set; }
        public Boolean WorkShop_Is_Projector { get; set; }
        public Boolean WorkShop_Did_Preparation { get; set; }
        public int WorkShop_Number_Of_Computers { get; set; }
        public Boolean WorkShop_Is_HighschoolImpact { get; set; }
        public Boolean WorkShop_Is_FridayPossible { get; set; }
        public Boolean WorkShop_Is_Seniors_Coming { get; set; }
        public Workshop() { }
        public Workshop(DataRow row)
        {
            WorkShop_ID = int.Parse(row["WorkShop_ID"].ToString());
            WorkShop_Status = int.Parse(row["WorkShop_Status"].ToString());
            WorkShop_Date = DateTime.Parse(row["WorkShop_Date"].ToString());
            WorkShop_Teacher_Name = row["WorkShop_Teacher_Name"].ToString();
            WorkShop_Teacher_phone = row["WorkShop_Teacher_phone"].ToString();
            WorkShop_Teacher_Second_phone = row["WorkShop_Teacher_Second_phone"].ToString();
            WorkShop_Teacher_Email = row["WorkShop_Teacher_Email"].ToString();
            WorkShop_School_ID = int.Parse(row["WorkShop_School_ID"].ToString());
            WorkShop_Primary_Volunteer = int.Parse(row["WorkShop_Primary_Volunteer"].ToString()); //Check Null
            WorkShop_Volunteer1 = int.Parse(row["WorkShop_Volunteer1"].ToString());
            WorkShop_Volunteer2 = int.Parse(row["WorkShop_Volunteer2"].ToString());
            WorkShop_Volunteer3 = int.Parse(row["WorkShop_Volunteer3"].ToString());
            WorkShop_Number_Of_StudentPredicted = int.Parse(row["WorkShop_Number_Of_StudentPredicted"].ToString());
            WorkShop_Number_Of_StudentAmount = int.Parse(row["WorkShop_Number_Of_StudentAmount"].ToString());
            WorkShop_Is_Projector = Boolean.Parse(row["WorkShop_Is_Projector"].ToString());
            WorkShop_Did_Preparation = Boolean.Parse(row["WorkShop_Did_Preparation"].ToString());
            WorkShop_Number_Of_Computers = int.Parse(row["WorkShop_Number_Of_Computers"].ToString());
            WorkShop_Is_HighschoolImpact = Boolean.Parse(row["WorkShop_Is_HighschoolImpact"].ToString());
            WorkShop_Is_FridayPossible = Boolean.Parse(row["WorkShop_Is_FridayPossible"].ToString());
            WorkShop_Is_Seniors_Coming = Boolean.Parse(row["WorkShop_Is_Seniors_Coming"].ToString());
        }
    }
}