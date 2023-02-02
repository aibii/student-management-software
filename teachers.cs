using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace databaseLP
{
    public partial class teachers : Form
    {
        public teachers()
        {
            InitializeComponent();
        }

        Bitmap bitmap;

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        String server = "localhost";
        String username = "root";
        String password = "fishes12";
        String database = "schooldb";

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT teacherID, teacherLName, teacherFName, teacherDOB, teacherPhone, teacherJoinDate FROM schooldb.teacher";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void teachers_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            upLoadData();

        }

        private void abdBtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            try
            {
                sqlConn.Open();

                MySqlCommand com = new MySqlCommand("addTeacher", sqlConn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new MySqlParameter("p_tLName", lastNameTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_tFName", firstNameTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_tDOB", dobTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_tPhone", phoneTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_tJoinDate", startDayTxb.Text));
                com.Parameters.Add(new MySqlParameter("teacherExists", MySqlDbType.Int32));
                com.Parameters["teacherExists"].Direction = ParameterDirection.Output;

                com.ExecuteNonQuery();

                int teacherExists = (int)com.Parameters["teacherExists"].Value;
                teacherExist(teacherExists);
                com.Connection.Close();

                sqlConn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlConn.Close();
            }
            upLoadData();
        }

        public void teacherExist(int passedInt)
        {
            if (passedInt == 1)
            {
                MessageBox.Show("Teacher already exists");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "Update schooldb.teacher set teacherLName = @teacherLName, teacherFName = @teacherFName, teacherDOB = @teacherDOB, teacherPhone = @teacherPhone, teacherJoinDate = @teacherJoinDate where teacherID = @teacherID";

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@teacherID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@teacherLName", lastNameTxb.Text);
                sqlCmd.Parameters.AddWithValue("@teacherFName", firstNameTxb.Text);
                sqlCmd.Parameters.AddWithValue("@teacherDOB", dobTxb.Text);
                sqlCmd.Parameters.AddWithValue("@teacherPhone", phoneTxb.Text);
                sqlCmd.Parameters.AddWithValue("@teacherJoinDate", startDayTxb.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();

                upLoadData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lastNameTxb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                firstNameTxb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dobTxb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                phoneTxb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                startDayTxb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Caution!", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    MySqlCommand sqlCmd = new MySqlCommand();
                    sqlCmd.Connection = sqlConn;

                    sqlCmd.CommandText = "delete from schooldb.teacher where teacherID = @teacherID";

                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@teacherID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());

                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();

                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);
                    }

                    upLoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
