using System;
using System.Windows.Forms;

namespace InventoryManagementSystem

{
    public partial class RegistrationGUI2 : Form
    {
        public RegistrationGUI2()
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

        public Boolean retVal = false;
        private void button2_Click(object sender, EventArgs e)
        {
            retVal = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Please enter username.", "ERROR", MessageBoxButtons.OK);
                return;
            }

            else if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Please enter email.", "ERROR", MessageBoxButtons.OK);
                return;
            }

            else if (string.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                MessageBox.Show("Please enter phone number.", "ERROR", MessageBoxButtons.OK);
                return;
            }

            else if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please enter password.", "ERROR", MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(tbCPassword.Text))
            {
                MessageBox.Show("Please enter confirm password.", "ERROR", MessageBoxButtons.OK);
                return;
            }

            else if (tbPassword.Text != tbCPassword.Text)
            {
                MessageBox.Show("Password does not match. Try again.", "ERROR", MessageBoxButtons.OK);
                return;
            }
            try
            {

                User u = new User();

                u.name = tbUsername.Text;
                u.email = tbEmail.Text;
                u.phoneNumber = tbPhoneNumber.Text;
                u.password = tbPassword.Text;

                sqldata.UpdateAcc(u);
            }

            catch (Exception)
            {
                MessageBox.Show("Registration failure. Try again later.", "ERROR", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
