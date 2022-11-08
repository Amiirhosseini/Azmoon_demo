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
using Spire.Xls.Charts;
using Spire.Xls.Core;

namespace azmoun
{
    public partial class Form_create_certificate : Form
    {
       private Workbook workbook = new Workbook();

        public Form_create_certificate()
        {
            InitializeComponent();
        }

        private void Form_create_certificate_Load(object sender, EventArgs e)
        {
            //Worksheet sheet = class_device_info.values;
            Worksheet sheet = workbook.Worksheets[0];
            class_device_info.values.Copy(class_device_info.values.Range["A1:E" + (class_device_info.number_of_reads + 1).ToString()], sheet.Range["A1:E" + (class_device_info.number_of_reads + 1).ToString()]);


            sheet.Name = "sheet34";


            sheet.Range["A1"].Text = "M0 (bar)";
            sheet.Range["B1"].Text = "M1 (bar)";
            sheet.Range["C1"].Text = "M2 (bar)";
            sheet.Range["D1"].Text = "M3 (bar)";
            sheet.Range["E1"].Text = "M4 (bar)";
            sheet.Range["F1"].Text = "Applied pressure (Average)";
            sheet.Range["G1"].Text = "Measurement (Error)";
            sheet.Range["H1"].Text = "δpi (bar)";
            sheet.Range["I1"].Text = "δp'i (bar)";
            sheet.Range["J1"].Text = "δpH (bar)";
            sheet.Range["K1"].Text = "δpL (bar)";
            sheet.Range["L1"].Text = "accuracy ref.(bar)";
            sheet.Range["M1"].Text = "رانش (bar)";
            sheet.Range["N1"].Text = "اثر رانش";
            sheet.Range["O1"].Text = "اثر تفكيك پذيري";
            sheet.Range["P1"].Text = "عدم خطي بودن در صفر (bar)";
            sheet.Range["Q1"].Text = "اثر بیشینه انحراف رفت و برگشت";
            sheet.Range["R1"].Text = "پسماند (bar)";
            sheet.Range["S1"].Text = "Uncertainty (±bar)";

            sheet.Range["A1:S1"].Style.Font.IsBold = true;
            sheet.Range["A1:S1"].Style.Font.KnownColor = ExcelColors.Aqua;


            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                sheet.Range["A" + i.ToString()].NumberValue = Convert.ToDouble(sheet.Range["A" + i.ToString()].Text);
                sheet.Range["B" + i.ToString()].NumberValue = Convert.ToDouble(sheet.Range["B" + i.ToString()].Text);
                sheet.Range["C" + i.ToString()].NumberValue = Convert.ToDouble(sheet.Range["C" + i.ToString()].Text);
                sheet.Range["D" + i.ToString()].NumberValue = Convert.ToDouble(sheet.Range["D" + i.ToString()].Text);
                sheet.Range["E" + i.ToString()].NumberValue = Convert.ToDouble(sheet.Range["E" + i.ToString()].Text);
            }

