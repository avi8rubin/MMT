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
        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Form_Test.aspx",true);
        }

    }
}