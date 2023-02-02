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
    public partial class groups : Form
    {
        public groups()
        {
            InitializeComponent();
            fillCombo();
            fillComboTch();
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

        public int firstDayInt;
        public int secondDayInt;
        public int thirdDayInt;

        void fillCombo()
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlQuery = "select * from schooldb.course ;";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            MySqlDataReader myReader;
            try
            {
                myReader = sqlCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sCourse = myReader.GetString("courseName");
                    courseBox.Items.Add(sCourse);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
        }

        void fillComboTch()
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlQuery = "select * from schooldb.teacher ;";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            MySqlDataReader myReader;
            try
            {
                myReader = sqlCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sTeacher = myReader.GetString("teacherFName");
                    tchBox.Items.Add(sTeacher);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
        }

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT c.classID, c.className AS Название, ce.courseName AS Предмет, t.teacherFName AS Учитель, c.classDays AS Дни, c.classTime AS Часы, c.classIsFull AS Полон, c.classMaxCapacity AS 'Max' FROM class c JOIN course ce ON c.courseID = ce.courseID JOIN teacher t ON c.teacherID = t.teacherID";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void groups_Load(object sender, EventArgs e)
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
            sqlConn.Open();

            try
            {
                MySqlCommand com = new MySqlCommand("addGroup", sqlConn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new MySqlParameter("p_className", className.Text));
                com.Parameters.Add(new MySqlParameter("p_courseName", courseBox.Text));
                com.Parameters.Add(new MySqlParameter("p_teacherName", tchBox.Text));
                com.Parameters.Add(new MySqlParameter("p_classDays", classDays.Text));
                com.Parameters.Add(new MySqlParameter("p_classTime", classTime.Text));
                com.Parameters.Add(new MySqlParameter("p_classMaxCap", classMx.Text));
                com.ExecuteNonQuery();

                com.Connection.Close();

                sqlConn.Close();

                upLoadData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            //checkDayOfWeek(firstDayInt, secondDayInt, thirdDayInt);

            //goThrough(firstDayInt, secondDayInt, thirdDayInt);
        }

        public void goThrough(int passed1Day, int passed2Day, int passed3Day)
        {
            for(int index = 10; index < 17; index++)
            {
                try
                {
                    sqlConn.Open();

                    MySqlCommand com = new MySqlCommand("checkDayOfWeek", sqlConn);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add(new MySqlParameter("p_LName", dataGridView1.SelectedRows[0].Cells[index].Value.ToString()));
                    com.Parameters.Add(new MySqlParameter("p_FName", dataGridView1.SelectedRows[1].Cells[index].Value.ToString()));
                    com.Parameters.Add(new MySqlParameter("p_CName", dataGridView1.SelectedRows[2].Cells[index].Value.ToString()));
                    com.Parameters.Add(new MySqlParameter("p_firstDay", passed1Day));
                    com.Parameters.Add(new MySqlParameter("p_secondtDay", passed2Day));
                    com.Parameters.Add(new MySqlParameter("p_thirdDay", passed3Day));
                    com.Parameters.Add(new MySqlParameter("p_fee_cost", dataGridView1.SelectedRows[4].Cells[index].Value.ToString()));
                    com.Parameters.Add(new MySqlParameter("p_money_owing", dataGridView1.SelectedRows[3].Cells[index].Value.ToString()));
                    //com.Parameters.Add(new MySqlParameter("teacherExists", MySqlDbType.Int32));
                    //com.Parameters["teacherExists"].Direction = ParameterDirection.Output;

                    com.ExecuteNonQuery();

                    //int teacherExists = (int)com.Parameters["teacherExists"].Value;
                   // teacherExist(teacherExists);
                    com.Connection.Close();

                    sqlConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string firstDay = classDays.Text.Substring(0, 3);
            string secondDay = classDays.Text.Substring(5, 3);
            string thirdDay = classDays.Text.Substring(10, 3);
            MessageBox.Show(firstDay);
            if (firstDay == "Mon")
            {
                firstDayInt = 0;
            }
            else
            {
                firstDayInt = 1;
            }
            if (secondDay == "Mon")     //put into func
            {
                secondDayInt = 0;
            }
            else
            {
                secondDayInt = 1;
            }
            if (thirdDay == "Mon")
            {
                thirdDayInt = 0;
            }
            else
            {
                thirdDayInt = 1;
            }

            //goThrough(firstDayInt, secondDayInt, thirdDayInt);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                className.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                courseBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tchBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                classDays.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                classTime.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                object value = dataGridView1.SelectedRows[0].Cells[6].Value;
                bool boolVal = Convert.ToBoolean(value);
                if (boolVal == true)
                {
                    checkBox1.Checked = true;
                }
                classMx.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

                sqlCmd.CommandText = "Update schooldb.class set className = @className, courseID = (SELECT courseID FROM course WHERE courseName = @courseName), teacherID = (SELECT teacherID FROM teacher WHERE teacherFName = @teacherName), classDays = @classDays, classTime = @classTime, classMaxCapacity = @classMax WHERE classID = @classID";

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@classID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@className", className.Text);
                sqlCmd.Parameters.AddWithValue("@courseName", courseBox.Text);
                sqlCmd.Parameters.AddWithValue("@teacherName", tchBox.Text);
                sqlCmd.Parameters.AddWithValue("@classDays", classDays.Text);
                sqlCmd.Parameters.AddWithValue("@classTime", classTime.Text);
                sqlCmd.Parameters.AddWithValue("@classMax", classMx.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                upLoadData();
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
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить эту группу?", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand sqlCmd = new MySqlCommand();
                    sqlCmd.Connection = sqlConn;

                    sqlCmd.CommandText = "delete from schooldb.class where classID = @classID";

                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@classID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());

                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();

                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);
                    }

                    upLoadData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
}
