using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Practical_09_Placement_Dashboard
{
    public partial class Totals : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTotal();
            }
        }

        private void LoadTotal()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PlacementDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT CompanyName, COUNT(*) AS StudentPlaced, AVG(PackageLPA) AS AveragePackage
                    FROM Placements GROUP BY CompanyName;

                    SELECT 
                        COUNT(*) AS TotalPlacements, 
                        COUNT(DISTINCT CompanyName) AS TotalCompanies,
                        AVG(PackageLPA) AS OverallAverage
                    FROM Placements;
                ";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                // First result set → Company-wise statistics
                DataTable dt = new DataTable();
                dt.Load(reader);

                gvTotals.DataSource = dt;
                gvTotals.DataBind();

                // Second result set → Overall statistics
                if (reader.Read())
                {
                    lblTotalPlacements.Text = reader["TotalPlacements"].ToString();
                    lblTotalCompanies.Text = reader["TotalCompanies"].ToString();

                    decimal average = reader["OverallAverage"] == DBNull.Value
                        ? 0 : Convert.ToDecimal(reader["OverallAverage"]);

                    lblOverallAverage.Text = average.ToString("0.00");
                }

                reader.Close();
            }
        }
    }
}
