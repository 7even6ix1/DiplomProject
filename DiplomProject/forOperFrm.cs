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
            this.login = login;
            this.role = role;
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

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            RequestCreatingFrm requestCreatingFrm = new RequestCreatingFrm(login,role);
            this.Hide();
            requestCreatingFrm.Show();
        }

        private void forOperFrm_Load(object sender, EventArgs e)
        {
            if(role=="oper")
            {
                backBtn.Visible = false;
            }
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            CheckRequestsFrm checkRequestsFrm = new CheckRequestsFrm(login,role);
            this.Hide();
            checkRequestsFrm.Show();
        }
    }
}
