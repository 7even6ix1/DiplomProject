using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProject
{
    public partial class RequestCreatingFrm : Form
    {
        private string login;
        private int numFrm=2;
        private string role;
        private int b;

        ClientRequests model = new ClientRequests();
        public RequestCreatingFrm(string login, string role)
        {
            try
            {
                this.login = login;
                this.role = role;
                InitializeComponent();
                using (GEntities db = new GEntities())
                {
                    List<ClientCars> clientCars = db.ClientCars.ToList();
                    carBox.DataSource = clientCars;
                    carBox.DisplayMember = "GosNumber";
                    carBox.ValueMember = "Id";
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
                if (role == null)
                {
                    MenuFrm menuFrm = new MenuFrm(login);
                    this.Hide();
                    menuFrm.Show();
                }
                else if (role == "oper")
                {
                    forOperFrm forOperFrm = new forOperFrm(login, role);
                    this.Hide();
                    forOperFrm.Show();
                }
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
                //model.Id = b;
                model.CarId = (int)carBox.SelectedValue;
                model.Description = descriptBox.Text;
                model.CreateDateTime = DateTime.Now;
                model.Done = false;
                using (GEntities db = new GEntities())
                {
                    db.ClientRequests.Add(model);
                    if (role == null)
                    {
                        MenuFrm menuFrm = new MenuFrm(login);
                        this.Hide();
                        menuFrm.Show();
                    }
                    else if (role == "oper")
                    {
                        forOperFrm forOperFrm = new forOperFrm(login, role);
                        this.Hide();
                        forOperFrm.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddClientsCarFrm addClientsCarFrm = new AddClientsCarFrm(login, numFrm);
                this.Hide();
                addClientsCarFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddClientFrm addClientFrm = new AddClientFrm(login, numFrm);
                this.Hide();
                addClientFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void RequestCreatingFrm_Load(object sender, EventArgs e)
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
                label1.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + ", " + dt3.Rows[0][0].ToString();
                //SqlDataAdapter sda1 = new SqlDataAdapter("Select top 1 * from ClientRequests order by Id DESC", con);
                //DataTable dt1 = new DataTable();
                //sda1.Fill(dt1);
                //string a = dt1.Rows[0][0].ToString();
                //b = Convert.ToInt32(a) + 1;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
