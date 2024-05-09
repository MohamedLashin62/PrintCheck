using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintCheck.Forms
{
    public partial class FormPrintCheck : Form
    {
        public FormPrintCheck()
        {
            InitializeComponent();
        }

        private void FormPrintCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printCheckDataSetPrint.View_AddCheck' table. You can move, or remove it, as needed.
            this.view_AddCheckTableAdapter.Fill(this.printCheckDataSetPrint.View_AddCheck);

            this.reportViewer1.RefreshReport();
        }
    }
}
