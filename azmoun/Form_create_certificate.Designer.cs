namespace azmoun
{
    partial class Form_create_certificate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_show_chart = new System.Windows.Forms.Button();
            this.button_excel_out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 534);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_ok);
            this.panel1.Location = new System.Drawing.Point(829, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 117);
            this.panel1.TabIndex = 1;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(73, 37);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(108, 45);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "تایید";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.button_show_chart);
            this.panel2.Controls.Add(this.button_excel_out);
            this.panel2.Location = new System.Drawing.Point(12, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 117);
            this.panel2.TabIndex = 2;
            // 
            // button_show_chart
            // 
            this.button_show_chart.Location = new System.Drawing.Point(117, 37);
            this.button_show_chart.Name = "button_show_chart";
            this.button_show_chart.Size = new System.Drawing.Size(108, 45);
            this.button_show_chart.TabIndex = 2;
            this.button_show_chart.Text = "نمایش نمودار";
            this.button_show_chart.UseVisualStyleBackColor = true;
            this.button_show_chart.Click += new System.EventHandler(this.button_show_chart_Click_1);
            // 
            // button_excel_out
            // 
            this.button_excel_out.Location = new System.Drawing.Point(3, 37);
            this.button_excel_out.Name = "button_excel_out";
            this.button_excel_out.Size = new System.Drawing.Size(108, 45);
            this.button_excel_out.TabIndex = 0;
            this.button_excel_out.Text = "خروجی اکسل";
            this.button_excel_out.UseVisualStyleBackColor = true;
            this.button_excel_out.Click += new System.EventHandler(this.button_excel_out_Click);
            // 
            // Form_create_certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 677);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_create_certificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_create_certificate";
            this.Load += new System.EventHandler(this.Form_create_certificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_excel_out;
        private System.Windows.Forms.Button button_show_chart;
    }
}