            //average
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = " =AVERAGE(sheet34!$B$" + i.ToString() + ":E$" + i.ToString() + ") ";
                sheet.Range["F" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //error
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = " =ROUND(sheet34!$A$" + i.ToString() + "-F$" + i.ToString() + ",2) ";
                sheet.Range["G" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //δpi
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = " =ROUND(ABS(sheet34!$A$" + i.ToString() + "-AVERAGE(sheet34!$B$" + i.ToString() + ",D$" + i.ToString() + ")),2) ";
                sheet.Range["H" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //δp'i
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = " =ROUND(ABS(sheet34!$A$" + i.ToString() + "-AVERAGE(sheet34!$C$" + i.ToString() + ",E$" + i.ToString() + ")),2) ";
                sheet.Range["I" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //δpH
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = " =ROUND(ABS(sheet34!$H$" + i.ToString() + "-I$" + i.ToString() + "),2) ";
                sheet.Range["J" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //δpL
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = " =(sheet34!$H$" + i.ToString() + "+I$" + i.ToString() + ")/2 ";
                sheet.Range["K" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }


            //accuracy ref
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = "=ROUND(((0.05%*700)/SQRT(3))^2,2)";
                sheet.Range["L" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //رانش
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = "=ROUND(0.3%*sheet34!$F$" + i.ToString() + ",3)";
                sheet.Range["M" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //اثر رانش
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = "=((sheet34!$M$" + i.ToString() + "/SQRT(3)))^2";
                sheet.Range["N" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //اثر تفكيك پذيري
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = "=(0.05/(2*SQRT(3)))^2";
                sheet.Range["O" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //عدم خطي بودن در صفر
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = "=(0/(2*SQRT(3)))^2";
                sheet.Range["P" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //اثر بیشینه انحراف رفت و برگشت
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = "=((MAX(sheet34!$H$" + i.ToString() + ":I$" + i.ToString() + ")/(2*SQRT(3)))^2)";
                sheet.Range["Q" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //پسماند
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = "=(sheet34!$J$" + i.ToString() + "/(2*SQRT(3)))^2";
                sheet.Range["R" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }

            //Uncertainty
            for (int i = 2; i < class_device_info.number_of_reads + 2; i++)
            {
                string formula = "=ROUND((SQRT((sheet34!$L$" + i.ToString() + "+$N$" + i.ToString() + "+$O$" + i.ToString() + "+$P$" + i.ToString() + "+$Q$" + i.ToString() + "+$R$" + i.ToString() + ")))*2,2)";
                sheet.Range["S" + i.ToString()].Text = workbook.CaculateFormulaValue(formula).ToString();
            }



            DataTable dataTable = sheet.ExportDataTable();
            this.dataGridView1.DataSource = dataTable;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            class_device_info.values = workbook.Worksheets[0];
            class_device_info.step = 3;
            this.Close();
        }

        private void button_excel_out_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog1.Title = "Save an excel File";
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
                        workbook.SaveToFile(path, ExcelVersion.Version2013);
                        break;
                }


                try
                {
                    System.Diagnostics.Process.Start(workbook.FileName);
                }
                catch { }
            }
        }


        private void button_show_chart_Click_1(object sender, EventArgs e)
        {
            Worksheet sheet = workbook.Worksheets[0];
            //Add a line chart to the worksheet
            Chart chart = sheet.Charts.Add(ExcelChartType.Line);

            //Set data range for the chart
            chart.DataRange = sheet.Range["A2:A3"];



            //Set position of the chart
            chart.LeftColumn = 20;
            chart.TopRow = 6;
            chart.RightColumn = 30;
            chart.BottomRow = 29;


            //Set and format category axis title
            chart.PrimaryCategoryAxis.Title = "Applied Pressure DUT.";
            chart.PrimaryCategoryAxis.Font.IsBold = true;
            chart.PrimaryCategoryAxis.TitleArea.IsBold = true;

            //Set and format value axis title
            chart.PrimaryValueAxis.Title = "Average of REF.";
            chart.PrimaryValueAxis.HasMajorGridLines = false;
            chart.PrimaryValueAxis.TitleArea.TextRotationAngle = -90;
            chart.PrimaryValueAxis.MinValue = 0;
            chart.PrimaryValueAxis.TitleArea.IsBold = true;


            //Loop through the data series of the chart
            foreach (ChartSerie cs in chart.Series)
            {
                cs.Format.Options.IsVaryColor = true;
                //Show data labels for data points
                cs.DataPoints.DefaultDataPoint.DataLabels.HasValue = true;
            }

            //Set position of chart legend
            chart.Legend.Position = LegendPositionType.Top;

            Image[] imgs = workbook.SaveChartAsImage(sheet);

            using (Form form = new Form())
            {
                Bitmap img = new Bitmap(imgs[0]);

                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = img.Size;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = img;

                form.Controls.Add(pb);
                form.ShowDialog();
            }

            class_device_info.chart = imgs[0];

        }
    }
    
    
}
