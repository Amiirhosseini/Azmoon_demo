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

    public partial class Form_start_colibration : Form
    {
        
        public Form_start_colibration()
        {
            InitializeComponent();
        }

        private void button_start_colibration_Click(object sender, EventArgs e)
        {
            if (comboBox_select_catecory.SelectedIndex > -1 && dataGridView_instrument.SelectedRows.Count>0 && dataGridView_refrence.SelectedRows.Count>0 )
            {

                class_device_info.device_ID= Convert.ToInt32(dataGridView_instrument.SelectedRows[0].Cells[0].Value);

                class_device_info.step = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("!لطفا دستگاه ها را انتخاب کنید");
            }
        }

        private void Form_start_colibration_Load(object sender, EventArgs e)
        {
            dataGridView_instrument.ReadOnly = true;
            dataGridView_refrence.ReadOnly = true;
            dataGridView_instrument.MultiSelect = false;
            dataGridView_refrence.MultiSelect = false;

            if (class_device_info.device_ID!=-1 || class_device_info.category!=String.Empty || class_device_info.refence_ID!=-1)
            {
                this.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید از اول فرايند را آغاز کنید؟","بله یا خیر", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    class_device_info.reset();
                    this.Enabled = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                   this.Close(); 
                }
            }

            using (AzmounEntities db = new AzmounEntities())
            {
                var query = db.Instruments_category.Select(c => new { c.Device_category }).Distinct();
                comboBox_select_catecory.DataSource = query.ToList();
                dataGridView_refrence.DataSource = db.Refrences.ToList();
            }

            
            
        }

        private void comboBox_select_catecory_SelectedIndexChanged(object sender, EventArgs e)
        {

                 dataGridView_instrument.DataSource = null;

                AzmounEntities db = new AzmounEntities();
            

                class_device_info.category = comboBox_select_catecory.SelectedValue.ToString();

                if (class_device_info.category == "Pressure")
                {
                    dataGridView_instrument.DataSource = db.Presure_device.ToList();
                }
            
        }
    }
}
