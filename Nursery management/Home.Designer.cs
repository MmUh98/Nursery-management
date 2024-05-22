namespace Nursery_management
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Districts_button = new System.Windows.Forms.Button();
            this.Admin_button = new System.Windows.Forms.Button();
            this.About_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.About_button);
            this.panel1.Controls.Add(this.Admin_button);
            this.panel1.Controls.Add(this.Districts_button);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 318);
            this.panel1.TabIndex = 0;
            // 
            // Districts_button
            // 
            this.Districts_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Districts_button.Image = ((System.Drawing.Image)(resources.GetObject("Districts_button.Image")));
            this.Districts_button.Location = new System.Drawing.Point(0, 102);
            this.Districts_button.Name = "Districts_button";
            this.Districts_button.Size = new System.Drawing.Size(143, 33);
            this.Districts_button.TabIndex = 1;
            this.Districts_button.Text = "Districts";
            this.Districts_button.UseVisualStyleBackColor = true;
            // 
            // Admin_button
            // 
            this.Admin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_button.Image = ((System.Drawing.Image)(resources.GetObject("Admin_button.Image")));
            this.Admin_button.Location = new System.Drawing.Point(0, 169);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(143, 33);
            this.Admin_button.TabIndex = 2;
            this.Admin_button.Text = "Adminstration";
            this.Admin_button.UseVisualStyleBackColor = true;
            this.Admin_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // About_button
            // 
            this.About_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_button.Image = ((System.Drawing.Image)(resources.GetObject("About_button.Image")));
            this.About_button.Location = new System.Drawing.Point(0, 236);
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(143, 33);
            this.About_button.TabIndex = 3;
            this.About_button.Text = "About Us";
            this.About_button.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 133);
            this.panel2.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Districts_button;
        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button About_button;
        private System.Windows.Forms.Panel panel2;
    }
}