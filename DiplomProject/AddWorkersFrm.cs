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
    public partial class AddWorkersFrm : Form
    {
        private string login;
        Workers model = new Workers();
        int b = 0;
        public AddWorkersFrm(string login)
        {
            this.login = login;
            InitializeComponent();
            using (GEntities db = new GEntities())
            {
                List<Genders> genders = db.Genders.ToList();
                genderBox.DataSource = genders;
                genderBox.DisplayMember = "Gender";
                genderBox.ValueMember = "Id";
                List<Posts> posts = db.Posts.ToList();
                postBox.DataSource = posts;
                postBox.DisplayMember = "Post";
                postBox.ValueMember = "Id";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddWorkersFrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Workers order by Id DESC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string a = dt.Rows[0][0].ToString();
             b = Convert.ToInt32(a) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.Id = b;
            model.Surname = surnameBox.Text;
            model.Name = nameBox.Text;
            model.Patronymic = patronymicBox.Text;
            model.Birthdate = dateBox.Value;
            model.Gender = (int)genderBox.SelectedValue;
            model.Post = (int)postBox.SelectedValue;
            using (GEntities db = new GEntities())
            {
                db.Workers.Add(model);
                db.SaveChanges();
            }
            
            //WorkersFrm workersFrm = new WorkersFrm();
            //this.Hide();
            //workersFrm.Show();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            WorkersForm workersForm = new WorkersForm(login);
            this.Hide();
            workersForm.Show();
        }

        private void phoneLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
