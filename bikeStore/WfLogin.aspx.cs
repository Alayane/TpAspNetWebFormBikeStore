using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bikeStore
{
    public partial class WfLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session["user"]= null;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
          
                string q = "select * from [dbo].[user] where email =@email and password=@pw";
                SqlCommand cmd = new SqlCommand(q);
                cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                cmd.Parameters.AddWithValue("@pw", TxtPassword.Text);
                DataTable dt= DataAccess.getData(cmd);
                if (dt.Rows.Count > 0)
                {
                    Session["user"] = dt.Rows[0][1].ToString();
                    Response.Redirect("WfMenu.aspx");
                }
                else
                {
                    lblError.Text = "donnees eronee";
                }

            }
        }
    }
}