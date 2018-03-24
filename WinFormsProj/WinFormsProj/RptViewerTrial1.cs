using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProj {
    public partial class RptViewerTrial1 : Form {
        public RptViewerTrial1() {
            InitializeComponent();
        }

        private void RptViewerTrial1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'WinFormsProjDBDataSet.FirstTable' table. You can move, or remove it, as needed.
            this.FirstTableTableAdapter.Fill(this.WinFormsProjDBDataSet.FirstTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
