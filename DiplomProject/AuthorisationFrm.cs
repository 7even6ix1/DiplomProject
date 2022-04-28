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
    public partial class AuthorisationFrm : Form
    {
        private string login;
        private string role;
        public AuthorisationFrm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bigWin_Click(object sender, EventArgs e)
        {

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LoginData where Login='" + loginBox.Text + "' and Password='" + passBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Post from Workers where Id='" + loginBox.Text + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            if(dt.Rows[0][0].ToString()=="1" && dt1.Rows[0][0].ToString()!="17")
            {
                login = loginBox.Text;
                MenuFrm menuFrm = new MenuFrm(login);
                this.Hide();
                menuFrm.Show();
            }
            else if(dt.Rows[0][0].ToString() == "1" && dt1.Rows[0][0].ToString() == "17")
            {
                role = "oper";
                login = loginBox.Text;
                //RequestCreatingFrm requestCreatingFrm = new RequestCreatingFrm(login,role);
                //this.Hide();
                //requestCreatingFrm.Show();
                forOperFrm forOperFrm = new forOperFrm(login,role);
                this.Hide();
                forOperFrm.Show();
            }
            else
            {
                errorBox.Visible = true;
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AuthorisationFrm_Load(object sender, EventArgs e)
        {

        }

        private void seePassBtn_Click(object sender, EventArgs e)
        {
            if(passBox.UseSystemPasswordChar == true)
            {
                passBox.UseSystemPasswordChar = false;
            }
            else
            {
                passBox.UseSystemPasswordChar = true;
            }
        }
    }
}
