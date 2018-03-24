using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace WinFormsProj {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["test"];
            string connStr = settings.ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string query = "Select * From FirstTable";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            rdr.Read(); // first line
            MessageBox.Show($"{rdr["Name"]}");
            rdr.Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'WinFormsProjDBDataSet.FirstTable' table. You can move, or remove it, as needed.
            this.FirstTableTableAdapter.Fill(this.WinFormsProjDBDataSet.FirstTable);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ShowProgress = true;
            this.reportViewer1.RefreshReport();
        }
    }
}
