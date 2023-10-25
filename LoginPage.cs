
using softwaredesign;
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
    public partial class LoginPage : Form
    {
        List<User> loginuser = new List<User>();
        public LoginPage()
        {
            InitializeComponent();
     
        }
      

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
      
        

        
        public Boolean open = false;
        private void EnterButton_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.name = tbUsername.Text;
            u.password = tbPassword.Text;

            if (sqldata.ValidateUser(u))
            {
                // if naa ang user sa database
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // sunod sa login
            }
            else
            {
                // way account
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public Boolean switchRegister = false;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switchRegister = true;
            this.Close();
           
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnterButton_Click(sender, e);
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnterButton_Click(sender, e);
            }
        }

        public Boolean close = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }
    }
}
