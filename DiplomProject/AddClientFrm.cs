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
        int b = 0;
        Clients model = new Clients();
        public AddClientFrm(string login)
        {
            this.login = login;
            Clients model = new Clients();
            InitializeComponent();
            using(GEntities db = new GEntities())
            {
                List<Genders> genders = db.Genders.ToList();
                genderBox.DataSource = genders;
                genderBox.DisplayMember = "Gender";
                genderBox.ValueMember = "Id";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddClientFrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Clients order by Id DESC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string a = dt.Rows[0][0].ToString();
            b = Convert.ToInt32(a) + 1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            model.Id = b;
            model.Surname = surnameBox.Text;
            model.Name = nameBox.Text;
            model.Patronymic = patrBox.Text;
            model.Phone = phoneBox.Text;
            model.Gender = (int)genderBox.SelectedValue;
            using(GEntities db = new GEntities())
            {
                db.Clients.Add(model);
                db.SaveChanges();
                MessageBox.Show("Клиент успешно сохранён");
                this.Hide();
                ClientsFrm clientsFrm = new ClientsFrm(login);
                clientsFrm.Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ClientsFrm clientsFrm = new ClientsFrm(login);
            this.Hide();
            clientsFrm.Show();
        }
    }
}
