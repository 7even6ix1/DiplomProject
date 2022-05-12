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
    public partial class AddDeliveriesFrm : Form
    {
        private string login;
        Deliviries model = new Deliviries();
        int b = 0;
        public AddDeliveriesFrm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
                using (GEntities db = new GEntities())
                {
                    List<Provider> providers = db.Provider.ToList();
                    providerBox.DataSource = providers;
                    providerBox.DisplayMember = "Name";
                    providerBox.ValueMember = "Id";
                    List<Details> details = db.Details.ToList();
                    detailBox.DataSource = details;
                    detailBox.DisplayMember = "Name";
                    detailBox.ValueMember = "Id";
                    List<CarModels> carModels = db.CarModels.ToList();
                    modelBox.DataSource = carModels;
                    modelBox.DisplayMember = "Name";
                    modelBox.ValueMember = "Id";
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

        private void AddDeliveriesFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                SqlDataAdapter sda = new SqlDataAdapter("Select top 1 * from Deliviries order by Id DESC", con);
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
                model.Id = b;
                model.Provider = (int)providerBox.SelectedValue;
                model.Detail = (int)detailBox.SelectedValue;
                model.Count = Convert.ToInt32(countBox.Text);
                model.Date = dateBox.Value;
                model.Cost = Convert.ToInt32(costBox.Text);
                model.CarModel = (int)modelBox.SelectedValue;
                using (GEntities db = new GEntities())
                {
                    db.Deliviries.Add(model);
                    db.SaveChanges();
                }
                MessageBox.Show("Доставка успешно сохранена!");
                this.Hide();
                DeliveriesFrm deliveriesFrm = new DeliveriesFrm(login);
                deliveriesFrm.Show();
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
                DeliveriesFrm deliveriesFrm = new DeliveriesFrm(login);
                this.Hide();
                deliveriesFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
