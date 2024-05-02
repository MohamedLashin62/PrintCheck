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
    public partial class FormPrintChech : Form
    {
        public FormPrintChech()
        {
            InitializeComponent();
        }

        private void FormPrintChech_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
