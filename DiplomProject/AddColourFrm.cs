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
    public partial class AddColourFrm : Form
    {
        Colours model = new Colours();
        private string login;
        public AddColourFrm(string login)
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
                model.Colour = doorBox.Text;
                model.Description = engineBox.Text;
                using (GEntities db = new GEntities())
                {
                    db.Colours.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Цвет успешно добавлен!");
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

        private void AddColourFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
