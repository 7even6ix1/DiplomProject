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
    public partial class AddWorkFrm : Form
    {
        int b = 0;
        Works model = new Works();
        DoneRequests model1 = new DoneRequests();
        private string login;
        public AddWorkFrm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
                using (GEntities db = new GEntities())
                {
                    List<ClientCars> clientCars = db.ClientCars.ToList();
                    carBox.DataSource = clientCars;
                    carBox.DisplayMember = "GosNomer";
                    carBox.ValueMember = "Id";
                    List<Service> services = db.Service.ToList();
                    serviceBox.DataSource = services;
                    serviceBox.DisplayMember = "Name";
                    serviceBox.ValueMember = "Id";
                    List<Workers> workers = db.Workers.ToList();
                    workerBox.DataSource = workers;
                    workerBox.DisplayMember = "Surname";
                    workerBox.ValueMember = "Id";
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

        private void AddWorkFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Works order by Id DESC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string a = dt.Rows[0][0].ToString();
                b = Convert.ToInt32(a) + 1;
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
                if (reqBox.Text == null)
                {
                    model.Id = b;
                    model.Car = (int)carBox.SelectedValue;
                    model.Service = (int)serviceBox.SelectedValue;
                    model.Worker = (int)workerBox.SelectedValue;
                    model.StartDate = startDate.Value;
                    model.StartTime = startTime.Text;
                    model.ExDate = exDate.Value;
                    model.ExTime = exTime.Text;
                    model.Comment = descriptBox.Text;
                    using (GEntities db = new GEntities())
                    {
                        db.Works.Add(model);
                        db.SaveChanges();
                        MessageBox.Show("Работа успешно сохранена!");
                        this.Hide();
                        DoneWorksFrm doneWorksFrm = new DoneWorksFrm(login);
                        doneWorksFrm.Show();
                    }
                }
                if (reqBox.Text != null)
                {
                    model.Id = b;
                    model.Car = (int)carBox.SelectedValue;
                    model.Service = (int)serviceBox.SelectedValue;
                    model.Worker = (int)workerBox.SelectedValue;
                    model.StartDate = startDate.Value;
                    model.StartTime = startTime.Text;
                    model.ExDate = exDate.Value;
                    model.ExTime = exTime.Text;
                    model.Comment = descriptBox.Text;
                    model1.IdWorks = b;
                    model1.IdRequest = Convert.ToInt32(reqBox.Text);
                    using (GEntities db = new GEntities())
                    {
                        db.Works.Add(model);
                        db.DoneRequests.Add(model1);
                        db.SaveChanges();
                        MessageBox.Show("Работа успешно сохранена!");
                        this.Hide();
                        DoneWorksFrm doneWorksFrm = new DoneWorksFrm(login);
                        doneWorksFrm.Show();
                    }
                }
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
                DoneWorksFrm doneWorksFrm = new DoneWorksFrm(login);
                this.Hide();
                doneWorksFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
