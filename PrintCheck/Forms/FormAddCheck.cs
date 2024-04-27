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
            txtCheckDate.Clear();
            txtChechAmount.Clear();
            
            //GenericClass generic = new GenericClass();
            //generic.MaxIDPublic("MaxCheckIDSP");
            //int id = generic.MaxIDPublic("MaxCheckIDSP") + 1;
            //txtCheckNO.Text = id.ToString();

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
            btnSave.Enabled = true;
            GenericClass generic = new GenericClass();
            generic.MaxIDPublic("MaxCheckIDSP");
            int id = generic.MaxIDPublic("MaxCheckIDSP") + 1;
            txtCheckNO.Text = id.ToString();
        }         
            
            }
        }
           
        
      
