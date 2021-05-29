using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bikeStore
{
    public partial class WfListCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("WfLogin.aspx");
            }
            if (!Page.IsPostBack)
            {
                chargerClients();

            }

        }

        private void chargerClients()
        {
            string q = "select * from [sales].[customers]";
            SqlCommand cmd = new SqlCommand(q);
            gvClients.DataSource = DataAccess.getData(cmd);
            gvClients.DataBind();
        }

        protected void gvClients_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id = int.Parse( gvClients.Rows[i].Cells[0].Text);
            string q = "delete from [sales].[customers] where [customer_id]=@id";
            SqlCommand cmd = new SqlCommand(q);
            cmd.Parameters.AddWithValue("@id", id);
            DataAccess.setData(cmd);
            chargerClients();
        }

        protected void btnAjoute_Click(object sender, EventArgs e)
        {
            Response.Redirect("WfAddCustomer.aspx");
        }
    }
}