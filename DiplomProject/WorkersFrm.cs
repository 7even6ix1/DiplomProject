using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace DiplomProject
{
    public partial class WorkersForm : Form
    {
        Workers model = new Workers();
        private string login;
        private string result;
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
        public WorkersForm(string login)
        {
            try
            {
                this.login = login;
                InitializeComponent();
                //using(GEntities db = new GEntities())
                //{
                //    List<Genders> genders = db.Genders.ToList();
                //    genderBox.DataSource = genders;
                //    genderBox.DisplayMember = "Gender";
                //    genderBox.ValueMember = "Id";
                //    List<Posts> posts = db.Posts.ToList();
                //    postBox.DataSource = posts;
                //    postBox.DisplayMember = "Post";
                //    postBox.ValueMember = "Id";
                //}
                LoadData();
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
                this.Close();
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

        private void WorkersFrm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_7even6ixDBDataSet.WorkersInfoPred". При необходимости она может быть перемещена или удалена.
           
            // тTODO: данная строка кода позволяет загрузить данные в таблицу "_7even6ixDBDataSet.WorkersInfoPred". При необходимости она может быть перемещена или удалена.


        }

        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                con.Open();
                string query = "Select * from WorkersInfoPred ";
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
                    workersInfoPredDataGridView.Rows.Add(s);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void workersInfoPredDataGridView_Click(object sender, EventArgs e)
        {
            //if(workersInfoPredDataGridView.CurrentRow.Index != -1)
            //{
            //    model.Id = Convert.ToInt32(workersInfoPredDataGridView.CurrentRow.Cells["Id"].Value);
            //    using (Entities db = new Entities())
            //    {
            //        model = db.Workers.Where(x => x.Id == model.Id).FirstOrDefault();

            //    }
            //}
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Workers WHERE Id =@pId", con); 
                command.Parameters.Add(new SqlParameter("@pId", this.workersInfoPredDataGridView.CurrentRow.Cells["Id"].Value)); 
                command.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
                workersInfoPredDataGridView.Rows.Clear();
                LoadData();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddWorkersFrm addWorkersFrm = new AddWorkersFrm(login);
                this.Hide();
                addWorkersFrm.Show();
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

        private void docBtn_Click(object sender, EventArgs e)
        {
            try
            {
                result = "ИНФОРМАЦИЯ О СОТРУДНИКЕ \n";
                result += "Фамилия: " + workersInfoPredDataGridView.CurrentRow.Cells[0].Value.ToString() + "\n";
                result += "Имя: " + workersInfoPredDataGridView.CurrentRow.Cells[1].Value.ToString() + "\n";
                result += "Отчество: " + workersInfoPredDataGridView.CurrentRow.Cells[2].Value.ToString() + "\n";
                result += "Дата рождения: " + workersInfoPredDataGridView.CurrentRow.Cells[3].Value.ToString().Remove(12, 7) + "\n";
                result += "Пол: " + workersInfoPredDataGridView.CurrentRow.Cells[4].Value.ToString() + "\n";
                result += "Должность: " + workersInfoPredDataGridView.CurrentRow.Cells[5].Value.ToString() + "\n";
                result += "Размер заработной платы: " + workersInfoPredDataGridView.CurrentRow.Cells[6].Value.ToString() + "\n";
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

        private void findBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < workersInfoPredDataGridView.Rows.Count; i++)
            {
                workersInfoPredDataGridView.Rows[i].Visible = workersInfoPredDataGridView[0, i].Value.ToString() == workerBox.Text;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < workersInfoPredDataGridView.Rows.Count; i++)
            {
                workersInfoPredDataGridView.Rows[i].Visible = true;
            }
        }
    }
}
