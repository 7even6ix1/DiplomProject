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
    public partial class AddServiceForPostFrm : Form
    {
        private string login;
        PostServices model = new PostServices();
        public AddServiceForPostFrm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
                using (GEntities db = new GEntities())
                {
                    List<Posts> posts = db.Posts.ToList();
                    postBox.DataSource = posts;
                    postBox.ValueMember = "Id";
                    postBox.DisplayMember = "Post";
                    postBox.DropDownHeight = 300;
                    List<Service> services = db.Service.ToList();
                    serviceBox.DataSource = services;
                    serviceBox.ValueMember = "Id";
                    serviceBox.DisplayMember = "Name";
                    serviceBox.DropDownHeight = 300;
                }
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

        private void AddServiceForPostFrm_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                model.Post = Convert.ToInt32(postBox.SelectedValue);
                model.Service = Convert.ToInt32(serviceBox.SelectedValue);
                using (GEntities db = new GEntities())
                {
                    db.PostServices.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Услуга должности успешно добавлена!");
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
