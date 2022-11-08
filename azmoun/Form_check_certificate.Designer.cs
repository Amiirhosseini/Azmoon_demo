namespace azmoun
{
    partial class Form_check_certificate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_print = new System.Windows.Forms.Button();
            this.button_save_as = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_print);
            this.panel1.Controls.Add(this.button_save_as);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 166);
            this.panel1.TabIndex = 0;
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(38, 105);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(93, 37);
            this.button_print.TabIndex = 1;
            this.button_print.Text = "پرینت";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_save_as
            // 
            this.button_save_as.Location = new System.Drawing.Point(38, 23);
            this.button_save_as.Name = "button_save_as";
            this.button_save_as.Size = new System.Drawing.Size(93, 37);
            this.button_save_as.TabIndex = 0;
            this.button_save_as.Text = "ذخیره در";
            this.button_save_as.UseVisualStyleBackColor = true;
            this.button_save_as.Click += new System.EventHandler(this.button_save_as_Click);
            // 
            // Form_check_certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 236);
            this.Controls.Add(this.panel1);
            this.Name = "Form_check_certificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "چک کردن گواهی";
            this.Load += new System.EventHandler(this.Form_check_certificate_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_save_as;
    }
}