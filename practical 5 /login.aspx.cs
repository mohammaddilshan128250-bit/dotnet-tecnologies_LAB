using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Experiment5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btlogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "1234")
            {
                Session["username"] = txtusername.Text.ToString();
                Response.Redirect("leave.aspx");
            }
            else
            {
                lblmessage.Text = "Invalid password.";
            }
        }
    }
}
