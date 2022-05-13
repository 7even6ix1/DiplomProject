using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProject
{
    public partial class forOperFrm : Form
    {
        private string login;
        private string role;
        public forOperFrm(string login,string role)
        {
            try
            {
                this.login = login;
                this.role = role;
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

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RequestCreatingFrm requestCreatingFrm = new RequestCreatingFrm(login, role);
                this.Hide();
                requestCreatingFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void forOperFrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (role == "oper")
                {
                    backBtn.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckRequestsFrm checkRequestsFrm = new CheckRequestsFrm(login, role);
                this.Hide();
                checkRequestsFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MenuFrm menuFrm = new MenuFrm(login);
            this.Hide();
            menuFrm.Show();
        }
    }
}
