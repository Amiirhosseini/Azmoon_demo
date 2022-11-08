using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace azmoun
{
    public partial class Form_insert_device : Form
    {
        public Form_insert_device()
        {
            InitializeComponent();
        }

        private void hidden_all()
        {
            groupBox_pressure.Hide();
        }

        private void Form_insert_Load(object sender, EventArgs e)
        {
            comboBox_mode.DropDownStyle=ComboBoxStyle.DropDownList;
            hidden_all();   
            var category = class_device_info.category_insert;

            if (category=="Pressure")
            {
                groupBox_pressure.Show();
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            bool sucsess_flag = false;
            if (class_device_info.category_insert == "Pressure")
            {
                Presure_device pd = new Presure_device();
                pd.Device_type=class_device_info.category_insert;
                pd.Device_name = textBox_device_name.Text;
                //pd.Mode = comboBox_mode.SelectedValue.ToString();
                //pd.Mode = "Pneumatic";
                int selected= comboBox_mode.SelectedIndex;
                switch (selected)
                {
                    case 0:
                        pd.Mode = "Hydraulic";
                        break;
                    case 1:
                        pd.Mode = "Pneumatic";
                        break;
                }
                pd.Class = Convert.ToInt32(textBox_class.Text);
                pd.Min_range = Convert.ToDouble(textBox_min_range.Text);
                pd.Max_range = Convert.ToDouble(textBox_max_range.Text);
                pd.Resulation = Convert.ToDouble(textBox_resulation.Text);
                pd.Serial_number=textBox_serial_number.Text;
                pd.Manufacturer=textBox_manufacturer.Text;
                pd.Reception_Number=textBox_reception_number.Text;

                if (!(textBox_device_name.Text == String.Empty || textBox_resulation.Text == String.Empty ||
                    textBox_min_range.Text==String.Empty))
                {
                    AzmounEntities db = new AzmounEntities();
                    db.Presure_device.Add(pd);
                    db.SaveChanges();
                    sucsess_flag = true;
                }
                else
                {
                    MessageBox.Show("لطفا تمامی مقادیر را وارد کنید");
                }
            }

            if (sucsess_flag == true)
            {
                this.Close();
            }
        }
    }
}
