using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace azmoun
{
    public partial class Form_insert_data : Form
    {
        private Workbook workbook = new Workbook();

        
        public Form_insert_data()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            class_device_info.number_of_reads = Convert.ToInt32(numericUpDown1.Value);
            if (class_device_info.number_of_reads > 0)
            {
                numericUpDown1.Enabled=false;
                button_ok.Enabled=false;
              

                   Worksheet sheet = workbook.Worksheets[0];
                   sheet.Name = "sheet";


                   sheet.Range["A1"].Text = "M0 (bar)";
                   sheet.Range["B1"].Text = "M1 (bar)";
                   sheet.Range["C1"].Text = "M2 (bar)";
                   sheet.Range["D1"].Text = "M3 (bar)";
                   sheet.Range["E1"].Text = "M4 (bar)";

                   sheet.Range["A2:A" + (class_device_info.number_of_reads+1).ToString()].Text = String.Empty;
                    //workbook.SaveToFile("Sample.xls");

                    //System.Diagnostics.Process.Start(workbook.FileName);
                    DataTable dataTable =sheet.ExportDataTable();
                    this.dataGridView1.DataSource = dataTable;
               

             
                dataGridView1.Show();
                button_end.Show();
            }
            else
            {
                MessageBox.Show("!لطفا مقدار را صحیح وارد کنید");
            }
        }

        private void Form_insert_data_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            button_end.Hide();
            switch (class_device_info.mode)
            {
                case "Pneumatic":
                    label2.Text = "نیوماتیکی";
                    break;
                case "Hydraulic":
                    label2.Text = "هیدرولیکی";
                    break;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //convert the datagrid source to datatable
            //Creating DataTable.
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }


            class_device_info.values= workbook.Worksheets[1];
            class_device_info.values.Name = "sheet_after_inserted";

            class_device_info.values.InsertDataTable(dt, true, 1, 1, -1, -1);
            
            class_device_info.step = 2;
            this.Close();
        }

        public DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            //Column
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            //Row
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dr[i] = row.Cells[i].Value.ToString();
                }
                dt.Rows.Add(dr);
            }
            decimal total = dataGridView1.SelectedRows.OfType<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells[2].Value));
            dt.Rows.Add("", "Total", total);
            return dt;
        }
    }


}
