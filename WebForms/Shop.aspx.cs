using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Shop : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UcitajProizvode();
            }
        }

        void UcitajProizvode()
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnSpremi_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Products (Name, Description) VALUES (@n,@d)", con);

                cmd.Parameters.AddWithValue("@n", txtNaziv.Text);
                cmd.Parameters.AddWithValue("@d", txtOpis.Text);

                cmd.ExecuteNonQuery();
            }

            txtNaziv.Text = "";
            txtOpis.Text = "";

            UcitajProizvode();
        }
    }
}
