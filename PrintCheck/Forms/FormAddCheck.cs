﻿using PrintCheck.Trancaction;
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

using static PrintCheck.PrintCheckDataSet3;
using static PrintCheck.PrintCheckDataSet4;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // TODO: This line of code loads data into the 'printCheckDataSetDgvCheck.View_AddCheck' table. You can move, or remove it, as needed.
            this.view_AddCheckTableAdapter1.Fill(this.printCheckDataSetDgvCheck.View_AddCheck);
            // TODO: This line of code loads data into the 'printCheckDataSetAllChecks.View_AddCheck' table. You can move, or remove it, as needed.
            this.view_AddCheckTableAdapter.Fill(this.printCheckDataSetAllChecks.View_AddCheck);
            // TODO: This line of code loads data into the 'printCheckDataSetCurrency.Currencey' table. You can move, or remove it, as needed.
            this.currenceyTableAdapter.Fill(this.printCheckDataSetCurrency.Currencey);
            // TODO: This line of code loads data into the 'printCheckDataSet4.CheckTyp' table. You can move, or remove it, as needed.
            this.checkTypTableAdapter.Fill(this.printCheckDataSet4.CheckTyp);
            // TODO: This line of code loads data into the 'printCheckDataSet3.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.printCheckDataSet3.Expenses);
            // TODO: This line of code loads data into the 'printCheckDataSet2.Banks' table. You can move, or remove it, as needed.
            this.banksTableAdapter.Fill(this.printCheckDataSet2.Banks);
            // TODO: This line of code loads data into the 'printCheckDataSet1.Currencey' table. You can move, or remove it, as needed.
         //   this.currenceyTableAdapter.Fill(this.printCheckDataSet1.Currencey);
            // TODO: This line of code loads data into the 'printCheckDataSet.View_Check' table. You can move, or remove it, as needed.
          //  this.view_CheckTableAdapter.Fill(this.printCheckDataSet.View_Check);
        }
        private void btnAddCheck_Click(object sender, EventArgs e)
        {
            groupChecData.Enabled = true;
            txtCheckNO.Focus();           
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
                txtAlmustavidNam.Select();
            }
        }
        private void txtAlmustavidNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCurrency.Select();

            }
        }
        private void txtCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBankName.Select();
            }
        }      
        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbExpnses.Select();
            }
        }
        private void txtExpnses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbChekTyp.Select();
            }
        }
        private void txtChekTyp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtManger.Select();
               
            }
        }
        private void txtManger_KeyDown_1(object sender, KeyEventArgs e)
        {
            btnSave.Enabled = true;
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            GenericClass generic = new GenericClass();
            generic.MaxIDPublic("MaxCheckIDSP");
            int id = generic.MaxIDPublic("MaxCheckIDSP") + 1;
            AddCheck Add = new AddCheck();           
            var checkNO = !string.IsNullOrEmpty(txtCheckNO.Text) ? Convert.ToInt32(txtCheckNO.Text) : 0;
            var CheckDate = !string.IsNullOrEmpty(txtChekDate.Text) ? Convert.ToDateTime(txtChekDate.Text) : DateTime.Now;
            var checkAmount = !string.IsNullOrEmpty(txtChechAmount.Text) ? Convert.ToDecimal(txtChechAmount.Text) : 0;
            var AlmustafidNam = txtAlmustavidNam.Text;
            var CurrencyCodSelected=cmbCurrency.SelectedValue;
            var CurrencyCod = !string.IsNullOrEmpty(CurrencyCodSelected.ToString()) ? Convert.ToInt32(CurrencyCodSelected) : 0;
            var bankCodeSelected = cmbBankName.SelectedValue;
            var BankCod = !string.IsNullOrEmpty(bankCodeSelected.ToString()) ? Convert.ToInt32(bankCodeSelected) : 0;
            var ExpensesCodSelected = cmbExpnses.SelectedValue;
            var ExpensesCod = !string.IsNullOrEmpty(ExpensesCodSelected.ToString()) ? Convert.ToInt32(ExpensesCodSelected) : 0;
            var CheckTypCodSelected = cmbChekTyp.SelectedValue;
            var CheckTypCod = !string.IsNullOrEmpty(CheckTypCodSelected.ToString()) ? Convert.ToInt32(CheckTypCodSelected) : 0;
            var Manger =txtManger.Text;
            Add.InsertIntoCheckMovement(
            id, checkNO, CheckDate, checkAmount,AlmustafidNam,
            CurrencyCod, BankCod, ExpensesCod, CheckTypCod,Manger);

            MessageBox.Show("تم تسجيل بيانات الشيك بنجاح");
            btnSave.Enabled = false;
            btnAddCheck.PerformClick();
            txtCheckNO.Clear();
            txtChechAmount.Clear();
            txtAlmustavidNam.Clear();

            this.Refresh();
            dgvCheck.Refresh();
        }

       
    }

   }
   
     
           
        
      
