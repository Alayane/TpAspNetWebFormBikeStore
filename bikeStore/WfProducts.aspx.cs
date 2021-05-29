using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace bikeStore
{
    public partial class WfProducts : System.Web.UI.Page
    {
        string cnx = ConfigurationManager.ConnectionStrings["cnxBikeStore"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("WfLogin.aspx");
            }
            if (!Page.IsPostBack)
            {
                getBrand();
                getCategory();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string q = "insert into production.products values(@name,@brand,@category,@year,@prix)";
            SqlCommand cmd = new SqlCommand(q, new SqlConnection(cnx));
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@brand", drBrand.SelectedValue);
            cmd.Parameters.AddWithValue("@category", drCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@year", txtYear.Text);
            cmd.Parameters.AddWithValue("@prix",Decimal.Parse(txtPrice.Text));
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string q = "update production.products set product_name=@name,brand_id=@brand,category_id=@cat,model_year=@year,list_price=@price where product_id=@id";
            SqlCommand cmd = new SqlCommand(q, new SqlConnection(cnx));
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@brand", drBrand.SelectedValue);
            cmd.Parameters.AddWithValue("@cat", drCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@year", txtYear.Text);
            cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text));
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string q = "delete from production.products where product_id=@id";
            SqlCommand cmd = new SqlCommand(q, new SqlConnection(cnx));
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string q = "select *from production.products where product_id=@id";
            SqlCommand cmd = new SqlCommand(q, new SqlConnection(cnx));
            if (txtId.Text != "")
            {
                cmd.Parameters.AddWithValue("@id",txtId.Text);
                cmd.Connection.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr.GetString(1);
                    drBrand.SelectedValue = dr.GetInt32(2).ToString();
                    drCategory.SelectedValue = dr.GetInt32(3).ToString();
                    txtYear.Text = dr.GetInt16(4).ToString();
                    txtPrice.Text = dr.GetDecimal(5).ToString();
                }
                cmd.Connection.Close();

            }

        }

        private void getBrand()
        {
            string q = "select brand_id,brand_name from production.brands";
            SqlConnection con = new SqlConnection(cnx);
            SqlCommand cmd = new SqlCommand(q,con);
            con.Open();
            drBrand.DataSource = cmd.ExecuteReader();
            drBrand.DataTextField = "brand_name";
            drBrand.DataValueField = "brand_id";
            drBrand.DataBind();
            con.Close();
        }
        private void getCategory()
        {
            string q = "select category_id,category_name from production.categories";
            SqlConnection con = new SqlConnection(cnx);
            SqlCommand cmd = new SqlCommand(q, con);
            con.Open();
            drCategory.DataSource = cmd.ExecuteReader();
            drCategory.DataTextField = "category_name";
            drCategory.DataValueField = "category_id";
            drCategory.DataBind();
            con.Close();
        }
    }
}