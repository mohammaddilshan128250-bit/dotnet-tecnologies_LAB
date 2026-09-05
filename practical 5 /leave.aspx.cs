using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Experiment5
{
    public partial class leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                lblusername.Text = Session["username"].ToString();
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            string username =
                "<strong>Username:</strong> " + txtUsername.Text;

            string fromDate =
                "<strong>From Date:</strong> " + txtFromDate.Text;

            string toDate =
                "<strong>To Date:</strong> " + txtToDate.Text;

            string leaveType =
                "<strong>Leave Type:</strong> " +
                ddlLeaveType.SelectedValue;

            string reason =
                "<strong>Leave Reason:</strong> " + txtReason.Text;

            // Display
            label1.Text =
                "Leave Application Submitted Successfully!";

            lblResultUsername.Text = username;
            lblResultFromDate.Text = fromDate;
            lblResultToDate.Text = toDate;
            lblResultLeaveType.Text = leaveType;
            lblResultReason.Text = reason;
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}
