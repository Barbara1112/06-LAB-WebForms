using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebForms
{
    public partial class Registracija : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                // provjera postoji li korisnik
                SqlCommand provjera = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE UserName=@u", con);
                provjera.Parameters.AddWithValue("@u", txtUserName.Text);

                int postoji = (int)provjera.ExecuteScalar();

                if (postoji > 0)
                {
                    lblPoruka.Text = "Korisničko ime već postoji!";
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users (UserName, Password, FullName) VALUES (@u,@p,@f)", con);

                cmd.Parameters.AddWithValue("@u", txtUserName.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                cmd.Parameters.AddWithValue("@f", txtFullName.Text);

                cmd.ExecuteNonQuery();
            }

            Response.Redirect("Login.aspx");
        }
    }
}
