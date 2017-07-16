using gui.Models;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            //start the page with data
            ErrorMsg.InnerText = "";


            DB db = new DB();
            db.IsConnect();
            //Get From DB all area - and insert to html
            List<ListItem> result = db.GetAllAreas();
            if(CheckBoxList1.Items.Count<1)
            {
                foreach (ListItem item in result)
                {
                    CheckBoxList1.Items.Add(item);
                }
            }

            //page signin - get all data from html
            if (Page.IsPostBack)
            {
                
                string firstnamevalue = firstname.Text.ToString();
                string lastnamevalue  = lastname.Text.ToString(); 
                string emailvalue     = email.Text.ToString();
                string phonevalue     = phone.Text.ToString();
                string occupation     = DropDownList1.SelectedValue.ToString();
                string refernce       = DropDownList2.SelectedValue.ToString();
                string employe = employee.Text.ToString();
                foreach ( ListItem item in CheckBoxList1.Items)
                {
                    if(item.Selected)
                    {
                        string value = item.Text.ToString();
                    }

                }
                ErrorMsg.InnerText = "ההרשמה התבצעה בהצלחה";
                // string preferedarea   = CheckBoxList1.SelectedItem.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get Form elements and reset them
            firstname.Text = "";
            lastname.Text  = "";
            email.Text = "";
            employee.Text = "";
            phone.Text = "";
            DropDownList1.SelectedIndex = 0;
            string refernce = DropDownList2.SelectedValue.ToString();
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    item.Selected = false;
                }

            }
        }
 
    }
}