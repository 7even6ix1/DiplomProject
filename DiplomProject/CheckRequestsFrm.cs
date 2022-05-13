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
    public partial class CheckRequestsFrm : Form
    {
        private string login;
        private string role;
        public CheckRequestsFrm(string login, string role)
        {
            try
            {
                this.login = login;
                this.role = role;
                InitializeComponent();
                LoadData();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                forOperFrm forOperFrm = new forOperFrm(login, role);
                this.Hide();
                forOperFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                con.Open();
                string query = "Select * from DoneRequestsPred ";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                }
                reader.Close();
                //con.Close();
                foreach (string[] s in data)
                    doneReqGW.Rows.Add(s);

                string query1 = "Select * from UnreleaseReqPred";
                SqlCommand command1 = new SqlCommand(query1, con);
                SqlDataReader reader1 = command1.ExecuteReader();
                List<string[]> data1 = new List<string[]>();
                while (reader1.Read())
                {
                    data1.Add(new string[5]);

                    data1[data1.Count - 1][0] = reader1[0].ToString();
                    data1[data1.Count - 1][1] = reader1[1].ToString();
                    data1[data1.Count - 1][2] = reader1[2].ToString();
                    data1[data1.Count - 1][3] = reader1[3].ToString();
                    data1[data1.Count - 1][4] = reader1[4].ToString();
                }
                reader1.Close();
                con.Close();
                foreach (string[] a in data1)
                    unreleaseGW.Rows.Add(a);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void CheckRequestsFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
