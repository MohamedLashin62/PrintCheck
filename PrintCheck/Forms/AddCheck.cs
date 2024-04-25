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
    public partial class AddCheck : Form
    {
        public AddCheck()
        {
            InitializeComponent();
        }

        private void AddCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printCheckDataSet4.CheckTyp' table. You can move, or remove it, as needed.
            this.checkTypTableAdapter.Fill(this.printCheckDataSet4.CheckTyp);
            // TODO: This line of code loads data into the 'printCheckDataSet3.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.printCheckDataSet3.Expenses);
            // TODO: This line of code loads data into the 'printCheckDataSet2.Banks' table. You can move, or remove it, as needed.
            this.banksTableAdapter.Fill(this.printCheckDataSet2.Banks);
            // TODO: This line of code loads data into the 'printCheckDataSet1.Currencey' table. You can move, or remove it, as needed.
            this.currenceyTableAdapter.Fill(this.printCheckDataSet1.Currencey);
            // TODO: This line of code loads data into the 'printCheckDataSet.View_Check' table. You can move, or remove it, as needed.
            this.view_CheckTableAdapter.Fill(this.printCheckDataSet.View_Check);

        }
    }
}
