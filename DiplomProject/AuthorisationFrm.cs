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
            try
            {
                InitializeComponent();
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

        private void bigWin_Click(object sender, EventArgs e)
        {

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from LoginData where Login='" + loginBox.Text + "' and Password='" + passBox.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataAdapter sdaId = new SqlDataAdapter("Select Worker from LoginData where Login='" + loginBox.Text + "'", con);
                DataTable dtId = new DataTable();
                sdaId.Fill(dtId);
                string workerId = dtId.Rows[0][0].ToString();
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Post from Workers where Id='" + workerId + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt.Rows[0][0].ToString() == "1" && dt1.Rows[0][0].ToString() != "17" && dt1.Rows[0][0].ToString() != "19")
                {
                    login = workerId;
                    MenuFrm menuFrm = new MenuFrm(login);
                    this.Hide();
                    menuFrm.Show();
                }
                else if (dt.Rows[0][0].ToString() == "1" && dt1.Rows[0][0].ToString() == "17")
                {
                    role = "oper";
                    login = workerId;
                    //RequestCreatingFrm requestCreatingFrm = new RequestCreatingFrm(login,role);
                    //this.Hide();
                    //requestCreatingFrm.Show();
                    forOperFrm forOperFrm = new forOperFrm(login, role);
                    this.Hide();
                    forOperFrm.Show();
                }
                else if (dt.Rows[0][0].ToString() == "1" && dt1.Rows[0][0].ToString() == "19")
                {
                    login = workerId;
                    AdminFrm adminFrm = new AdminFrm(login);
                    this.Hide();
                    adminFrm.Show();
                }
                else
                {
                    errorBox.Visible = true;
                }
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

        private void AuthorisationFrm_Load(object sender, EventArgs e)
        {

        }

        private void seePassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passBox.UseSystemPasswordChar == true)
                {
                    passBox.UseSystemPasswordChar = false;
                }
                else
                {
                    passBox.UseSystemPasswordChar = true;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
