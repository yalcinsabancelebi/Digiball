using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace Digiball
{

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        public static SqlConnection? conn;
        public static SqlDataReader? dr;
        public static SqlCommand? getAllData;
        public static SqlCommand? getTeamId;
        public static Main main = new Main();

        public static string? TeamId;
        public static string? TeamName;
        public static string? TeamLogo;
        public static string? Stadium;
        public static string? EstDate;
        public static string? StaffCount;
        public static string? Budget;
        public static string? Country;

        public static Dictionary<int, string[]> players = new Dictionary<int, string[]>();
<<<<<<< HEAD
        public static List<string> teams = new List<string>();
=======
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void startbtn_Click(object sender, EventArgs e)
        {
            Main.ManagerName = nametbx.Text;
            Main.ManagerSurname = surnametbx.Text;
            Main.ManagerAge = agetbx.Text;

            Main.TeamName = TeamName;
            Main.StadiumName = Stadium;
            Main.EstDate = EstDate;
            Main.TotalStaff = StaffCount;
            Main.Country = Country;
            Main.Logo = TeamLogo;

            fillPlayerData();
            main.Show();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Db"].ToString();
            SqlCommand query = new("select TeamName from Teams", conn);

            try
            {
                conn.Open();
                query.ExecuteNonQuery();
                SqlDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
<<<<<<< HEAD
                    teams.Add(dr["TeamName"].ToString());
=======
>>>>>>> fd53677075a9f715ca932c6bb62448e4bb2c0061
                    teamcbx.Items.Add(dr["TeamName"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void teamcbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Db"].ToString();
            SqlCommand query = new("select * from Teams where TeamName = @teamname", conn);

            query.Parameters.AddWithValue("@teamname", teamcbx.Text);

            try
            {
                conn.Open();
                query.ExecuteNonQuery();
                SqlDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    TeamId = dr["TeamId"].ToString();
                    TeamLogo = dr["TeamLogo"].ToString();
                    TeamName = dr["TeamName"].ToString();
                    Stadium = dr["Stadium"].ToString();
                    EstDate = dr["TeamFoundationYear"].ToString();
                    StaffCount = dr["TeamTotalStaff"].ToString();
                    Budget = string.Format(new CultureInfo("de-DE"), "{0:c}", dr["TeamBudget"]);
                    Country = dr["TeamCountry"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }

            panel1.Visible = true;
            teamlogo.Image = Image.FromFile(TeamLogo);
            teamnamelbl.Text = TeamName;
            stadiumlbl.Text = Stadium;
            estlbl.Text = EstDate;
            staffcountlbl.Text = StaffCount;
            budgetlbl.Text = Budget;
            countrylbl.Text = Country;
        }



        public void fillPlayerData()
        {


            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Db"].ToString();
            SqlCommand query = new("SELECT * FROM Players INNER JOIN PlayerStats ON Players.PlayerId = PlayerStats.PlayerId where Players.TeamId = @teamid", conn);
            query.Parameters.AddWithValue("@teamid", TeamId.ToString());

            try
            {
                conn.Open();
                query.ExecuteNonQuery();
                SqlDataReader dr = query.ExecuteReader();
                while (dr.Read())
                {
                    players.Add(Convert.ToInt32(dr["PlayerId"]), new string[] {
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString(),
                        dr[5].ToString(),
                        dr[6].ToString(),
                        dr[7].ToString(),
                        dr[8].ToString(),
                        dr[9].ToString(),
                        dr[10].ToString(),
                        dr[11].ToString(),
                        dr[12].ToString(),
                        dr[15].ToString(),
                        dr[16].ToString(),
                        dr[17].ToString(),
                        dr[18].ToString(),
                        dr[19].ToString(),
                        dr[20].ToString(),
                        dr[21].ToString(),
                        dr[22].ToString(),
                        dr[23].ToString(),
                        dr[24].ToString(),
                        dr[25].ToString(),
                        dr[26].ToString(),
                        dr[27].ToString(),
                        dr[28].ToString()
                    });
                }
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}