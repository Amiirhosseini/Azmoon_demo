
namespace azmoun
{
    partial class Form_start_colibration
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_instrument = new System.Windows.Forms.DataGridView();
            this.comboBox_select_catecory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start_colibration = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_refrence = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_instrument)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_refrence)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView_instrument);
            this.panel1.Controls.Add(this.comboBox_select_catecory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 377);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "دسته بندی دستگاه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "انتخاب از بین دستگاه‌های موجود";
            // 
            // dataGridView_instrument
            // 
            this.dataGridView_instrument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_instrument.Location = new System.Drawing.Point(3, 125);
            this.dataGridView_instrument.Name = "dataGridView_instrument";
            this.dataGridView_instrument.ReadOnly = true;
            this.dataGridView_instrument.RowHeadersWidth = 51;
            this.dataGridView_instrument.RowTemplate.Height = 24;
            this.dataGridView_instrument.Size = new System.Drawing.Size(758, 232);
            this.dataGridView_instrument.TabIndex = 2;
            // 
            // comboBox_select_catecory
            // 
            this.comboBox_select_catecory.DisplayMember = "Device_category";
            this.comboBox_select_catecory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select_catecory.FormattingEnabled = true;
            this.comboBox_select_catecory.Location = new System.Drawing.Point(429, 19);
            this.comboBox_select_catecory.Name = "comboBox_select_catecory";
            this.comboBox_select_catecory.Size = new System.Drawing.Size(174, 24);
            this.comboBox_select_catecory.TabIndex = 1;
            this.comboBox_select_catecory.ValueMember = "Device_category";
            this.comboBox_select_catecory.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_catecory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "دسته بندی دستگاه";
            // 
            // button_start_colibration
            // 
            this.button_start_colibration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_start_colibration.Location = new System.Drawing.Point(322, 703);
            this.button_start_colibration.Name = "button_start_colibration";
            this.button_start_colibration.Size = new System.Drawing.Size(102, 56);
            this.button_start_colibration.TabIndex = 1;
            this.button_start_colibration.Text = "شروع کالیبراسیون";
            this.button_start_colibration.UseVisualStyleBackColor = true;
            this.button_start_colibration.Click += new System.EventHandler(this.button_start_colibration_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView_refrence);
            this.panel2.Location = new System.Drawing.Point(12, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 294);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "انتخاب دستگاه مرجع از بین دستگاه‌های موجود";
            // 
            // dataGridView_refrence
            // 
            this.dataGridView_refrence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_refrence.Location = new System.Drawing.Point(0, 59);
            this.dataGridView_refrence.Name = "dataGridView_refrence";
            this.dataGridView_refrence.ReadOnly = true;
            this.dataGridView_refrence.RowHeadersWidth = 51;
            this.dataGridView_refrence.RowTemplate.Height = 24;
            this.dataGridView_refrence.Size = new System.Drawing.Size(758, 232);
            this.dataGridView_refrence.TabIndex = 2;
            // 
            // Form_start_colibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 794);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_start_colibration);
            this.Controls.Add(this.panel1);
            this.Name = "Form_start_colibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب مشخصات اصلی دستگاه";
            this.Load += new System.EventHandler(this.Form_start_colibration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_instrument)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_refrence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_select_catecory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_instrument;
        private System.Windows.Forms.Button button_start_colibration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_refrence;
        private System.Windows.Forms.Label label5;
    }
}