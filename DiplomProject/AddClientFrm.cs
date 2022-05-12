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
    
    public partial class AddClientFrm : Form
    {
        private string login;
        private string role;
        int b = 0;
        private int numFrm;
        Clients model = new Clients();
        public AddClientFrm(string login,int numFrm)
        {
            try
            {


                this.login = login;
                this.numFrm = numFrm;
                Clients model = new Clients();
                InitializeComponent();
                using (GEntities db = new GEntities())
                {
                    List<Genders> genders = db.Genders.ToList();
                    genderBox.DataSource = genders;
                    genderBox.DisplayMember = "Gender";
                    genderBox.ValueMember = "Id";
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

        private void AddClientFrm_Load(object sender, EventArgs e)
        {
            try
            {
            SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Clients order by Id DESC", con);
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
           try {
                if (numFrm == 1)
                {
                    model.Id = b;
                    model.Surname = surnameBox.Text;
                    model.Name = nameBox.Text;
                    model.Patronymic = patrBox.Text;
                    model.Phone = phoneBox.Text;
                    model.Gender = (int)genderBox.SelectedValue;
                    using (GEntities db = new GEntities())
                    {
                        db.Clients.Add(model);
                        db.SaveChanges();
                        MessageBox.Show("Клиент успешно сохранён");
                        this.Hide();
                        ClientsFrm clientsFrm = new ClientsFrm(login);
                        clientsFrm.Show();
                    }
                }
                else if (numFrm == 2)
                {
                    model.Id = b;
                    model.Surname = surnameBox.Text;
                    model.Name = nameBox.Text;
                    model.Patronymic = patrBox.Text;
                    model.Phone = phoneBox.Text;
                    model.Gender = (int)genderBox.SelectedValue;
                    using (GEntities db = new GEntities())
                    {
                        db.Clients.Add(model);
                        db.SaveChanges();
                        MessageBox.Show("Клиент успешно сохранён");
                        this.Hide();
                        RequestCreatingFrm requestCreatingFrm = new RequestCreatingFrm(login, role);
                        requestCreatingFrm.Show();
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
                if (numFrm == 1)
                {
                    ClientsFrm clientsFrm = new ClientsFrm(login);
                    this.Hide();
                    clientsFrm.Show();
                }
                else if (numFrm == 2)
                {
                    RequestCreatingFrm requestCreatingFrm = new RequestCreatingFrm(login, role);
                    this.Hide();
                    requestCreatingFrm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
