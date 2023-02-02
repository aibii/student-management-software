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
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
            fillCombo();
        }

        int turn = 1;
        
        Bitmap bitmap;

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        DataTable sqlDt2 = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        String server = "localhost";
        String username = "root";
        String password = "fishes12";
        String database = "schooldb";

        void fillChecked()
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
                    string sSub = myReader.GetString("courseName");
                    subjectBox.Items.Add(sSub);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
        }

        void fillCombo()
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            sqlCmd.Connection = sqlConn;

            sqlQuery = "select * from schooldb.class ;";
            sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
            MySqlDataReader myReader;
            try
            {
                myReader = sqlCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sGroup = myReader.GetString("className");
                    groupBox.Items.Add(sGroup);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
        }

        private void callIterateThrough()
        {
           
        }
        

        private void upLoadData()
        {
            sqlDt.Clear();
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT s.studLName AS Фамилия, s.studFName AS Имя, timestampdiff(YEAR,studAge,now()) AS Возраст, s.studActive AS Зачислен, s.studStartDay, p.parentFName AS Родитель, p.parentPhone AS Телефон, c.className AS Группа, s.studAge, sd.studActive FROM student s JOIN parent p ON s.parentID = p.parentID JOIN studclass sd ON s.studID = sd.studentID JOIN class c ON sd.classID = c.classID";
        //дата рож нужна?

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;
        }

        private void students_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            subjectBox.Hide();
            upLoadData();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            try
            {
                sqlConn.Open();

                bool wlchecked = false;

                if(toWaitlist.Checked)
                    wlchecked = true;
                //int rowindex = dataGridView1.CurrentCell.RowIndex;
                MySqlCommand com = new MySqlCommand("addParent", sqlConn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new MySqlParameter("p_parName", parentNameTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_parPhone", phoneTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_studName", firstNameTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_age", ageTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_studLName", lastNameTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_startDay", startDayTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_group", groupBox.SelectedIndex+1));
                com.Parameters.Add(new MySqlParameter("p_course", subjectBox.SelectedIndex + 1));
                com.Parameters.Add(new MySqlParameter("p_toWaitlist", wlchecked));
                //com.Parameters.AddWithValue("@p_max", dataGridView1.Rows[rowindex].Cells[9].Value.ToString());

                com.ExecuteNonQuery();
                com.Connection.Close();
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "Update schooldb.student s JOIN schooldb.parent p ON s.parentID = p.parentID JOIN studclass sc ON s.studID = sc.studentID JOIN class c ON sc.classID = c.classID set s.studFName = @studFName, s.studLName = @studLName, s.studStartDay = @startDay, s.studAge = @studAge, sc.studActive = @studAct, sc.classID = @group, p.parentFName = @parentFName, p.parentPhone = @parentPhone where studID = @studID";

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@studID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@studFName", firstNameTxb.Text);
                sqlCmd.Parameters.AddWithValue("@studAge", ageTxb.Text);
                sqlCmd.Parameters.AddWithValue("@parentFName", parentNameTxb.Text);
                sqlCmd.Parameters.AddWithValue("@parentPhone", phoneTxb.Text);
                sqlCmd.Parameters.AddWithValue("@studLName", lastNameTxb.Text);
                sqlCmd.Parameters.AddWithValue("@startDay", startDayTxb.Text);
                sqlCmd.Parameters.AddWithValue("@group", groupBox.SelectedIndex+1);
                //sqlCmd.Parameters.AddWithValue("@studAct", checkBox1);

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
                firstNameTxb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lastNameTxb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                startDayTxb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                ageTxb.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                parentNameTxb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                phoneTxb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                groupBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                
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
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand sqlCmd = new MySqlCommand();
                    sqlCmd.Connection = sqlConn;

                    sqlCmd.CommandText = "delete from schooldb.student where studID = @studentID";

                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@studentID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());

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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            /*sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            MySqlCommand sqlCmd = new MySqlCommand();
            sqlCmd.Connection = sqlConn;

            sqlCmd.CommandType = CommandType.Text;

            if (searchBox.SelectedIndex == 1)
            {
                sqlCmd.CommandText = "SELECT * FROM schooldb.student WHERE studFName = @studFName";
                sqlCmd.Parameters.AddWithValue("@studFName", searchTxb.Text);
            }
            //sqlCmd.ExecuteNonQuery();
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            //upLoadData(); */
            DataView dv = sqlDt.DefaultView;
            if (searchBox.SelectedIndex == 1)
            {
                dv.RowFilter = string.Format("Фамилия like '%{0}%'", searchTxb.Text);
            }
            else if (searchBox.SelectedIndex == 0)
            {
                dv.RowFilter = string.Format("studlname like '%{0}%'", searchTxb.Text);
            }
            dataGridView1.DataSource = dv.ToTable();

        }

        private void searchTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = sqlDt.DefaultView;
            if (searchBox.SelectedIndex == 1)
            {
                dv.RowFilter = string.Format("Имя like '%{0}%'", searchTxb.Text);
            }
            else if (searchBox.SelectedIndex == 0)
            {
                dv.RowFilter = string.Format("Фамилия like '%{0}%'", searchTxb.Text);
            }
            else if (searchBox.SelectedIndex == 2)
            {
                dv.RowFilter = string.Format("возраст like '%{0}%'", searchTxb.Text);
            }
            else if (searchBox.SelectedIndex == 3)
            {
                dv.RowFilter = string.Format("родитель like '%{0}%'", searchTxb.Text);
            }
            else if (searchBox.SelectedIndex == 4)
            {
                dv.RowFilter = string.Format("телефон like '%{0}%'", searchTxb.Text);
            }
            dataGridView1.DataSource = dv.ToTable();
        }

        private void toWaitlist_CheckedChanged(object sender, EventArgs e)
        {
            if(toWaitlist.Checked == true)
            {
                groupTxb.Text = "Предметы: ";
                groupBox.Hide();
                subjectBox.Show();
                fillChecked();
            }
            else
            {
                subjectBox.Hide();
                groupBox.Show();
                fillCombo();
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            turn += 1;
            if (turn % 2 == 0)
            {
                sqlDt2.Clear();
                sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                    + database;

                sqlConn.Open();
                sqlCmd.Connection = sqlConn;
                dataGridView1.Hide();
                dataGridView2.Show();
                sqlCmd.CommandText = "SELECT s.studLName AS Фамилия, s.studFName AS Имя, timestampdiff(YEAR,studAge,now()) AS Возраст, s.studActive AS Зачислен, s.studStartDay, p.parentFName AS Родитель, p.parentPhone AS Телефон, c.courseName, s.studAge FROM student s JOIN parent p ON s.parentID = p.parentID JOIN studcourse sc ON s.studID = sc.studentID JOIN course c ON sc.courseID = c.courseID";
                //дата рож нужна?

                sqlRd = sqlCmd.ExecuteReader();
                sqlDt2.Load(sqlRd);
                sqlRd.Close();
                sqlConn.Close();
                dataGridView2.DataSource = sqlDt2;
            }
            else
            {
                dataGridView2.Hide();
                dataGridView1.Show();
                sqlDt.Clear();
                upLoadData();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                firstNameTxb.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                lastNameTxb.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                startDayTxb.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                ageTxb.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
                parentNameTxb.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                phoneTxb.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                groupBox.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
