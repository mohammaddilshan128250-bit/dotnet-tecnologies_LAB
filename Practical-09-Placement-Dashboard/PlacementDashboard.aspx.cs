using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Practical_09_Placement_Dashboard
{
    public partial class PlacementDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDashboard();
            }
        }

        private void LoadDashboard()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PlacementDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT
                        (SELECT COUNT(*) FROM Students) AS TotalStudents,
                        (SELECT COUNT(*) FROM Students WHERE IsPlaced = 1) AS PlacedStudents,
                        (SELECT COUNT(*) FROM Students WHERE IsPlaced = 0) AS NotPlaced,
                        (SELECT AVG(PackageLPA) FROM Placements) AS AveragePackage
                ";

                SqlCommand cmd = new SqlCommand(query, con);
                
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblTotal.Text = reader["TotalStudents"].ToString();
                    lblPlaced.Text = reader["PlacedStudents"].ToString();
                    lblNotPlaced.Text = reader["NotPlaced"].ToString();

                    decimal averagePackage = reader["AveragePackage"] == DBNull.Value
                        ? 0 : Convert.ToDecimal(reader["AveragePackage"]);

                    lblAvgPackage.Text = averagePackage.ToString("0.00");
                }

                reader.Close();
            }
        }
    }
}
