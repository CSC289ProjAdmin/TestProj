using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormsProj {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            string connStr = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=WinFormsDb;Integrated Security=True;Pooling=False;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connStr);
            string query = "Select * From TestTable";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            rdr.Read(); // first line
            string text = $"{rdr["Amount"]:c}";
            
            rdr.Close();

            lblDbTest.Text = text;
        }
    }
}
