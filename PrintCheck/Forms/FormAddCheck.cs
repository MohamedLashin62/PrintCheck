using PrintCheck.Trancaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PrintCheck.Forms
{
    public partial class FormAddCheck : Form
    {
        GenericClass generic = new GenericClass();
        public FormAddCheck()
        {
            InitializeComponent();
            txtCheckNO.Clear();            
            txtChechAmount.Clear();
            txtCheckNO.Focus();
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

        private void btnAddCheck_Click(object sender, EventArgs e)
        {
            groupChecData.Enabled = true;
            txtCheckNO.Focus();
            btnSave.Enabled = true;
            btnUpdateCheck.Enabled = false; 
            GenericClass generic = new GenericClass();
            generic.MaxIDPublic("MaxCheckIDSP");
            int id = generic.MaxIDPublic("MaxCheckIDSP") + 1;
            txtCheckID.Text = id.ToString();
        }
        private void txtCheckNO_KeyDown(object sender, KeyEventArgs e)
        {
            txtCheckNO.Focus();
            if (e.KeyCode == Keys.Enter)
            {
                txtChechAmount.Select();
            }
        }
        private void txtChechAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCheckELmoustavid.Select();
            }
        }

        private void txtCheckELmoustavid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCurrency.Select();
            }
        }

        private void txtCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBankName.Select();
            }
        }

        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtExpnses.Select();
            }
        }

        private void txtExpnses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtChekTyp.Select();
            }
        }

        private void txtChekTyp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
    }
        }
           
        
      
