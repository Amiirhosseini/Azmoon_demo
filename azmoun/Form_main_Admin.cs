using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azmoun
{
    public partial class Form_main_Admin : Form
    {
        public Form_main_Admin()
        {
            InitializeComponent();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCreateCertificate = new Form_create_certificate();
            formCreateCertificate.Closed += (s, args) => this.Show();
            formCreateCertificate.Show();
        }

        private void Button_start_colibration_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formStartColibration = new Form_start_colibration();
            formStartColibration.Closed += (s, args) => this.Show();
            formStartColibration.Show();
        }

        private void Form_main_Admin_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString(new System.Globalization.CultureInfo("Fa-ir")).ToString();
            var newSplit = date.Split(' ');
            label_time.Text = newSplit[1];
            label_date.Text = newSplit[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == timer1)
            {
                string date = DateTime.Now.ToString(new System.Globalization.CultureInfo("Fa-ir")).ToString();
                var newSplit = date.Split(' ');
                label_time.Text = newSplit[1];
                label_date.Text = newSplit[0];

                switch (class_device_info.step)
                {
                    case 0:
                        toolStripProgressBar0.Value = 100;
                        break;
                    case 1:
                        toolStripProgressBar0.Value = 100;
                        toolStripProgressBar1.Value = 100;
                        break;
                    case 2:
                        toolStripProgressBar0.Value = 100;
                        toolStripProgressBar1.Value = 100;
                        toolStripProgressBar2.Value = 100;
                        break;
                    case 3:
                        toolStripProgressBar0.Value = 100;
                        toolStripProgressBar1.Value = 100;
                        toolStripProgressBar2.Value = 100;
                        toolStripProgressBar3.Value = 100;
                        break;
                    case 4:
                        toolStripProgressBar0.Value = 100;
                        toolStripProgressBar1.Value = 100;
                        toolStripProgressBar2.Value = 100;
                        toolStripProgressBar3.Value = 100;
                        toolStripProgressBar4.Value = 100;
                        break;
                    case 5:
                        toolStripProgressBar0.Value = 100;
                        toolStripProgressBar1.Value = 100;
                        toolStripProgressBar2.Value = 100;
                        toolStripProgressBar3.Value = 100;
                        toolStripProgressBar4.Value = 100;
                        break;

                }
            }
        }

        private void button_insert_data_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formInsertData = new Form_insert_data();
            formInsertData.Closed += (s, args) => this.Show();
            formInsertData.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCrudAdmin = new Form_CRUD_Admin();
            formCrudAdmin.Closed += (s, args) => this.Show();
            formCrudAdmin.Show();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCheckCertificate = new Form_check_certificate();
            formCheckCertificate.Closed += (s, args) => this.Show();
            formCheckCertificate.Show();
        }

        private void toolStripButton_info_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formInfoColibration = new Form_info_colibration();
            formInfoColibration.Closed += (s, args) => this.Show();
            formInfoColibration.Show();
        }

        private void toolStripButton_CRUD_refrence_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCrudRefrence = new Form_CRUD_refrence();
            formCrudRefrence.Closed += (s, args) => this.Show();
            formCrudRefrence.Show();
        }
    }
}
