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
    public partial class AddDetailFrm : Form
    {
        AvailableDetails model = new AvailableDetails();
        private string login;
        int b = 0;
        public AddDetailFrm(string login)
        {
            this.login = login;
            InitializeComponent();
            using(GEntities db = new GEntities())
            {
                List<Store> stores = db.Store.ToList();
                storeBox.DataSource = stores;
                storeBox.DisplayMember = "Name";
                storeBox.ValueMember = "Id";
                List<Details> details = db.Details.ToList();
                detailBox.DataSource= details;
                detailBox.DisplayMember = "Name";
                detailBox.ValueMember = "Id";
                List<CarModels> carModels = db.CarModels.ToList();
                modelBox.DataSource = carModels;
                modelBox.DisplayMember="Name";
                modelBox.ValueMember = "Id";
            }
        }

        private void AddDetailFrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Deliviries order by Id DESC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string a = dt.Rows[0][0].ToString();
            b = Convert.ToInt32(a) + 1;
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            model.Id = b;
            model.Store = (int)storeBox.SelectedValue;
            model.Detail = (int)detailBox.SelectedValue;
            model.Count = Convert.ToInt32(countBox.Text);
            model.Cost = Convert.ToInt32(costBox.Text);
            model.CarModel = (int)modelBox.SelectedValue;
            using(GEntities db = new GEntities())
            {
                db.AvailableDetails.Add(model);
                db.SaveChanges();
            }
            MessageBox.Show("Деталь успешно сохранена!");
            this.Hide();
            DetailsFrm detailsFrm = new DetailsFrm(login);
            detailsFrm.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DetailsFrm detailsFrm = new DetailsFrm(login);
            detailsFrm.Show();
        }
    }
}
