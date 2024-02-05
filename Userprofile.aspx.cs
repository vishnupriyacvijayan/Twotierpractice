using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Twotierpractice
{
    public partial class Userprofile : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string sel = "select Name,Age,Address,Photo from Practice where Id=" + Session["userid"] + "";
            string sel = "SELECT Id, Name, Age, Address, Photo FROM Practice WHERE Id=" + Session["userid"];

            SqlDataReader dr = obj.FN_Reader(sel);
            while (dr.Read())
            {
                Label5.Text = dr["Name"].ToString();
                Label6.Text = dr["Age"].ToString();
                Label7.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }
            //gridview bind using dataset
            DataSet ds = obj.FN_Dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            //gridview bind using dataset
            DataTable dt = obj.FN_Datatable(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}