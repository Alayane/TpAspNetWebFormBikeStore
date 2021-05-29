using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bikeStore
{
    public partial class WfAddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("WfLogin.aspx");
            }
        }

       

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                string q = "insert into [sales].[customers] values( @fn,@ln,@ph,@em,@st,@ct,@sta,@zip)";
                SqlCommand cmd = new SqlCommand(q);
                cmd.Parameters.AddWithValue("@fn", txtPrenom.Text);
                cmd.Parameters.AddWithValue("@ln", txtNom.Text);
                cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                cmd.Parameters.AddWithValue("@st", txtAdress.Text);
                cmd.Parameters.AddWithValue("@ct", txtVille.Text);
                cmd.Parameters.AddWithValue("@sta", txtRegion.Text);
                cmd.Parameters.AddWithValue("@zip", txtCode.Text);
                DataAccess.setData(cmd);
                Label1.Text = "client ajoutee";
            }
            
            
            
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WfListCustomers.aspx");
        }
    }
}