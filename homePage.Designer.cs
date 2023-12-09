namespace InventoryManagementSystem
{
    partial class homePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bAccount = new System.Windows.Forms.Button();
            this.bInventory = new System.Windows.Forms.Button();
            this.bEmployee = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bLogout = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bLogout);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.bEmployee);
            this.panel1.Controls.Add(this.bInventory);
            this.panel1.Controls.Add(this.bAccount);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 603);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(188, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(827, 95);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(0, 268);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 63);
            this.panel7.TabIndex = 26;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(189, 92);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // bAccount
            // 
            this.bAccount.FlatAppearance.BorderSize = 0;
            this.bAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAccount.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAccount.Image = ((System.Drawing.Image)(resources.GetObject("bAccount.Image")));
            this.bAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAccount.Location = new System.Drawing.Point(0, 111);
            this.bAccount.Name = "bAccount";
            this.bAccount.Size = new System.Drawing.Size(189, 44);
            this.bAccount.TabIndex = 28;
            this.bAccount.Text = "      ACCOUNT";
            this.bAccount.UseVisualStyleBackColor = true;
            // 
            // bInventory
            // 
            this.bInventory.FlatAppearance.BorderSize = 0;
            this.bInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInventory.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInventory.Image = ((System.Drawing.Image)(resources.GetObject("bInventory.Image")));
            this.bInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bInventory.Location = new System.Drawing.Point(0, 172);
            this.bInventory.Name = "bInventory";
            this.bInventory.Size = new System.Drawing.Size(189, 44);
            this.bInventory.TabIndex = 29;
            this.bInventory.Text = "      INVENTORY";
            this.bInventory.UseVisualStyleBackColor = true;
            // 
            // bEmployee
            // 
            this.bEmployee.FlatAppearance.BorderSize = 0;
            this.bEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEmployee.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEmployee.Image = ((System.Drawing.Image)(resources.GetObject("bEmployee.Image")));
            this.bEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEmployee.Location = new System.Drawing.Point(0, 240);
            this.bEmployee.Name = "bEmployee";
            this.bEmployee.Size = new System.Drawing.Size(186, 44);
            this.bEmployee.TabIndex = 29;
            this.bEmployee.Text = "     EMPLOYEE";
            this.bEmployee.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 44);
            this.button4.TabIndex = 29;
            this.button4.Text = "    HISTORY";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bLogout
            // 
            this.bLogout.FlatAppearance.BorderSize = 0;
            this.bLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogout.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogout.Image = ((System.Drawing.Image)(resources.GetObject("bLogout.Image")));
            this.bLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLogout.Location = new System.Drawing.Point(0, 350);
            this.bLogout.Name = "bLogout";
            this.bLogout.Size = new System.Drawing.Size(189, 44);
            this.bLogout.TabIndex = 30;
            this.bLogout.Text = "     LOG OUT";
            this.bLogout.UseVisualStyleBackColor = true;
            this.bLogout.Click += new System.EventHandler(this.bLogout_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(771, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(796, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 602);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bAccount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bEmployee;
        private System.Windows.Forms.Button bInventory;
        private System.Windows.Forms.Button bLogout;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}