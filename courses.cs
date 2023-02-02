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
    public partial class courses : Form
    {
        public courses()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                courseName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                courseDesc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT courseID, courseName AS Предмет, courseDescription AS 'Описание Предмета' FROM schooldb.course";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void abdBtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            try
            {
                sqlConn.Open();

                MySqlCommand com = new MySqlCommand("addCourse", sqlConn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new MySqlParameter("p_courseName", courseName.Text));
                com.Parameters.Add(new MySqlParameter("p_courseDesc", courseDesc.Text));
                com.Parameters.Add(new MySqlParameter("courseExists", MySqlDbType.Int32));
                com.Parameters["courseExists"].Direction = ParameterDirection.Output;

                com.ExecuteNonQuery();

                int courseExists = (int)com.Parameters["courseExists"].Value;
                courseExist(courseExists);
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

        private void courses_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        public void courseExist(int passedInt)
        {
            if(passedInt == 1)
            {
                MessageBox.Show("Course already exists");
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

                sqlCmd.CommandText = "Update schooldb.course set courseName = @courseName, courseDescription = @courseDesc where courseID = @courseID";

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@courseID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@courseName", courseName.Text);
                sqlCmd.Parameters.AddWithValue("@courseDesc", courseDesc.Text);

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
                courseName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                courseDesc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                courseFee.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            sqlConn.Close();
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Caution!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand sqlCmd = new MySqlCommand();
                    sqlCmd.Connection = sqlConn;

                    sqlCmd.CommandText = "delete from schooldb.course where courseID = @courseID";

                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@courseID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());

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
