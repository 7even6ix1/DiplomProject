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
    public partial class TechInfoFrm : Form
    {
        private string login;
        TechnicalInformation model = new TechnicalInformation();
        public TechInfoFrm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
                using (GEntities db = new GEntities())
                {
                    List<BodyTypes> bodyTypes = db.BodyTypes.ToList();
                    bodyBox.DataSource = bodyTypes;
                    bodyBox.ValueMember = "Id";
                    bodyBox.DisplayMember = "BodyType";
                    List<EngineLocation> engineLocations = db.EngineLocation.ToList();
                    locationBox.DataSource = engineLocations;
                    locationBox.ValueMember = "Id";
                    locationBox.DisplayMember = "EngLocation";
                    List<GearboxTypes> gearboxTypes = db.GearboxTypes.ToList();
                    gearBox.DataSource = gearboxTypes;
                    gearBox.ValueMember = "Id";
                    gearBox.DisplayMember = "GearboxType";
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
                model.BodyType = Convert.ToInt32(bodyBox.SelectedValue);
                model.PlaceCount = Convert.ToInt32(placeBox.Text);
                model.DoorCount = Convert.ToInt32(doorBox.Text);
                model.EngineLocation = Convert.ToInt32(locationBox.SelectedValue);
                model.GearboxType = Convert.ToInt32(gearBox.SelectedValue);
                model.Engine = Convert.ToInt32(engineBox.Text);
                using (GEntities db = new GEntities())
                {
                    db.TechnicalInformation.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Техническая инфомация успешно добавлена!");
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

        private void TechInfoFrm_Load(object sender, EventArgs e)
        {
            try
            {
                bodyBox.DropDownHeight = 300;
                locationBox.DropDownHeight = 300;
                gearBox.DropDownHeight = 300;
            }
            catch
            {
                MessageBox.Show("Ошибка, обратитесь к сисадмину.");
            }
        }
    }
}
