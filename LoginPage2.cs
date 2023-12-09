
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem
{
    public partial class LoginPage2 : Form

    {
        List<User> loginuser = new List<User>();
        public LoginPage2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public Boolean open = false;

        private void button1_Click_1(object sender, EventArgs e)
        {
            User u = new User();
            u.name = tbUsername.Text;
            u.password = tbPassword.Text;

            if (u.name.Length == 0 || u.password.Length == 0)
            {
                MessageBox.Show("Please type username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sqldata.ValidateUser(u))
            {
                // if naa ang user sa database
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                homePage obj = new homePage ();
                obj.ShowDialog();
                this.Hide();

                if(obj.close == true)
                {
                    this.Show();
                }
                // sunod sa login
            }
            else
            {
                // way account
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean switchRegister = false;
        
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationGUI2 obj = new RegistrationGUI2();
            obj.ShowDialog();
            this.Hide();
            if (obj.retVal==true)
            {
                
                this.Show();
                
            }

    
            /*
            switchRegister = true;
            this.Close();
            */
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
        }
        public Boolean close = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }

        private void LoginPage2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
