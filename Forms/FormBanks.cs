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
using PrintCheck.Trancaction;
using System.IO;


namespace PrintCheck.Forms
{
    public partial class formBanks : Form
    {
        public formBanks()
        {
            InitializeComponent();
        }

        

        private void btnAddChek_Click(object sender, EventArgs e)
        {
            GenericClass generic = new GenericClass();
            generic.MaxIDPublic("MaxBankCodSP");
            int id = generic.MaxIDPublic("MaxBankCodSP") + 1;
            txtBankCod.Text = id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictCheck.Image.Save(ms, pictCheck.Image.RawFormat);
            byte[] data = ms.ToArray();

            GenericClass generic = new GenericClass();
            generic.MaxIDPublic("MaxBankCodSP");
            int id = generic.MaxIDPublic("MaxBankCodSP") + 1;
            Banks banks = new Banks();
            var BankName = txtBankName.Text;
            var CheckName = txtChekName.Text;
            var PictureCheck = pictCheck.Image;
            banks.InsertBank(id, BankName, CheckName, PictureCheck);
            
            MessageBox.Show("تم تسجيل البنك بنجاح");
        }

        private void btnInsPicCheck_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictCheck.Image = new Bitmap(ofd.FileName);
                txtPicCheck.Text = ofd.FileName;
            }
        }

        private void formBanks_Load(object sender, EventArgs e)
        {

        }
    }
}
