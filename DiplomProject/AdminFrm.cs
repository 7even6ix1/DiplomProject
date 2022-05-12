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
    public partial class AdminFrm : Form
    {
        private string login;
        public AdminFrm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void AdminFrm_Load(object sender, EventArgs e)
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
                label2.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + ", " + dt3.Rows[0][0].ToString();
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

        }

        private void engineBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddEngineFrm addEngineFrm = new AddEngineFrm(login);
                this.Hide();
                addEngineFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void techInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TechInfoFrm techInfoFrm = new TechInfoFrm(login);
                this.Hide();
                techInfoFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void addProviderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddProviderFrm addProviderFrm = new AddProviderFrm(login);
                this.Hide();
                addProviderFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void colourBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddColourFrm addColourFrm = new AddColourFrm(login);
                this.Hide();
                addColourFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void addPostBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddPostFrm addPostFrm = new AddPostFrm(login);
                this.Hide();
                addPostFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
