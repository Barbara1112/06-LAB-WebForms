using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p", con);

                cmd.Parameters.AddWithValue("@u", txtUserName.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                int broj = (int)cmd.ExecuteScalar();

                if (broj > 0)
                {
                    Response.Redirect("Shop.aspx");
                }
                else
                {
                    lblPoruka.Text = "Pogrešno korisničko ime ili lozinka!";
                }
            }
        }
    }
}
