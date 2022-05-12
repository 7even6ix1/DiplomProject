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
using System.Drawing.Printing;

namespace DiplomProject
{
    public partial class ClientsFrm : Form
    {
        private string login;
        private string result;
        private int numFrm = 1;
        public ClientsFrm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
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
        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                con.Open();
                string query = "Select * from ClientInfoPred ";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[8]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
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
        private void ClientsFrm_Load(object sender, EventArgs e)
        {

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

        private void filtBtn_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            //con.Open();
            //string query = "Select * from ClientInfoPred where Surname='"+surBox.Text+"'";
            //SqlCommand command = new SqlCommand(query, con);
            //SqlDataReader reader = command.ExecuteReader();
            //List<string[]> data = new List<string[]>();
            //while (reader.Read())
            //{
            //    data.Add(new string[8]);

            //    data[data.Count - 1][0] = reader[0].ToString();
            //    data[data.Count - 1][1] = reader[1].ToString();
            //    data[data.Count - 1][2] = reader[2].ToString();
            //    data[data.Count - 1][3] = reader[3].ToString();
            //    data[data.Count - 1][4] = reader[4].ToString();
            //    data[data.Count - 1][5] = reader[5].ToString();
            //    data[data.Count - 1][6] = reader[6].ToString();
            //    data[data.Count - 1][7] = reader[7].ToString();
            //}
            //reader.Close();
            //con.Close();
            //foreach (string[] s in data)
            //    dataGridView.Rows.Add(s);
        }

        private void docBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //label1.Text= dataGridView.CurrentRow.Cells[0].Value.ToString();
                result = "ИНФОРМАЦИЯ О КЛИЕНТЕ \n";
                result += "Фамилия: " + dataGridView.CurrentRow.Cells[0].Value.ToString() + "\n";
                result += "Имя: " + dataGridView.CurrentRow.Cells[1].Value.ToString() + "\n";
                result += "Отчество: " + dataGridView.CurrentRow.Cells[2].Value.ToString() + "\n";
                result += "Телефон: " + dataGridView.CurrentRow.Cells[3].Value.ToString() + "\n";
                result += "Марка автомобиля: " + dataGridView.CurrentRow.Cells[4].Value.ToString() + "\n";
                result += "Модель автомобиля: " + dataGridView.CurrentRow.Cells[5].Value.ToString() + "\n";
                result += "Vin номер автомобиля: " + dataGridView.CurrentRow.Cells[6].Value.ToString() + "\n";
                result += "Гос. номер автомобиля: " + dataGridView.CurrentRow.Cells[7].Value.ToString() + "\n";
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
    }
}
