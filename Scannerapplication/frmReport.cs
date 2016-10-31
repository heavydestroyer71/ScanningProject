using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scannerapplication.DB;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;

namespace Scannerapplication
{
    public partial class frmReport : Form
    {
        ImageDbEntities db = new ImageDbEntities();

        public frmReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isCom=0;
            if (comboBox1.SelectedItem == "Complete")
            {
                isCom = 1;
            }
            var query = "SELECT Box,batch,COUNT(MSISDN) as Number FROM imageMergesInfo where IsComplete=" + isCom + " GROUP BY Box,batch";
            var report = db.ExecuteStoreQuery<reportCom>(query).ToList();
            dataGridView1.DataSource = report;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int isCom = 0;
            if (comboBox1.SelectedItem == "Complete")
            {
                isCom = 1;
            }
            string bt = comboBox2.Text;
            var query = "SELECT MSISDN FROM imageMergesInfo where IsComplete=" + isCom + " and batch='" + bt + "'";
            var report = db.ExecuteStoreQuery<reportMsisdn>(query).ToList();
            dataGridView1.DataSource = report;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            var batch = db.ExecuteStoreQuery<reportCom>("select distinct batch from imageMergesInfo").ToList();
            comboBox2.DataSource = batch;
            comboBox2.DisplayMember = "Batch";

            var ctImages = db.imageMergesInfoes.Count();
            textBox1.Text = ctImages.ToString();

            var ctcImages = db.imageMergesInfoes.Where(i => i.IsComplete == true).Count();
            textBox2.Text = ctcImages.ToString();

            var cticImages = db.imageMergesInfoes.Where(i => i.IsComplete == false).Count();
            textBox3.Text = cticImages.ToString();
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            //Creating DataTable
            DataTable dt = new DataTable();

            //Adding the Columns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            //Exporting to Excel
            string folderPath = "C:\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Customers");
                wb.SaveAs(folderPath + "DataGridViewExport.xlsx");
            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;

            //Add the Header row for CSV file.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                csv += column.HeaderText + ',';
            }

            //Add new line.
            csv += "\r\n";

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                csv += "\r\n";
            }

            //Exporting to CSV.
            string folderPath = "C:\\CSV\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            File.WriteAllText(folderPath + "DataGridViewExport.csv", csv);
        }

    }
    public class reportCom
    {
        public string Box { get; set; }
        public string Batch { get; set; }
        public int Number { get; set; }
    }
    public class reportMsisdn
    {
        public double MSISDN { get; set; }
    }
    public class reportDetails
    {
        public int id { get; set; }
        public string source { get; set; }
        public string file_name { get; set; }
        public string sim_card_num { get; set; }
        public string MSISDN { get; set; }
        public string Agent { get; set; }
        public string box { get; set; }
        public string batch { get; set; }
        public DateTime challan_receive_date { get; set; }
        public string status { get; set; }
        public string challan { get; set; }
        public string LOGIN_ID { get; set; }
    }
    public class reportSum
    {
        public string Challan { get; set; }
        public DateTime Date { get; set; }
        public int ReceivedQuantity { get; set; }
        public int Complete { get; set; }
        public int Incomplete { get; set; }
        public int NotFound { get; set; }
    }
}
