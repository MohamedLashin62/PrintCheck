namespace PrintCheck.Forms
{
    partial class formBanks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankCod = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtChekName = new System.Windows.Forms.TextBox();
            this.boxCheckImag = new System.Windows.Forms.PictureBox();
            this.btnAddChek = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnInsPicCheck = new System.Windows.Forms.Button();
            this.txtPicCheck = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.boxCheckImag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(282, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "شاشة تسجيل البنوك وصور الشيكات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(122, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "كود البنك";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(121, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "إسم البنك";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(121, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "نوع الشيك";
            // 
            // txtBankCod
            // 
            this.txtBankCod.Location = new System.Drawing.Point(256, 265);
            this.txtBankCod.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankCod.Multiline = true;
            this.txtBankCod.Name = "txtBankCod";
            this.txtBankCod.Size = new System.Drawing.Size(239, 42);
            this.txtBankCod.TabIndex = 2;
            this.txtBankCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(256, 315);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(239, 42);
            this.txtBankName.TabIndex = 2;
            this.txtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChekName
            // 
            this.txtChekName.Location = new System.Drawing.Point(256, 365);
            this.txtChekName.Margin = new System.Windows.Forms.Padding(4);
            this.txtChekName.Multiline = true;
            this.txtChekName.Name = "txtChekName";
            this.txtChekName.Size = new System.Drawing.Size(239, 42);
            this.txtChekName.TabIndex = 2;
            this.txtChekName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxCheckImag
            // 
            this.boxCheckImag.Location = new System.Drawing.Point(542, 190);
            this.boxCheckImag.Margin = new System.Windows.Forms.Padding(4);
            this.boxCheckImag.Name = "boxCheckImag";
            this.boxCheckImag.Size = new System.Drawing.Size(762, 308);
            this.boxCheckImag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxCheckImag.TabIndex = 3;
            this.boxCheckImag.TabStop = false;
            this.boxCheckImag.Click += new System.EventHandler(this.boxCheckImag_Click);
            // 
            // btnAddChek
            // 
            this.btnAddChek.BackColor = System.Drawing.Color.Blue;
            this.btnAddChek.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChek.ForeColor = System.Drawing.Color.White;
            this.btnAddChek.Location = new System.Drawing.Point(594, 549);
            this.btnAddChek.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddChek.Name = "btnAddChek";
            this.btnAddChek.Size = new System.Drawing.Size(177, 71);
            this.btnAddChek.TabIndex = 4;
            this.btnAddChek.Text = "إضافة";
            this.btnAddChek.UseVisualStyleBackColor = false;
            this.btnAddChek.Click += new System.EventHandler(this.btnAddChek_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(792, 547);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 71);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnInsPicCheck
            // 
            this.btnInsPicCheck.ForeColor = System.Drawing.Color.Red;
            this.btnInsPicCheck.Location = new System.Drawing.Point(337, 549);
            this.btnInsPicCheck.Name = "btnInsPicCheck";
            this.btnInsPicCheck.Size = new System.Drawing.Size(239, 69);
            this.btnInsPicCheck.TabIndex = 6;
            this.btnInsPicCheck.Text = "إضافة صورة الشيك";
            this.btnInsPicCheck.UseVisualStyleBackColor = true;
            this.btnInsPicCheck.Click += new System.EventHandler(this.btnInsPicCheck_Click);
            // 
            // txtPicCheck
            // 
            this.txtPicCheck.Location = new System.Drawing.Point(253, 414);
            this.txtPicCheck.Name = "txtPicCheck";
            this.txtPicCheck.Size = new System.Drawing.Size(242, 42);
            this.txtPicCheck.TabIndex = 7;
            this.txtPicCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofd";
            // 
            // formBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 638);
            this.Controls.Add(this.txtPicCheck);
            this.Controls.Add(this.btnInsPicCheck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddChek);
            this.Controls.Add(this.boxCheckImag);
            this.Controls.Add(this.txtChekName);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.txtBankCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "formBanks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formBanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxCheckImag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBankCod;
        private System.Windows.Forms.PictureBox boxCheckImag;
        public System.Windows.Forms.TextBox txtBankName;
        public System.Windows.Forms.TextBox txtChekName;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnAddChek;
        private System.Windows.Forms.Button btnInsPicCheck;
        private System.Windows.Forms.TextBox txtPicCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}