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
    public partial class Form_CRUD_refrence : Form
    {
        public Form_CRUD_refrence()
        {
            InitializeComponent();
        }

         private void Refresh()
        {
            
                AzmounEntities Db = new AzmounEntities();
                dataGridView1.DataSource = Db.Refrences.ToList();
        }

        private void Form_CRUD_refrence_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            Refresh();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                using (AzmounEntities Db = new AzmounEntities())
                {

                    var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    var pd = Db.Refrences.First(x =>
                        x.Id == id);
                    Db.Refrences.Remove(pd);
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
            this.Hide();
            var form_insert_refrence = new Form_insert_refrence();
            form_insert_refrence.Closed += (s, args) => this.Show();
            form_insert_refrence.Show();
        }

        private void Form_CRUD_refrence_Activated(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
