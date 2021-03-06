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

        private void MenuFrm_Load(object sender, EventArgs e)
        {
            try
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
                label1.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + ", " + dt3.Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                WorkersForm workersFrm = new WorkersForm(login);
                this.Hide();
                workersFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        

        private void deliveriesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DeliveriesFrm deliveriesFrm = new DeliveriesFrm(login);
                this.Hide();
                deliveriesFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ClientsFrm clientsFrm = new ClientsFrm(login);
                this.Hide();
                clientsFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DetailsFrm detailsFrm = new DetailsFrm(login);
                this.Hide();
                detailsFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void worksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DoneWorksFrm doneWorksFrm = new DoneWorksFrm(login);
                this.Hide();
                doneWorksFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
