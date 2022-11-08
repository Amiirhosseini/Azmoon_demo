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
    public partial class Form_info_colibration : Form
    {
        public Form_info_colibration()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.SelectedRows.Count == 1)
            {
                class_device_info.colibrationID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                class_device_info.step = 0;
                this.Close();
            }
            else
            {
                MessageBox.Show("!لطفا مشخصات را انتخاب کنید");
            }
        }

        private void Form_info_colibration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'azmounDataSet.Colibrations' table. You can move, or remove it, as needed.
            this.colibrationsTableAdapter.Fill(this.azmounDataSet.Colibrations);
            AzmounEntities Db = new AzmounEntities();

            dataGridView1.DataSource = Db.Colibrations.ToList();
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.MultiSelect=false;
        }
    }
}
