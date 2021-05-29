using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bikeStore
{
    public partial class WfModifierCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user"] == null)
            {
                Response.Redirect("WfLogin.aspx");
            }

            if (Request.QueryString.Count == 0)
            {
                Response.Redirect("WfListCustomers.aspx");
            }
            if (!Page.IsPostBack)
            {
                txtId.Text=Request.QueryString[0];
                txtPrenom.Text=Request.QueryString[1];
                txtNom.Text=Request.QueryString[2];
                txtPhone.Text=Request.QueryString[3];
                txtEmail.Text=Request.QueryString[4];
                txtAdress.Text=Request.QueryString[5];
                txtVille.Text=Request.QueryString[6];
                txtRegion.Text=Request.QueryString[7];
                txtCode.Text=Request.QueryString[8];

            }
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.Params[0]);
            string q = "update [sales].[customers] set [first_name]=@fn,[last_name]=@ln,[phone]=@ph,[email]=@em,[street]=@st,[city]=@ct,[state]=@sta,[zip_code]=@zip where [customer_id]=@id";

            SqlCommand cmd = new SqlCommand(q);
            cmd.Parameters.AddWithValue("@fn",txtPrenom.Text);
            cmd.Parameters.AddWithValue("@ln",txtNom.Text);
            cmd.Parameters.AddWithValue("@ph",txtPhone.Text);
            cmd.Parameters.AddWithValue("@em",txtEmail.Text);
            cmd.Parameters.AddWithValue("@st",txtAdress.Text);
            cmd.Parameters.AddWithValue("@ct",txtVille.Text);
            cmd.Parameters.AddWithValue("@sta",txtRegion.Text);
            cmd.Parameters.AddWithValue("@zip",txtCode.Text);
            cmd.Parameters.AddWithValue("@id",txtId.Text);
            DataAccess.setData(cmd);
            Label1.Text = "client modifiee";
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WfListCustomers.aspx");
        }
    }
}