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

    
    public partial class mainForm : Form
    {
        int panelWidth;
        bool hidden;

        Bitmap bitmap;

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlConnection sqlConn2 = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        MySqlCommand sqlCmd2 = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;
        MySqlDataReader sqlRd2;

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
            sqlCmd.CommandText = "SELECT * FROM schooldb.student";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
        }
        public mainForm()
        {
            InitializeComponent();
            panelWidth = panelSlides.Width;
            hidden = false;
            homebtn.FlatAppearance.BorderSize = 0;
            studentsBtn.FlatAppearance.BorderSize = 0;
            feesBtn.FlatAppearance.BorderSize = 0;
            subjectsBtn.FlatAppearance.BorderSize = 0;
            groupsBtn.FlatAppearance.BorderSize = 0;
            teachersBtn.FlatAppearance.BorderSize = 0;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            getInfo();
        }

        private void getInfo()
        {
            sqlConn2.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database ="
                + database;

            sqlConn2.Open();
            try
            {
                sqlCmd2.Connection = sqlConn2;
                sqlCmd2.CommandText = "SELECT COUNT(*) FROM student;";
                
                sqlRd2 = sqlCmd2.ExecuteReader();
                //parentPhone FROM student s JOIN parent p ON s.parentID = p.parentID

                //int studQty
                sqlRd2.Close();
                string studQty = sqlCmd2.ExecuteScalar() + "";
                stQty.Text = studQty + "";

                sqlCmd2.CommandText = "SELECT COUNT(*) FROM class;";
                sqlRd2 = sqlCmd2.ExecuteReader();
                sqlRd2.Close();
                string clsQty = sqlCmd2.ExecuteScalar() + "";
                classQty.Text = clsQty + "";

                sqlCmd2.CommandText = "SELECT COUNT(*) FROM teacher;";
                sqlRd2 = sqlCmd2.ExecuteReader();
                sqlRd2.Close();
                string teacherQty = sqlCmd2.ExecuteScalar() + "";
                tchQty.Text = teacherQty + "";

                sqlCmd2.CommandText = "SELECT COUNT(*) FROM course;";
                sqlRd2 = sqlCmd2.ExecuteReader();
                sqlRd2.Close();
                string courseQty = sqlCmd2.ExecuteScalar() + "";
                sbjQty.Text = courseQty + "";

                sqlConn2.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            main.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fees frm = new fees();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            students frm = new students();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(hidden)
            {
                panelSlides.Width = panelSlides.Width + 5;
                if(panelSlides.Width >= panelWidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();

                }
            }
            else
            {
                panelSlides.Width = panelSlides.Width - 5;
                if(panelSlides.Width <= 90)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
            }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teachersBtn_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groups frm = new groups();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void subjectsBtn_Click(object sender, EventArgs e)
        {
            courses frm = new courses();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void teachersBtn_Click_1(object sender, EventArgs e)
        {
            teachers frm = new teachers();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void waitlistBtn_Click(object sender, EventArgs e)
        {
            waitlist frm = new waitlist();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
    }
