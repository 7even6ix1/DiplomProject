﻿using System;
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
    
    public partial class AddClientsCarFrm : Form
    {
        private string login;
        private int numFrm;
        private string role;
        ClientCars model = new ClientCars();
        public AddClientsCarFrm(string login, int numFrm)
        {
            this.login = login;
            this.numFrm = numFrm;
            InitializeComponent();
            using(GEntities db = new GEntities())
            {
                List<CarModels> carModels = db.CarModels.ToList();
                modelBox.DataSource=carModels;
                modelBox.DisplayMember = "Name";
                modelBox.ValueMember = "Id";
                List<Clients> clients = db.Clients.ToList();
                clientBox.DataSource = clients;
                clientBox.DisplayMember = "Phone";
                clientBox.ValueMember = "Id";
            }
        }

        private void patrLbl_Click(object sender, EventArgs e)
        {

        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (numFrm == 1)
            {
                model.CarModel = (int)modelBox.SelectedValue;
                model.VinNumber = vinBox.Text;
                model.GosNumber = gosBox.Text;
                model.Owner = (int)clientBox.SelectedValue;
                using (GEntities db = new GEntities())
                {
                    db.ClientCars.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Автомобиль успешно сохранён");
                    this.Hide();
                    ClientsFrm clientsFrm = new ClientsFrm(login);
                    clientsFrm.Show();
                }
            }
            else if(numFrm==2)
            {
                model.CarModel = (int)modelBox.SelectedValue;
                model.VinNumber = vinBox.Text;
                model.GosNumber = gosBox.Text;
                model.Owner = (int)clientBox.SelectedValue;
                using (GEntities db = new GEntities())
                {
                    db.ClientCars.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Автомобиль успешно сохранён");
                    this.Hide();
                    RequestCreatingFrm clientsFrm = new RequestCreatingFrm(login,role);
                    clientsFrm.Show();
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(numFrm==2)
            {
                this.Hide();
                RequestCreatingFrm clientsFrm = new RequestCreatingFrm(login,role);
                clientsFrm.Show();
            }
            else if(numFrm==1)
            {
                this.Hide();
                ClientsFrm clientsFrm = new ClientsFrm(login);
                clientsFrm.Show();
            }
        }
    }
}
