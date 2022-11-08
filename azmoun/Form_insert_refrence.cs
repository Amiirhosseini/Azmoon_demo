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
    public partial class Form_insert_refrence : Form
    {
        public Form_insert_refrence()
        {
            InitializeComponent();
        }

        private void groupBox_pressure_Enter(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            bool sucsess_flag = false;
            
                Refrences refrence = new Refrences();
                refrence.Name = textBox_device_name.Text;
                refrence.category = textBox_Category.Text;
                refrence.Accuracy = Convert.ToDouble(textBox_Accuracy.Text);
                refrence.Accuracy_unit = textBox_Accuracy_unit.Text;
                refrence.Min_range = Convert.ToDouble(textBox_min_range.Text);
                refrence.Max_range= Convert.ToDouble(textBox_max_range.Text);
                refrence.Range_unit = textBox_range_unit.Text;
                

                if (!(textBox_device_name.Text == String.Empty || textBox_Accuracy.Text == String.Empty ||
                      textBox_min_range.Text == String.Empty))
                {
                    AzmounEntities db = new AzmounEntities();
                    db.Refrences.Add(refrence);
                    db.SaveChanges();
                    sucsess_flag = true;
                }
                else
                {
                    MessageBox.Show("لطفا تمامی مقادیر را وارد کنید");
                }
            

            if (sucsess_flag == true)
            {
                this.Close();
            }
        }
    }
}
