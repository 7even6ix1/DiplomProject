using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProject
{
    public partial class DeliveriesFrm : Form
    {
        private string login;
        public DeliveriesFrm(string login)
        {
            this.login = login;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            con.Open();
            string query = "Select * from DeliveryInfoPred ";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            con.Close();
            foreach (string[] s in data)
                dataGridView.Rows.Add(s);
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddDeliveriesFrm addDeliveriesFrm = new AddDeliveriesFrm(login);
            this.Hide();
            addDeliveriesFrm.Show();
        }

        private void DeliveriesFrm_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MenuFrm menuFrm = new MenuFrm(login);
            this.Hide();
            menuFrm.Show();
        }
    }
}
