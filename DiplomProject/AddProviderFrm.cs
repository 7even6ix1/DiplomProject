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
    public partial class AddProviderFrm : Form
    {
        private string login;
        Provider model = new Provider();
        public AddProviderFrm(string login)
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
                model.Name = nameBox.Text;
                model.Phone = phoneBox.Text;
                model.Email = elBox.Text;
                model.Address = addressBox.Text;
                using (GEntities db = new GEntities())
                {
                    db.Provider.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Поставщик успешно добавлен!");
                    AdminFrm adminFrm = new AdminFrm(login);
                    this.Hide();
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
