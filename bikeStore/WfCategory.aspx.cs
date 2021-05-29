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
    public partial class WfCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("WfLogin.aspx");
            }
        }
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=BikeStores;Integrated Security=True;");

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into [production].[categories] values(@name)";
            SqlCommand cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update [production].[categories] set [category_name]=@name where [category_id] =@id";
            if (txtId.Text != "")
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
            string query = "delete from [production].[categories] where [category_id] =@id";
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
            string query = "select [category_name] from [production].[categories] where [category_id] =@id";
            if (txtId.Text != "")
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cnx.Open();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if (dt.Rows.Count != 0)
                    txtName.Text = dt.Rows[0][0].ToString();
            }
        }
    }
}