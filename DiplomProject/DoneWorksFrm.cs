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
using System.Drawing.Printing;

namespace DiplomProject
{
    public partial class DoneWorksFrm : Form
    {
        private string login;
        private string result;
        public DoneWorksFrm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
                //docBtn.Visible = false;
                LoadData();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(result, new Font("Arial", 18), Brushes.Black, 0, 0);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }
        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                con.Open();
                string query = "Select * from WorksInfoPred ";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[17]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                    data[data.Count - 1][10] = reader[10].ToString();
                    data[data.Count - 1][11] = reader[11].ToString();
                    data[data.Count - 1][12] = reader[12].ToString();
                    data[data.Count - 1][13] = reader[13].ToString();
                    data[data.Count - 1][14] = reader[14].ToString();
                    data[data.Count - 1][15] = reader[15].ToString();
                    data[data.Count - 1][16] = reader[16].ToString();
                }
                reader.Close();
                con.Close();
                foreach (string[] s in data)
                    dataGridView.Rows.Add(s);
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

        private void DoneWorksFrm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddWorkFrm addWorkFrm = new AddWorkFrm(login);
                this.Hide();
                addWorkFrm.Show();
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
                MenuFrm menuFrm = new MenuFrm(login);
                this.Hide();
                menuFrm.Show();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void costBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Summary from SummaryPred where Id='" + costBox.Text + "'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() != null)
            //{
            //    label2.Text = "Сумма заказа равна: " + dt.Rows[0][0].ToString();
            //    docBtn.Visible = true;
            //}
            //else
            //{
            //    MessageBox.Show("Данные не найдены.");
            //}
        }

        private void docBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string gos = dataGridView.CurrentRow.Cells[14].Value.ToString();
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                SqlDataAdapter sda = new SqlDataAdapter("Select Owner from ClientCars where VinNumber='" + gos + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Surname, Name, Patronymic from Clients where Id='" + dt.Rows[0][0].ToString() + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                //label1.Text= dataGridView.CurrentRow.Cells[0].Value.ToString();
                result = "ОТЧЁТ ОБ УКАЗАНИИ УСЛУГИ \n";
                result += "Выполнил работник: " + dataGridView.CurrentRow.Cells[1].Value.ToString() + dataGridView.CurrentRow.Cells[15].Value.ToString() + dataGridView.CurrentRow.Cells[16].Value.ToString() + "\n";
                result += "Начало: " + dataGridView.CurrentRow.Cells[2].Value.ToString().Remove(12, 7) + "\n";
                result += "Время начала: " + dataGridView.CurrentRow.Cells[3].Value.ToString().Remove(4, 11) + "\n";
                result += "Окончание: " + dataGridView.CurrentRow.Cells[4].Value.ToString().Remove(12, 7) + "\n";
                result += "Время окончания: " + dataGridView.CurrentRow.Cells[5].Value.ToString().Remove(4, 11) + "\n";
                result += "Услуга: " + dataGridView.CurrentRow.Cells[6].Value.ToString() + "\n";
                result += "Стоимость услуги: " + dataGridView.CurrentRow.Cells[7].Value.ToString() + "\n";
                result += "Марка авто: " + dataGridView.CurrentRow.Cells[8].Value.ToString() + "\n";
                result += "Модель: " + dataGridView.CurrentRow.Cells[9].Value.ToString() + "\n";
                result += "Гос. номер: " + dataGridView.CurrentRow.Cells[10].Value.ToString() + "\n";
                result += "Цвет: " + dataGridView.CurrentRow.Cells[11].Value.ToString() + "\n";
                result += "Стоимость деталей: " + dataGridView.CurrentRow.Cells[12].Value.ToString() + "\n";
                result += "Плательщик: " + dt1.Rows[0][0].ToString() + " " + dt1.Rows[0][1].ToString() + " " + dt1.Rows[0][2].ToString() + "\n";
                result += "Сумма к оплате: " + dataGridView.CurrentRow.Cells[13].Value.ToString() + "\n";

                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += PrintPageHandler;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string gos = dataGridView.CurrentRow.Cells[14].Value.ToString();
            //SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Owner from ClientCars where VinNumber='" + gos + "'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            ////label1.Text = dt.Rows[0][0].ToString();
            //SqlDataAdapter sda1 = new SqlDataAdapter("Select Surname, Name, Patronymic from Clients where Id='" + dt.Rows[0][0].ToString() + "'", con);
            //DataTable dt1 = new DataTable();
            //sda1.Fill(dt1);
            //label1.Text = dt1.Rows[0][0].ToString() + " " + dt1.Rows[0][1].ToString() + " " + dt1.Rows[0][2].ToString();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            if (workerBox.Text != "" && workBox.Text=="")
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Visible = dataGridView[1, i].Value.ToString() == workerBox.Text;
                }
            }
            else if(workBox.Text !="" && workerBox.Text=="")
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Visible = dataGridView[6, i].Value.ToString() == workBox.Text;
                }
            }
            else if(workerBox.Text!="" && workBox.Text!="")
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Visible = dataGridView[1, i].Value.ToString() == workerBox.Text;
                    dataGridView.Rows[i].Visible = dataGridView[6, i].Value.ToString() == workBox.Text;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Visible = true;
                }
                MessageBox.Show("Введите данные в специальные поля.");
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Visible = true;
                }
                workerBox.Text = "";
                workBox.Text = "";
            }
            catch
            {
                MessageBox.Show("Ошибка, обратитесь к сисадмину.");
            }
        }
    }
}
