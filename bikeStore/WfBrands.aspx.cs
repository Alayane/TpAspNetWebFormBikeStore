using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace bikeStore
{
    public partial class WfBrands : System.Web.UI.Page
    {

        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=BikeStores;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("WfLogin.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into [production].[brands] values(@name)";
            SqlCommand cmd = new SqlCommand(query,cnx);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                txtError.Text = "marque ajouté";
                txtName.Text = "";
                
            }
            catch (Exception ex)
            {
                txtError.Text = ex.Message;
                txtError.ForeColor = Color.Red;
            }
            

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update [production].[brands] set [brand_name]=@name where [brand_id] =@id";
            if (txtId.Text!="")
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
           
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "delete from [production].[brands] where [brand_id] =@id";
            if (txtId.Text != "")
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            DataTable dt = new DataTable();
            string query = "select [brand_name] from [production].[brands] where [brand_id] =@id";
            if (txtId.Text != "")
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cnx.Open();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if(dt.Rows.Count!=0)
                txtName.Text = dt.Rows[0][0].ToString();
            }
        }

        
    }
}