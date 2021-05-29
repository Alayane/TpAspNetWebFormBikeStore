using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bikeStore
{
    public partial class WfGridView : System.Web.UI.Page
    {
        string cnx = ConfigurationManager.ConnectionStrings["cnxBikeStore"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("WfLogin.aspx");
            }
            getAll();

        }
        private void getAll()
        {
            string q = "select *from production.products ";
            SqlCommand cmd = new SqlCommand(q, new SqlConnection(cnx));
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            gvProducts.DataSource = dr;
            gvProducts.DataBind();
            cmd.Connection.Close();
        }

        protected void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        string query;
        protected void btnFilter_Click(object sender, EventArgs e)
        {
            string id = ddlFilter.SelectedValue;
            
            switch (id)
            {
                case "1":
                        if (txtFilter.Text != "")
                            query = "select *from production.products where model_year=@filter";
                        else
                            return;
                    break;
                case "2":
                        if (txtFilter.Text != "")
                            query = "select *from production.products where brand_id=@filter";
                        else
                            return;
                    break;
                case "3":
                        if (txtFilter.Text != "")
                            query = "select *from production.products where category_id=@filter";
                        else
                            return;
                    break;
            }

            SqlCommand cmd = new SqlCommand(query, new SqlConnection(cnx));
            cmd.Parameters.AddWithValue("@filter", txtFilter.Text);
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            gvProducts.DataSource = dr;
            gvProducts.DataBind();
            cmd.Connection.Close();
        }
    }
}