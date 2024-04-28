namespace PrintCheck.Forms
{
    partial class FormAddCheck
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
            this.components = new System.ComponentModel.Container();
            this.dgvCheck = new System.Windows.Forms.DataGridView();
            this.checkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currenceyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almustafidNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkTypNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSet = new PrintCheck.PrintCheckDataSet();
            this.view_CheckTableAdapter = new PrintCheck.PrintCheckDataSetTableAdapters.View_CheckTableAdapter();
            this.txtCheckID = new System.Windows.Forms.TextBox();
            this.txtChechAmount = new System.Windows.Forms.TextBox();
            this.txtCheckELmoustavid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.ComboBox();
            this.currenceyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSet1 = new PrintCheck.PrintCheckDataSet1();
            this.currenceyTableAdapter = new PrintCheck.PrintCheckDataSet1TableAdapters.CurrenceyTableAdapter();
            this.txtBankName = new System.Windows.Forms.ComboBox();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSet2 = new PrintCheck.PrintCheckDataSet2();
            this.banksTableAdapter = new PrintCheck.PrintCheckDataSet2TableAdapters.BanksTableAdapter();
            this.txtExpnses = new System.Windows.Forms.ComboBox();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSet3 = new PrintCheck.PrintCheckDataSet3();
            this.txtChekTyp = new System.Windows.Forms.ComboBox();
            this.checkTypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSet4 = new PrintCheck.PrintCheckDataSet4();
            this.expensesTableAdapter = new PrintCheck.PrintCheckDataSet3TableAdapters.ExpensesTableAdapter();
            this.checkTypTableAdapter = new PrintCheck.PrintCheckDataSet4TableAdapters.CheckTypTableAdapter();
            this.pictCheck = new System.Windows.Forms.PictureBox();
            this.groupChecData = new System.Windows.Forms.GroupBox();
            this.txtCheckNO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddCheck = new System.Windows.Forms.Button();
            this.btnUpdateCheck = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenceyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTypBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCheck)).BeginInit();
            this.groupChecData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCheck
            // 
            this.dgvCheck.AllowUserToAddRows = false;
            this.dgvCheck.AllowUserToDeleteRows = false;
            this.dgvCheck.AutoGenerateColumns = false;
            this.dgvCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheck.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCheck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkDateDataGridViewTextBoxColumn,
            this.checkNoDataGridViewTextBoxColumn,
            this.checkAmountDataGridViewTextBoxColumn,
            this.currenceyNameDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn,
            this.almustafidNameDataGridViewTextBoxColumn,
            this.expensesNameDataGridViewTextBoxColumn,
            this.checkTypNamDataGridViewTextBoxColumn});
            this.dgvCheck.DataSource = this.viewCheckBindingSource;
            this.dgvCheck.EnableHeadersVisualStyles = false;
            this.dgvCheck.GridColor = System.Drawing.Color.Red;
            this.dgvCheck.Location = new System.Drawing.Point(437, 445);
            this.dgvCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.ReadOnly = true;
            this.dgvCheck.RowHeadersVisible = false;
            this.dgvCheck.Size = new System.Drawing.Size(782, 209);
            this.dgvCheck.TabIndex = 0;
            // 
            // checkDateDataGridViewTextBoxColumn
            // 
            this.checkDateDataGridViewTextBoxColumn.DataPropertyName = "CheckDate";
            this.checkDateDataGridViewTextBoxColumn.HeaderText = "CheckDate";
            this.checkDateDataGridViewTextBoxColumn.Name = "checkDateDataGridViewTextBoxColumn";
            this.checkDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkNoDataGridViewTextBoxColumn
            // 
            this.checkNoDataGridViewTextBoxColumn.DataPropertyName = "CheckNo";
            this.checkNoDataGridViewTextBoxColumn.HeaderText = "CheckNo";
            this.checkNoDataGridViewTextBoxColumn.Name = "checkNoDataGridViewTextBoxColumn";
            this.checkNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkAmountDataGridViewTextBoxColumn
            // 
            this.checkAmountDataGridViewTextBoxColumn.DataPropertyName = "CheckAmount";
            this.checkAmountDataGridViewTextBoxColumn.HeaderText = "CheckAmount";
            this.checkAmountDataGridViewTextBoxColumn.Name = "checkAmountDataGridViewTextBoxColumn";
            this.checkAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currenceyNameDataGridViewTextBoxColumn
            // 
            this.currenceyNameDataGridViewTextBoxColumn.DataPropertyName = "CurrenceyName";
            this.currenceyNameDataGridViewTextBoxColumn.HeaderText = "CurrenceyName";
            this.currenceyNameDataGridViewTextBoxColumn.Name = "currenceyNameDataGridViewTextBoxColumn";
            this.currenceyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "BankName";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            this.bankNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // almustafidNameDataGridViewTextBoxColumn
            // 
            this.almustafidNameDataGridViewTextBoxColumn.DataPropertyName = "AlmustafidName";
            this.almustafidNameDataGridViewTextBoxColumn.HeaderText = "AlmustafidName";
            this.almustafidNameDataGridViewTextBoxColumn.Name = "almustafidNameDataGridViewTextBoxColumn";
            this.almustafidNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expensesNameDataGridViewTextBoxColumn
            // 
            this.expensesNameDataGridViewTextBoxColumn.DataPropertyName = "ExpensesName";
            this.expensesNameDataGridViewTextBoxColumn.HeaderText = "ExpensesName";
            this.expensesNameDataGridViewTextBoxColumn.Name = "expensesNameDataGridViewTextBoxColumn";
            this.expensesNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkTypNamDataGridViewTextBoxColumn
            // 
            this.checkTypNamDataGridViewTextBoxColumn.DataPropertyName = "CheckTypNam";
            this.checkTypNamDataGridViewTextBoxColumn.HeaderText = "CheckTypNam";
            this.checkTypNamDataGridViewTextBoxColumn.Name = "checkTypNamDataGridViewTextBoxColumn";
            this.checkTypNamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewCheckBindingSource
            // 
            this.viewCheckBindingSource.DataMember = "View_Check";
            this.viewCheckBindingSource.DataSource = this.printCheckDataSet;
            // 
            // printCheckDataSet
            // 
            this.printCheckDataSet.DataSetName = "PrintCheckDataSet";
            this.printCheckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_CheckTableAdapter
            // 
            this.view_CheckTableAdapter.ClearBeforeFill = true;
            // 
            // txtCheckID
            // 
            this.txtCheckID.BackColor = System.Drawing.Color.White;
            this.txtCheckID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckID.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtCheckID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCheckID.Location = new System.Drawing.Point(138, 43);
            this.txtCheckID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckID.Name = "txtCheckID";
            this.txtCheckID.Size = new System.Drawing.Size(86, 26);
            this.txtCheckID.TabIndex = 1;
            this.txtCheckID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChechAmount
            // 
            this.txtChechAmount.BackColor = System.Drawing.Color.White;
            this.txtChechAmount.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtChechAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChechAmount.Location = new System.Drawing.Point(42, 126);
            this.txtChechAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChechAmount.Name = "txtChechAmount";
            this.txtChechAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChechAmount.Size = new System.Drawing.Size(182, 26);
            this.txtChechAmount.TabIndex = 1;
            this.txtChechAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChechAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChechAmount_KeyDown);
            // 
            // txtCheckELmoustavid
            // 
            this.txtCheckELmoustavid.BackColor = System.Drawing.Color.White;
            this.txtCheckELmoustavid.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtCheckELmoustavid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCheckELmoustavid.Location = new System.Drawing.Point(15, 153);
            this.txtCheckELmoustavid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckELmoustavid.Name = "txtCheckELmoustavid";
            this.txtCheckELmoustavid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCheckELmoustavid.Size = new System.Drawing.Size(209, 26);
            this.txtCheckELmoustavid.TabIndex = 1;
            this.txtCheckELmoustavid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCheckELmoustavid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckELmoustavid_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "تاريخ الشيك";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم إذن الشيك";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "مبلغ الشيك";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "عملة الشيك";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "اسم البنك";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "إسم المستفيد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "نوع المصروف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "نوع الشيك";
            // 
            // txtCurrency
            // 
            this.txtCurrency.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCurrency.DataSource = this.currenceyBindingSource;
            this.txtCurrency.DisplayMember = "CurrenceyName";
            this.txtCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCurrency.FormattingEnabled = true;
            this.txtCurrency.Location = new System.Drawing.Point(73, 180);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(151, 30);
            this.txtCurrency.TabIndex = 3;
            this.txtCurrency.ValueMember = "CurrencyCod";
            this.txtCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrency_KeyDown);
            // 
            // currenceyBindingSource
            // 
            this.currenceyBindingSource.DataMember = "Currencey";
            this.currenceyBindingSource.DataSource = this.printCheckDataSet1;
            // 
            // printCheckDataSet1
            // 
            this.printCheckDataSet1.DataSetName = "PrintCheckDataSet1";
            this.printCheckDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currenceyTableAdapter
            // 
            this.currenceyTableAdapter.ClearBeforeFill = true;
            // 
            // txtBankName
            // 
            this.txtBankName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBankName.DataSource = this.banksBindingSource;
            this.txtBankName.DisplayMember = "BankName";
            this.txtBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtBankName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBankName.FormattingEnabled = true;
            this.txtBankName.Location = new System.Drawing.Point(15, 211);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(208, 30);
            this.txtBankName.TabIndex = 4;
            this.txtBankName.ValueMember = "BankCod";
            this.txtBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankName_KeyDown);
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataMember = "Banks";
            this.banksBindingSource.DataSource = this.printCheckDataSet2;
            // 
            // printCheckDataSet2
            // 
            this.printCheckDataSet2.DataSetName = "PrintCheckDataSet2";
            this.printCheckDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banksTableAdapter
            // 
            this.banksTableAdapter.ClearBeforeFill = true;
            // 
            // txtExpnses
            // 
            this.txtExpnses.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExpnses.DataSource = this.expensesBindingSource;
            this.txtExpnses.DisplayMember = "ExpensesName";
            this.txtExpnses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtExpnses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtExpnses.FormattingEnabled = true;
            this.txtExpnses.Location = new System.Drawing.Point(50, 242);
            this.txtExpnses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpnses.Name = "txtExpnses";
            this.txtExpnses.Size = new System.Drawing.Size(174, 30);
            this.txtExpnses.TabIndex = 5;
            this.txtExpnses.ValueMember = "ExpensesCod";
            this.txtExpnses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpnses_KeyDown);
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.printCheckDataSet3;
            // 
            // printCheckDataSet3
            // 
            this.printCheckDataSet3.DataSetName = "PrintCheckDataSet3";
            this.printCheckDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtChekTyp
            // 
            this.txtChekTyp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtChekTyp.DataSource = this.checkTypBindingSource;
            this.txtChekTyp.DisplayMember = "CheckTypNam";
            this.txtChekTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtChekTyp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChekTyp.FormattingEnabled = true;
            this.txtChekTyp.Location = new System.Drawing.Point(50, 273);
            this.txtChekTyp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChekTyp.MinimumSize = new System.Drawing.Size(174, 0);
            this.txtChekTyp.Name = "txtChekTyp";
            this.txtChekTyp.Size = new System.Drawing.Size(174, 30);
            this.txtChekTyp.TabIndex = 6;
            this.txtChekTyp.ValueMember = "CheckTypCod";
            this.txtChekTyp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChekTyp_KeyDown);
            // 
            // checkTypBindingSource
            // 
            this.checkTypBindingSource.DataMember = "CheckTyp";
            this.checkTypBindingSource.DataSource = this.printCheckDataSet4;
            // 
            // printCheckDataSet4
            // 
            this.printCheckDataSet4.DataSetName = "PrintCheckDataSet4";
            this.printCheckDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // checkTypTableAdapter
            // 
            this.checkTypTableAdapter.ClearBeforeFill = true;
            // 
            // pictCheck
            // 
            this.pictCheck.BackColor = System.Drawing.Color.White;
            this.pictCheck.Location = new System.Drawing.Point(495, 190);
            this.pictCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictCheck.Name = "pictCheck";
            this.pictCheck.Size = new System.Drawing.Size(649, 219);
            this.pictCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCheck.TabIndex = 7;
            this.pictCheck.TabStop = false;
            // 
            // groupChecData
            // 
            this.groupChecData.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupChecData.Controls.Add(this.dateTimePicker4);
            this.groupChecData.Controls.Add(this.txtCheckNO);
            this.groupChecData.Controls.Add(this.txtCheckID);
            this.groupChecData.Controls.Add(this.label8);
            this.groupChecData.Controls.Add(this.txtChekTyp);
            this.groupChecData.Controls.Add(this.label7);
            this.groupChecData.Controls.Add(this.txtChechAmount);
            this.groupChecData.Controls.Add(this.label6);
            this.groupChecData.Controls.Add(this.txtExpnses);
            this.groupChecData.Controls.Add(this.label5);
            this.groupChecData.Controls.Add(this.txtCheckELmoustavid);
            this.groupChecData.Controls.Add(this.label4);
            this.groupChecData.Controls.Add(this.txtBankName);
            this.groupChecData.Controls.Add(this.label3);
            this.groupChecData.Controls.Add(this.txtCurrency);
            this.groupChecData.Controls.Add(this.label10);
            this.groupChecData.Controls.Add(this.label2);
            this.groupChecData.Controls.Add(this.label1);
            this.groupChecData.Enabled = false;
            this.groupChecData.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.groupChecData.ForeColor = System.Drawing.Color.Black;
            this.groupChecData.Location = new System.Drawing.Point(31, 225);
            this.groupChecData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupChecData.Name = "groupChecData";
            this.groupChecData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupChecData.Size = new System.Drawing.Size(341, 327);
            this.groupChecData.TabIndex = 8;
            this.groupChecData.TabStop = false;
            this.groupChecData.Text = "بيانات الشيك";
            // 
            // txtCheckNO
            // 
            this.txtCheckNO.BackColor = System.Drawing.Color.White;
            this.txtCheckNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckNO.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtCheckNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCheckNO.Location = new System.Drawing.Point(88, 70);
            this.txtCheckNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckNO.Name = "txtCheckNO";
            this.txtCheckNO.Size = new System.Drawing.Size(135, 26);
            this.txtCheckNO.TabIndex = 1;
            this.txtCheckNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCheckNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckNO_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(258, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "رقم  الشيك";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Traditional Arabic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(454, 73);
            this.label9.TabIndex = 9;
            this.label9.Text = "شاشة تسجيل الشيكات الصادرة";
            // 
            // btnAddCheck
            // 
            this.btnAddCheck.BackColor = System.Drawing.Color.Blue;
            this.btnAddCheck.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnAddCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCheck.Location = new System.Drawing.Point(16, 556);
            this.btnAddCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCheck.Name = "btnAddCheck";
            this.btnAddCheck.Size = new System.Drawing.Size(113, 60);
            this.btnAddCheck.TabIndex = 10;
            this.btnAddCheck.Text = "إضافة شيك";
            this.btnAddCheck.UseVisualStyleBackColor = false;
            this.btnAddCheck.Click += new System.EventHandler(this.btnAddCheck_Click);
            // 
            // btnUpdateCheck
            // 
            this.btnUpdateCheck.BackColor = System.Drawing.Color.Blue;
            this.btnUpdateCheck.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnUpdateCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateCheck.Location = new System.Drawing.Point(138, 556);
            this.btnUpdateCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCheck.Name = "btnUpdateCheck";
            this.btnUpdateCheck.Size = new System.Drawing.Size(112, 60);
            this.btnUpdateCheck.TabIndex = 10;
            this.btnUpdateCheck.Text = "تعديل شيك";
            this.btnUpdateCheck.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(256, 556);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 60);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.RightToLeftLayout = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker3.TabIndex = 13;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(24, 97);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker4.RightToLeftLayout = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker4.TabIndex = 7;
            // 
            // FormAddCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1231, 681);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateCheck);
            this.Controls.Add(this.btnAddCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupChecData);
            this.Controls.Add(this.pictCheck);
            this.Controls.Add(this.dgvCheck);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddCheck";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة شيك";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenceyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTypBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCheck)).EndInit();
            this.groupChecData.ResumeLayout(false);
            this.groupChecData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PrintCheckDataSet printCheckDataSet;
        private System.Windows.Forms.BindingSource viewCheckBindingSource;
        private PrintCheckDataSetTableAdapters.View_CheckTableAdapter view_CheckTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currenceyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almustafidNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkTypNamDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvCheck;
        private System.Windows.Forms.TextBox txtChechAmount;
        private System.Windows.Forms.TextBox txtCheckELmoustavid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtCurrency;
        private PrintCheckDataSet1 printCheckDataSet1;
        private System.Windows.Forms.BindingSource currenceyBindingSource;
        private PrintCheckDataSet1TableAdapters.CurrenceyTableAdapter currenceyTableAdapter;
        private System.Windows.Forms.ComboBox txtBankName;
        private PrintCheckDataSet2 printCheckDataSet2;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private PrintCheckDataSet2TableAdapters.BanksTableAdapter banksTableAdapter;
        private System.Windows.Forms.ComboBox txtExpnses;
        private System.Windows.Forms.ComboBox txtChekTyp;
        private PrintCheckDataSet3 printCheckDataSet3;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private PrintCheckDataSet3TableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private PrintCheckDataSet4 printCheckDataSet4;
        private System.Windows.Forms.BindingSource checkTypBindingSource;
        private PrintCheckDataSet4TableAdapters.CheckTypTableAdapter checkTypTableAdapter;
        private System.Windows.Forms.PictureBox pictCheck;
        private System.Windows.Forms.GroupBox groupChecData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddCheck;
        private System.Windows.Forms.Button btnUpdateCheck;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtCheckID;
        public System.Windows.Forms.TextBox txtCheckNO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}