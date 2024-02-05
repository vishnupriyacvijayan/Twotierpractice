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
    public partial class RegPage : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string str = "insert into Practice values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + p + "','" + TextBox5.Text + "','" + TextBox6.Text + "')";
            int i = obj.FN_Nonquery(str);
            if (i != 0)
            {
                Label7.Text = "inserted";
            }
        
        
        }
    }
}