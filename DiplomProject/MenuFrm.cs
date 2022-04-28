using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DiplomProject
{
    public partial class MenuFrm : Form
    {
        private string login;
        private string role;
        public MenuFrm(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            SqlDataAdapter sda = new SqlDataAdapter("Select Surname, Name, Patronymic from Workers where Id='" + login + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Post from Workers where Id='" + login + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            string post = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("Select Post from Posts where Id='" + post + "'", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            label1.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() +", "+dt3.Rows[0][0].ToString();
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            WorkersForm workersFrm = new WorkersForm(login);
            this.Hide();
            workersFrm.Show();
        }

        

        private void deliveriesBtn_Click(object sender, EventArgs e)
        {
            DeliveriesFrm deliveriesFrm = new DeliveriesFrm(login);
            this.Hide();
            deliveriesFrm.Show();
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            ClientsFrm clientsFrm = new ClientsFrm(login);
            this.Hide();
            clientsFrm.Show();
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            DetailsFrm detailsFrm = new DetailsFrm(login);
            this.Hide();
            detailsFrm.Show();
        }

        private void worksBtn_Click(object sender, EventArgs e)
        {
            DoneWorksFrm doneWorksFrm = new DoneWorksFrm(login);
            this.Hide();
            doneWorksFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forOperFrm forOperFrm = new forOperFrm(login,role);
            this.Hide();
            forOperFrm.Show();
        }
    }
}
