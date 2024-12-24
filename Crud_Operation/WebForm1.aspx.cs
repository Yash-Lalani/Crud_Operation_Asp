using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud_Operation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string s = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ASP_PROJECT\\Crud_Operation\\Crud_Operation\\App_Data\\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();

        }
        void getcon()
        {
            con = new SqlConnection(s);
            con.Open();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("insert into stud_tbl values(Username,Email,Address)values('" + txtName + "','" + txtEmail + "','" + txtAddress + "')", con);
            cmd.ExecuteNonQuery();

        }
    }
}