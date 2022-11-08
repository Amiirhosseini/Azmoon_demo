using Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace azmoun
{
    public partial class Form_check_certificate : Form
    {
        private Microsoft.Office.Interop.Word.Application app;
        private Microsoft.Office.Interop.Word.Document doc;
        public Form_check_certificate()
        {
            InitializeComponent();
        }
        void myForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            class_device_info.step = 5;
            doc.Close();
            app.Quit();
        }

        private void Form_check_certificate_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(myForm_FormClosing);

            string path = Path.GetDirectoryName(Assembly.GetAssembly(typeof(Program)).Location);

            DataTable dt = class_device_info.values.ExportDataTable();

            path += "\\Sources\\00-P-2487.docx";
            app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = true;

            doc = app.Documents.Add(path);
            doc.Activate();


            Table tbl1 = doc.Tables[4];
            Table tbl2 = doc.Tables[5];


            for (int i = 1; i < dt.Rows.Count; i++)
            {

                tbl1.Rows.Add();
                tbl2.Rows.Add();
            }


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                tbl1.Cell(i + 4, 7).Range.Text = dt.Rows[i][0].ToString();
                tbl1.Cell(i + 4, 6).Range.Text = dt.Rows[i][1].ToString();
                tbl1.Cell(i + 4, 5).Range.Text = dt.Rows[i][2].ToString();
                tbl1.Cell(i + 4, 4).Range.Text = dt.Rows[i][3].ToString();
                tbl1.Cell(i + 4, 3).Range.Text = dt.Rows[i][4].ToString();
                tbl1.Cell(i + 4, 2).Range.Text = dt.Rows[i][5].ToString();
                tbl1.Cell(i + 4, 1).Range.Text = dt.Rows[i][6].ToString();

                tbl2.Cell(i + 3, 6).Range.Text = dt.Rows[i][7].ToString();
                tbl2.Cell(i + 3, 5).Range.Text = dt.Rows[i][8].ToString();
                tbl2.Cell(i + 3, 4).Range.Text = dt.Rows[i][9].ToString();
                tbl2.Cell(i + 3, 3).Range.Text = dt.Rows[i][10].ToString();
                tbl2.Cell(i + 3, 2).Range.Text = dt.Rows[i][11].ToString();
                tbl2.Cell(i + 3, 1).Range.Text = dt.Rows[i][18].ToString();
            }




            Microsoft.Office.Interop.Word.Find fnd = app.ActiveWindow.Selection.Find;

            fnd.ClearFormatting();
            fnd.Replacement.ClearFormatting();
            fnd.Forward = true;
            fnd.Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue;

            AzmounEntities db = new AzmounEntities();

            //var query = db.Colibrations.SqlQuery("select * from Colibrations where id=" +class_device_info.colibrationID.ToString());
            var query = db.Colibrations.Where(x => x.Id == class_device_info.colibrationID).ToList();

            var query2 = db.Presure_device.Where(x => x.Id == class_device_info.device_ID).ToList();

            fnd.Text = "Address:";
            fnd.Replacement.Text = "Address: " + query[0].Address;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "Customer name:";
            fnd.Replacement.Text = "Customer name: " + query[0].Customer_name;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Date of Calibration:";
            fnd.Replacement.Text = "Date of Calibration: " + query[0].Date_of_Calibration.ToString();
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Date of issue:";
            fnd.Replacement.Text = "Date of issue: " + query[0].Date_of_Calibration.ToString();
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Re-Cal. Date (Client):";
            fnd.Replacement.Text = "Re-Cal. Date (Client): " + query[0].Re_Calibration_Date.ToString();
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Location:";
            fnd.Replacement.Text = "Location:  " + query[0].Location;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Form No. :";
            fnd.Replacement.Text = "Form No. :  " + query[0].Form_number;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Instrument name:";
            fnd.Replacement.Text = "Instrument name:  " + query2[0].Device_name;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Resolution:";
            fnd.Replacement.Text = "Resolution:  " + query2[0].Resulation.ToString() + " bar";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "ID / Serial number: ";
            fnd.Replacement.Text = "ID / Serial number: " + query2[0].Serial_number;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Range of instrument:";
            fnd.Replacement.Text = "Range of instrument: " + query2[0].Min_range.ToString() + " ~ " + query2[0].Max_range.ToString() + " bar";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "Range of calibration:";
            fnd.Replacement.Text = "Range of calibration: " + query2[0].Min_range.ToString() + " ~ " + query2[0].Max_range.ToString() + " bar";
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Manufacturer:";
            fnd.Replacement.Text = "Manufacturer: " + query2[0].Manufacturer;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            fnd.Text = "Reception Number:";
            fnd.Replacement.Text = "Reception Number: " + query2[0].Reception_Number;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Certificate Number:";
            fnd.Replacement.Text = "Certificate Number: " + query[0].Certificate_Number;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);


            fnd.Text = "Calibration Condition:";
            fnd.Replacement.Text = "Calibration Condition: " + query[0].Calibration_Condition;
            fnd.Execute(Replace: Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);

            //  doc.SaveAs2(@"C:\Users\Amir\Desktop\New folder");

            // doc.PrintOut();

        }

        private void button_save_as_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word files (*.docx)|*.docx";
            saveFileDialog1.Title = "Save an Word File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        string path = fs.Name;
                        fs.Close();
                        doc.SaveAs2(path);
                        break;
                }

            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            doc.PrintOut();
        }
    }
}
