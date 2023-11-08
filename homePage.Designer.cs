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
            this.lbHomepage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHomepage
            // 
            this.lbHomepage.AutoSize = true;
            this.lbHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomepage.Location = new System.Drawing.Point(323, 184);
            this.lbHomepage.Name = "lbHomepage";
            this.lbHomepage.Size = new System.Drawing.Size(140, 24);
            this.lbHomepage.TabIndex = 0;
            this.lbHomepage.Text = "HOME PAGE!";
            this.lbHomepage.Click += new System.EventHandler(this.label1_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHomepage);
            this.Name = "homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHomepage;
    }
}