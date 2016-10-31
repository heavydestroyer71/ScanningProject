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
using ClosedXML.Excel;

namespace Scannerapplication
{
    public partial class ReportDetails : Form
    {
        ImageDbEntities db = new ImageDbEntities();
        public ReportDetails()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var query = "SELECT challan,COUNT(id) as challan_qty,COUNT(CASE WHEN IsComplete=1 THEN 1 END) AS complete,COUNT(CASE WHEN IsComplete=0 THEN 0 END) AS incomplete,((COUNT(id))-((COUNT(CASE WHEN IsComplete=1 THEN 1 END))+(COUNT(CASE WHEN IsComplete=0 THEN 0 END)))) as not_found FROM imageMergesInfo GROUP BY challan";
            var report = db.ExecuteStoreQuery<reportSum>(query).ToList();
            dataGridView1.DataSource = report;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.db.CommandTimeout = 180;
            //var query = "select i.id,id.source_path,id.source_file_name,id.sim_number,i.msisdn,i.agent,i.box,i.batch,c.challan_receive_date,case when iscomplete=1 then 'Complete' when iscomplete=0 then 'Incomplete' end as status,i.challan,su.LOGIN_ID from imageMergesInfo i inner join challan_info c on i.challan=c.challan_name left join mergeImageDetails id on i.msisdn=id.msisdn left join SEC_USERS su on id.USER_NO=su.USER_NO";
            var query = "exec details_report";
            var report = db.ExecuteStoreQuery<reportDetails>(query).ToList();
            dataGridView1.DataSource = report;

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
            string folderPath = "C:\\Scanning\\Excel\\";
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
            string folderPath = "C:\\Scanning\\CSV\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            File.WriteAllText(folderPath + "DataGridViewExport.csv", csv);
        }

    }
}
