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
    public partial class AddServiceFrm : Form
    {
        Service model = new Service();
        private string login;
        public AddServiceFrm(string login)
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
                AdminFrm adminFrm = new AdminFrm(login);
                this.Hide();
                adminFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                model.Name = postBox.Text;
                model.Cost = Convert.ToDecimal(salaryBox.Text);
                using (GEntities db = new GEntities())
                {
                    db.Service.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Услуга успешно добавлена!");
                    this.Hide();
                    AdminFrm adminFrm = new AdminFrm(login);
                    adminFrm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
