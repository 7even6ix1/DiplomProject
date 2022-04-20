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

namespace DiplomProject
{
    public partial class WorkersForm : Form
    {
        Workers model = new Workers();
        private string login;
        public WorkersForm(string login)
        {
            this.login = login;
            InitializeComponent();
            LoadData();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void WorkersFrm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_7even6ixDBDataSet.WorkersInfoPred". При необходимости она может быть перемещена или удалена.
            

        }

        private void LoadData()
        {
            SqlConnection con = new SqlConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
            con.Open();
            string query = "Select * from WorkersInfoPred ";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while(reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            con.Close();
            foreach (string[] s in data)
                workersInfoPredDataGridView.Rows.Add(s);
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
            if(MessageBox.Show("Вы действительно хотите удалить эту запись?",
                "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                OleDbConnection con = new OleDbConnection(@"workstation id=7even6ixDB.mssql.somee.com;packet size=4096;user id=Nicho_7even6ix_SQLLogin_1;pwd=lqz48ctpvv;data source=7even6ixDB.mssql.somee.com;persist security info=False;initial catalog=7even6ixDB");
                OleDbCommand command = new OleDbCommand("DELETE * FROM TableName WHERE Id = @pId", con); //TableName - имя таблицы, из которой удаляете запись
                command.Parameters.Add(new OleDbParameter("@pId", this.workersInfoPredDataGridView.CurrentRow.Cells["Id"].Value)); //DataGridViewName - имя DataGridView на форме
                command.ExecuteNonQuery();
            }

        }
    }
}
