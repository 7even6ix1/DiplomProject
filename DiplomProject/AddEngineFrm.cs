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
    public partial class AddEngineFrm : Form
    {
        private string login;
        Engines model = new Engines();
        public AddEngineFrm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
                using (GEntities db = new GEntities())
                {
                    List<EngineTypes> engineTypes = db.EngineTypes.ToList();
                    typeBox.DataSource = engineTypes;
                    typeBox.DisplayMember = "Type";
                    typeBox.ValueMember = "Id";
                    List<EngineVolume> engineVolumes = db.EngineVolume.ToList();
                    volumeBox.DataSource = engineVolumes;
                    volumeBox.DisplayMember = "Volume";
                    volumeBox.ValueMember = "Id";
                    List<FuelTypes> fuelTypes = db.FuelTypes.ToList();
                    fuelBox.DataSource = fuelTypes;
                    fuelBox.ValueMember = "Id";
                    fuelBox.DisplayMember = "FuelType";
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                model.Type = Convert.ToInt32(typeBox.SelectedValue);
                model.Volume = Convert.ToInt32(volumeBox.SelectedValue);
                model.FuelType = Convert.ToInt32(fuelBox.SelectedValue);
                model.Cylinders = Convert.ToInt32(countBox.Text);
                using (GEntities db = new GEntities())
                {
                    db.Engines.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Двигатель успешно добавлен");
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

        private void AddEngineFrm_Load(object sender, EventArgs e)
        {
            try
            {
                volumeBox.DropDownHeight = 300;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
    }
}
