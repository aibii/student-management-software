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

    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
            tabControl1.SelectTab("tabPage2");
            fillGroupComboBox();
        }


        Bitmap bitmap;

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlConnection sqlConn2 = new MySqlConnection();
        MySqlConnection sqlConn3 = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlCommand sqlCmd2 = new MySqlCommand();
        MySqlCommand sqlCmd3 = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        DataTable sqlDt2 = new DataTable();
        DataTable sqlDt3 = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        MySqlDataReader sqlRd2;
        MySqlDataReader sqlRd3;

        DataSet DS = new DataSet();


        String server = "localhost";
        String username = "root";
        String password = "fishes12";
        String database = "schooldb";

        void fillGroupComboBox()
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
                    string sClass = myReader.GetString("className");
                    groupComboBox.Items.Add(sClass);
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

            sqlCmd = new MySqlCommand();

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            sqlCmd.CommandType = CommandType.Text;

            sqlCmd.CommandText = "SELECT c.className FROM class c JOIN studclass sc ON c.classID = sc.classID JOIN student s ON sc.studentID = s.studID WHERE s.studID = @studID ";


            sqlCmd.Parameters.AddWithValue("@studID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            MySqlDataReader myReader;
            myReader = sqlCmd.ExecuteReader();
            sqlCmd.ExecuteNonQuery();
            while (myReader.Read())
            {
                string sClass = myReader.GetString("c.className");
                //groupBox.Items.Add(sClass);
            }
            sqlConn.Close();
        }



        private void fees_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            upLoadData();
            groupComboBox.Hide();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }
        }

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            sqlConn.Open();

            try
            {

                sqlCmd.Connection = sqlConn;

                //sqlCmd.CommandText = "SELECT s.studLName, s.studFName, c.className, IFNULL(p.paymentID, 'N/A'), IFNULL(p.paymentAmt, 'N/A'), IFNULL(p.paymentDate, 'N/A'), IFNULL(p.paymentPendingAmt, 'N/A'), IFNULL(p.paymentDueDate, 'N/A'), c.classMhtlyFee FROM class c JOIN studclass sc ON c.classID = sc.classID JOIN student s ON sc.studentID = s.studID JOIN payment p ON p.studentID = s.studID;";
                sqlCmd.CommandText = "SELECT s.studLName, s.studFName, c.className, c.classMhtlyFee, p.paymentFrost FROM class c JOIN studclass sc ON c.classID = sc.classID JOIN student s ON sc.studentID = s.studID LEFT JOIN payment p ON p.studentID = s.studID;";

                sqlRd = sqlCmd.ExecuteReader();
                //DataColumn dc = ;
                //dc.AllowDBNull = true;
                sqlDt.Load(sqlRd);
                sqlRd.Close();
                sqlConn.Close();
                dataGridView1.DataSource = sqlDt;
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
                DateTime temp;
                fName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                /*if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "N/A") //(DateTime.TryParse(paymentDateTxb.Text, out temp))
                {
                    paymentDateTxb.Text = DateTime.Today.ToShortDateString();  
                }
                else
                    paymentDateTxb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString(); */

                //AmountTxb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                gBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                feesBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void tabControl1_Click(object sender, EventArgs e)
        {

            //upLoadPData();
        }

        private void upLoadPData()
        {
            sqlConn2.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            sqlConn2.Open();
            sqlCmd2.Connection = sqlConn2;
            sqlCmd2.CommandText = "SELECT s.studLName, s.studFName, c.className, p.paymentID, p.paymentAmt, p.paymentDate, p.paymentPendingAmt, p.paymentFrost, p.paymentDueDate, c.classMhtlyFee FROM class c JOIN studclass sc ON c.classID = sc.classID JOIN student s ON sc.studentID = s.studID JOIN payment p ON p.studentID = s.studID;";
            //parentPhone FROM student s JOIN parent p ON s.parentID = p.parentID

            sqlRd2 = sqlCmd2.ExecuteReader();
            sqlDt2.Load(sqlRd2);
            sqlRd2.Close();
            sqlConn2.Close();
            dataGridView2.DataSource = sqlDt2;

            int sum = 0;
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                sum += Convert.ToInt32(r.Cells[6].Value);
            }
            label7.Text = "Общая сумма долгов - " + sum;
        }

        private void upLoadOwingData()
        {
            dataGridView3.DataSource = null;

            sqlConn3.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            sqlConn3.Open();
            sqlCmd3.Connection = sqlConn3;
            sqlCmd3.CommandText = "SELECT s.studLName, s.studFName, c.className, p.paymentPendingAmt, c.classMhtlyFee FROM class c JOIN studclass sc ON c.classID = sc.classID JOIN student s ON sc.studentID = s.studID JOIN payment p ON p.studentID = s.studID;";
            //parentPhone FROM student s JOIN parent p ON s.parentID = p.parentID

            sqlRd3 = sqlCmd3.ExecuteReader();
            sqlDt3.Load(sqlRd3);
            sqlRd3.Close();
            sqlConn3.Close();
            dataGridView3.DataSource = sqlDt3;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                upLoadPData();
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                upLoadOwingData();
            }
            else
            {
                //upLoadOwingData();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            goThrough();
        }

        public void goThrough()
        {
            try
            {
                sqlConn.Open();
                MySqlCommand com = new MySqlCommand("iterateThrough", sqlConn);
                com.CommandType = CommandType.StoredProcedure;
                //int i = 1;

                //com.Parameters.Add(new MySqlParameter("p_LName", dataGridView3.SelectedRows[i].Cells[0].Value.ToString()));
                //com.Parameters.Add(new MySqlParameter("p_FName", dataGridView3.SelectedRows[i].Cells[1].Value.ToString()));
                //com.Parameters.Add(new MySqlParameter("p_CName", dataGridView3.SelectedRows[i].Cells[2].Value.ToString()));
                //com.Parameters.Add(new MySqlParameter("p_fee_cost", dataGridView3.SelectedRows[i].Cells[4].Value.ToString()));
                //com.Parameters.Add(new MySqlParameter("p_money_owing", dataGridView3.SelectedRows[i].Cells[3].Value.ToString()));
                //com.Parameters.Add(new MySqlParameter("teacherExists", MySqlDbType.Int32));
                //com.Parameters["teacherExists"].Direction = ParameterDirection.Output;

                com.ExecuteNonQuery();

                //int teacherExists = (int)com.Parameters["teacherExists"].Value;
                // teacherExist(teacherExists);
                com.Connection.Close();
                sqlConn.Close();

                upLoadOwingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curIndex = searchBox.SelectedIndex;
            if (curIndex == 2)
            {
                searchTxb.Hide();
                groupComboBox.Show();
                //label7.Hide();
            }
        }


        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gCurIndex = groupComboBox.SelectedIndex;
            DataView dv = sqlDt2.DefaultView;
            if (searchBox.SelectedIndex == 2)
            {
                dv.RowFilter = string.Format("className like '%{0}%'", groupComboBox.Text);
            }
            else if (searchBox.SelectedIndex == 0)
            {
                //dv.RowFilter = string.Format("studlname like '%{0}%'", searchTxb.Text);
            }
            dataGridView2.DataSource = dv.ToTable();
            int sum = 0;
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                sum += Convert.ToInt32(r.Cells[6].Value);
            }
            label7.Text = "Общий долг - " + sum;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            DataView dv = sqlDt2.DefaultView;

            dv.RowFilter = string.Format("paymentPendingAmt > 0");
            dataGridView2.DataSource = dv.ToTable();
        }

        private void searchTxb_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void payDebt_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "Update schooldb.payment set paymentPendingAmt = @penAmt, s.studLName = @studLName, s.studStartDay = @startDay, s.studAge = @studAge, sc.classID = @group, p.parentFName = @parentFName, p.parentPhone = @parentPhone where studID = @studID";

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@studID", dataGridView1.Rows[rowindex].Cells[0].Value.ToString());


                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                upLoadData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            try
            {
                sqlConn.Open();

                MySqlCommand cmd = new MySqlCommand("addFee", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("p_sLName", lName.Text));
                cmd.Parameters.Add(new MySqlParameter("p_sFName", fName.Text));
                cmd.Parameters.Add(new MySqlParameter("p_date", pDate.Text));
                cmd.Parameters.Add(new MySqlParameter("p_amt", amt.Text));
                cmd.Parameters.Add(new MySqlParameter("p_class", gBox.Text));
                cmd.Parameters.Add(new MySqlParameter("p_fees", feesBox.Text));

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlConn.Close();
            }
            // upLoadPData();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DateTime temp;
                lastNameTxb.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                firstNameTxb.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                paymentDateTxb.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                AmountTxb.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                groupBox.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                feesTxb.Text = dataGridView2.SelectedRows[0].Cells[9].Value.ToString();
                frostTxb.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;
            sqlConn.Open();

            try
            {
                MySqlCommand com = new MySqlCommand("updateFee", sqlConn);
                com.CommandType = CommandType.StoredProcedure;
                int rowindex = dataGridView2.CurrentCell.RowIndex;
                com.Parameters.Add(new MySqlParameter("p_Date", paymentDateTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_Amt", AmountTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_Frost", frostTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_Fees", feesTxb.Text));
                com.Parameters.Add(new MySqlParameter("p_penAmt", dataGridView2.Rows[rowindex].Cells[6].Value.ToString()));
                com.Parameters.Add(new MySqlParameter("p_id", dataGridView2.Rows[rowindex].Cells[3].Value.ToString()));

                com.ExecuteNonQuery();
                com.Connection.Close();

                sqlConn.Close();
                upLoadPData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletePayment_Click(object sender, EventArgs e)
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

                    sqlCmd.CommandText = "delete from schooldb.payment where paymentID = @paymentID";

                    int rowindex = dataGridView2.CurrentCell.RowIndex;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@paymentID", dataGridView1.Rows[rowindex].Cells[3].Value.ToString());

                    sqlCmd.ExecuteNonQuery();
                    sqlConn.Close();

                    foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                    {
                        dataGridView2.Rows.RemoveAt(item.Index);
                    }

                    upLoadPData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
