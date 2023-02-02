using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseLP
{
    public partial class LogInForm : Form
    {
        bool userChangedName, userChangedPassword = false;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       /* private void panel2_MouseHover(object sender, EventArgs e)
        {
                textBox1.Text = "";
        }
       */

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && usernameTextBox.Text != "Enter Username")
            {
                userChangedName = true;
                usernameTextBox.ForeColor = Color.Black;
            }

            else
            {
                userChangedName = false;
                usernameTextBox.ForeColor = SystemColors.ControlDark;
            }
        }

        private void usernameTextBox_MouseHover(object sender, EventArgs e)
        {
            textChanged(userChangedName, usernameTextBox);
        }

        private void usernameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if(userChangedName == false)
                usernameTextBox.Text = "Enter Username";
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "" && passwordTextBox.Text != "Enter Password")
            {
                userChangedPassword = true;
                passwordTextBox.ForeColor = Color.Black;
            }

            else
            {
                userChangedPassword = false;
                passwordTextBox.ForeColor = SystemColors.ControlDark;
            }
        }

        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (userChangedPassword == false)
                passwordTextBox.Text = "Enter Password";
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "a" && passwordTextBox.Text == "a")
            {
                this.Hide();
                Form f2 = new mainForm();
                f2.ShowDialog();
            }
        }

        private void passwordTextBox_MouseHover(object sender, EventArgs e)
        {
            textChanged(userChangedPassword, passwordTextBox);
        }

        private void textChanged (bool passedString, TextBox passedTextBoxName)
        {
            if (passedString == false)
            {
                passedTextBoxName.Text = "";
            }
        }


    }
}

/* Добавить фичи
 * 1) Underline
   2) Make form draggable
   3) reduce code by adding functions
 */