namespace Nursery_management
{
    partial class Kurram_Form
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
            this.FNF_Alizai_button = new System.Windows.Forms.Button();
            this.FNF_Parachinar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FNF_Alizai_button
            // 
            this.FNF_Alizai_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FNF_Alizai_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNF_Alizai_button.Location = new System.Drawing.Point(2, 23);
            this.FNF_Alizai_button.Name = "FNF_Alizai_button";
            this.FNF_Alizai_button.Size = new System.Drawing.Size(215, 47);
            this.FNF_Alizai_button.TabIndex = 3;
            this.FNF_Alizai_button.Text = "FNF Alizai";
            this.FNF_Alizai_button.UseVisualStyleBackColor = false;
            // 
            // FNF_Parachinar_button
            // 
            this.FNF_Parachinar_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FNF_Parachinar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNF_Parachinar_button.Location = new System.Drawing.Point(2, 147);
            this.FNF_Parachinar_button.Name = "FNF_Parachinar_button";
            this.FNF_Parachinar_button.Size = new System.Drawing.Size(215, 47);
            this.FNF_Parachinar_button.TabIndex = 4;
            this.FNF_Parachinar_button.Text = "FNF Parachinar";
            this.FNF_Parachinar_button.UseVisualStyleBackColor = false;
            // 
            // Kurram_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nursery_management.Properties.Resources.kurram1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FNF_Parachinar_button);
            this.Controls.Add(this.FNF_Alizai_button);
            this.Name = "Kurram_Form";
            this.Text = "Kurram";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FNF_Alizai_button;
        private System.Windows.Forms.Button FNF_Parachinar_button;
    }
}