using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    public string UserID = "";
    public string CourseID = "v";
    protected void Page_Load(object sender, EventArgs e)
    {
        Session[UserID]= Request.QueryString["Namee"];
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = @"Data Source=192.168.1.51;User ID=admin2;Password=Rif27072;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        conn.Open();
        SqlCommand command12 = new SqlCommand();
        SqlCommand command13 = new SqlCommand();
        SqlCommand command14 = new SqlCommand();
        command12.Connection = conn;
        command13.Connection = conn;
        command14.Connection = conn;
        if (Request.QueryString.Count >= 1)
        {
            command13.CommandText = string.Format("INSERT INTO orders(year) VALUES('{0}')", Request.QueryString["Namee"].ToString());
            int affectedrows = command13.ExecuteNonQuery();
        }
    }
}