using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace azmoun
{
    public partial class Form_CRUD_Admin : Form
    {
        public Form_CRUD_Admin()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            if (comboBox_select_catecory.SelectedValue.ToString() == "Pressure")
            {
                AzmounEntities Db = new AzmounEntities();
                dataGridView1.DataSource = Db.Presure_device.ToList();
            }
        }

        private void Form_CRUD_Admin_Load(object sender, EventArgs e)
        {
            button_delete.Enabled = false;
            button_insert.Enabled = false;
            AzmounEntities db = new AzmounEntities();
            var query = db.Instruments_category.Select(c => new { c.Device_category }).Distinct();
            comboBox_select_catecory.DataSource = query.ToList();
            dataGridView1.ReadOnly = true;
            Refresh();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                using (AzmounEntities Db = new AzmounEntities())
                {
                    //    Db.Presure_device.SqlQuery("delete from Presure_device where Id = " +
                    //                               dataGridView1.SelectedRows[0].Cells[0].ToString());

                    var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    var pd = Db.Presure_device.First(x =>
                        x.Id == id);
                    Db.Presure_device.Remove(pd);
                    Db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("لطفا گزینه‌ای انتخاب نمایید");
            }
            Refresh();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            class_device_info.category_insert = comboBox_select_catecory.SelectedValue.ToString();
            this.Hide();
            var form_insert = new Form_insert_device();
            form_insert.Closed += (s, args) => this.Show();
            form_insert.Show();
        }

        private void comboBox_select_catecory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Refresh();
        }

        private void comboBox_select_catecory_Click(object sender, EventArgs e)
        {
            button_delete.Enabled = true;
            button_insert.Enabled = true;
        }

        private void Form_CRUD_Admin_Shown(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form_CRUD_Admin_Activated(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
