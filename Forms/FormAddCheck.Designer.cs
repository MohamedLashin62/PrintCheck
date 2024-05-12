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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCheck));
            this.dgvCheck = new System.Windows.Forms.DataGridView();
            this.checkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almustafidNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewAddCheckBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSetDgvCheck = new PrintCheck.PrintCheckDataSetDgvCheck();
            this.viewAddCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSetAllChecks = new PrintCheck.PrintCheckDataSetAllChecks();
            this.viewCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCheckID = new System.Windows.Forms.TextBox();
            this.txtChechAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.currenceyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSetCurrency = new PrintCheck.PrintCheckDataSetCurrency();
            this.currenceyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSet2 = new PrintCheck.PrintCheckDataSet2();
            this.banksTableAdapter = new PrintCheck.PrintCheckDataSet2TableAdapters.BanksTableAdapter();
            this.cmbExpnses = new System.Windows.Forms.ComboBox();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSet3 = new PrintCheck.PrintCheckDataSet3();
            this.cmbChekTyp = new System.Windows.Forms.ComboBox();
            this.checkTypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSet4 = new PrintCheck.PrintCheckDataSet4();
            this.expensesTableAdapter = new PrintCheck.PrintCheckDataSet3TableAdapters.ExpensesTableAdapter();
            this.checkTypTableAdapter = new PrintCheck.PrintCheckDataSet4TableAdapters.CheckTypTableAdapter();
            this.groupChecData = new System.Windows.Forms.GroupBox();
            this.txtPHotoCheck = new System.Windows.Forms.TextBox();
            this.btnInsertPic = new System.Windows.Forms.Button();
            this.cmbAlmustafid = new System.Windows.Forms.ComboBox();
            this.almustavidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printCheckDataSetAlmustafid = new PrintCheck.PrintCheckDataSetAlmustafid();
            this.txtChekDate = new System.Windows.Forms.DateTimePicker();
            this.txtCheckNO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtManger = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddCheck = new System.Windows.Forms.Button();
            this.btnUpdateCheck = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.currenceyTableAdapter = new PrintCheck.PrintCheckDataSetCurrencyTableAdapters.CurrenceyTableAdapter();
            this.view_AddCheckTableAdapter = new PrintCheck.PrintCheckDataSetAllChecksTableAdapters.View_AddCheckTableAdapter();
            this.view_AddCheckTableAdapter1 = new PrintCheck.PrintCheckDataSetDgvCheckTableAdapters.View_AddCheckTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.almustavidTableAdapter = new PrintCheck.PrintCheckDataSetAlmustafidTableAdapters.AlmustavidTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnDeletCheck = new System.Windows.Forms.Button();
            this.btnPrintCheck = new System.Windows.Forms.Button();
            this.pictureCheck = new System.Windows.Forms.PictureBox();
            this.btnBanks = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddCheckBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetDgvCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddCheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetAllChecks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenceyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenceyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTypBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet4)).BeginInit();
            this.groupChecData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almustavidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetAlmustafid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).BeginInit();
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
            this.checkIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.almustafidNamDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.mangerDataGridViewTextBoxColumn});
            this.dgvCheck.DataSource = this.viewAddCheckBindingSource1;
            this.dgvCheck.EnableHeadersVisualStyles = false;
            this.dgvCheck.GridColor = System.Drawing.Color.Red;
            this.dgvCheck.Location = new System.Drawing.Point(488, 502);
            this.dgvCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCheck.Name = "dgvCheck";
            this.dgvCheck.ReadOnly = true;
            this.dgvCheck.RowHeadersVisible = false;
            this.dgvCheck.RowHeadersWidth = 51;
            this.dgvCheck.Size = new System.Drawing.Size(975, 218);
            this.dgvCheck.TabIndex = 0;
            // 
            // checkIDDataGridViewTextBoxColumn
            // 
            this.checkIDDataGridViewTextBoxColumn.DataPropertyName = "CheckID";
            this.checkIDDataGridViewTextBoxColumn.HeaderText = "CheckID";
            this.checkIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkIDDataGridViewTextBoxColumn.Name = "checkIDDataGridViewTextBoxColumn";
            this.checkIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CheckNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "CheckNo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CheckDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CheckDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CheckAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "CheckAmount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // almustafidNamDataGridViewTextBoxColumn
            // 
            this.almustafidNamDataGridViewTextBoxColumn.DataPropertyName = "AlmustafidNam";
            this.almustafidNamDataGridViewTextBoxColumn.HeaderText = "AlmustafidNam";
            this.almustafidNamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.almustafidNamDataGridViewTextBoxColumn.Name = "almustafidNamDataGridViewTextBoxColumn";
            this.almustafidNamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CurrenceyName";
            this.dataGridViewTextBoxColumn4.HeaderText = "CurrenceyName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BankName";
            this.dataGridViewTextBoxColumn5.HeaderText = "BankName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ExpensesName";
            this.dataGridViewTextBoxColumn6.HeaderText = "ExpensesName";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CheckTypNam";
            this.dataGridViewTextBoxColumn7.HeaderText = "CheckTypNam";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // mangerDataGridViewTextBoxColumn
            // 
            this.mangerDataGridViewTextBoxColumn.DataPropertyName = "Manger";
            this.mangerDataGridViewTextBoxColumn.HeaderText = "Manger";
            this.mangerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mangerDataGridViewTextBoxColumn.Name = "mangerDataGridViewTextBoxColumn";
            this.mangerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewAddCheckBindingSource1
            // 
            this.viewAddCheckBindingSource1.DataMember = "View_AddCheck";
            this.viewAddCheckBindingSource1.DataSource = this.printCheckDataSetDgvCheck;
            // 
            // printCheckDataSetDgvCheck
            // 
            this.printCheckDataSetDgvCheck.DataSetName = "PrintCheckDataSetDgvCheck";
            this.printCheckDataSetDgvCheck.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAddCheckBindingSource
            // 
            this.viewAddCheckBindingSource.DataMember = "View_AddCheck";
            this.viewAddCheckBindingSource.DataSource = this.printCheckDataSetAllChecks;
            // 
            // printCheckDataSetAllChecks
            // 
            this.printCheckDataSetAllChecks.DataSetName = "PrintCheckDataSetAllChecks";
            this.printCheckDataSetAllChecks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewCheckBindingSource
            // 
            this.viewCheckBindingSource.DataMember = "View_Check";
            // 
            // txtCheckID
            // 
            this.txtCheckID.BackColor = System.Drawing.Color.White;
            this.txtCheckID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckID.Enabled = false;
            this.txtCheckID.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtCheckID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCheckID.Location = new System.Drawing.Point(234, 23);
            this.txtCheckID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckID.Name = "txtCheckID";
            this.txtCheckID.Size = new System.Drawing.Size(114, 26);
            this.txtCheckID.TabIndex = 1;
            this.txtCheckID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChechAmount
            // 
            this.txtChechAmount.BackColor = System.Drawing.Color.White;
            this.txtChechAmount.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChechAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChechAmount.Location = new System.Drawing.Point(171, 103);
            this.txtChechAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChechAmount.Name = "txtChechAmount";
            this.txtChechAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChechAmount.Size = new System.Drawing.Size(177, 35);
            this.txtChechAmount.TabIndex = 1;
            this.txtChechAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChechAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChechAmount_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "تاريخ الشيك";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم إذن الشيك";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "مبلغ الشيك";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "عملة الشيك";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "اسم البنك";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "إسم المستفيد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "نوع المصروف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "نوع الشيك";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbCurrency.DataSource = this.currenceyBindingSource1;
            this.cmbCurrency.DisplayMember = "CurrenceyName";
            this.cmbCurrency.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(108, 158);
            this.cmbCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(240, 35);
            this.cmbCurrency.TabIndex = 3;
            this.cmbCurrency.ValueMember = "CurrencyCod";
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrency_KeyDown);
            // 
            // currenceyBindingSource1
            // 
            this.currenceyBindingSource1.DataMember = "Currencey";
            this.currenceyBindingSource1.DataSource = this.printCheckDataSetCurrency;
            // 
            // printCheckDataSetCurrency
            // 
            this.printCheckDataSetCurrency.DataSetName = "PrintCheckDataSetCurrency";
            this.printCheckDataSetCurrency.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currenceyBindingSource
            // 
            this.currenceyBindingSource.DataMember = "Currencey";
            // 
            // cmbBankName
            // 
            this.cmbBankName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbBankName.DataSource = this.banksBindingSource;
            this.cmbBankName.DisplayMember = "BankName";
            this.cmbBankName.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBankName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(6, 188);
            this.cmbBankName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(342, 35);
            this.cmbBankName.TabIndex = 4;
            this.cmbBankName.ValueMember = "BankCod";
            this.cmbBankName.SelectedIndexChanged += new System.EventHandler(this.cmbBankName_SelectedIndexChanged);
            this.cmbBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankName_KeyDown);
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
            // cmbExpnses
            // 
            this.cmbExpnses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbExpnses.DataSource = this.expensesBindingSource;
            this.cmbExpnses.DisplayMember = "ExpensesName";
            this.cmbExpnses.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpnses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbExpnses.FormattingEnabled = true;
            this.cmbExpnses.Location = new System.Drawing.Point(108, 218);
            this.cmbExpnses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbExpnses.Name = "cmbExpnses";
            this.cmbExpnses.Size = new System.Drawing.Size(240, 35);
            this.cmbExpnses.TabIndex = 5;
            this.cmbExpnses.ValueMember = "ExpensesCod";
            this.cmbExpnses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpnses_KeyDown);
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
            // cmbChekTyp
            // 
            this.cmbChekTyp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbChekTyp.DataSource = this.checkTypBindingSource;
            this.cmbChekTyp.DisplayMember = "CheckTypNam";
            this.cmbChekTyp.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChekTyp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbChekTyp.FormattingEnabled = true;
            this.cmbChekTyp.Location = new System.Drawing.Point(108, 248);
            this.cmbChekTyp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChekTyp.MinimumSize = new System.Drawing.Size(174, 0);
            this.cmbChekTyp.Name = "cmbChekTyp";
            this.cmbChekTyp.Size = new System.Drawing.Size(240, 35);
            this.cmbChekTyp.TabIndex = 6;
            this.cmbChekTyp.ValueMember = "CheckTypCod";
            this.cmbChekTyp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChekTyp_KeyDown);
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
            // groupChecData
            // 
            this.groupChecData.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupChecData.Controls.Add(this.txtPHotoCheck);
            this.groupChecData.Controls.Add(this.btnInsertPic);
            this.groupChecData.Controls.Add(this.cmbAlmustafid);
            this.groupChecData.Controls.Add(this.txtChekDate);
            this.groupChecData.Controls.Add(this.txtCheckNO);
            this.groupChecData.Controls.Add(this.txtCheckID);
            this.groupChecData.Controls.Add(this.label11);
            this.groupChecData.Controls.Add(this.label8);
            this.groupChecData.Controls.Add(this.cmbChekTyp);
            this.groupChecData.Controls.Add(this.label7);
            this.groupChecData.Controls.Add(this.txtChechAmount);
            this.groupChecData.Controls.Add(this.label6);
            this.groupChecData.Controls.Add(this.cmbExpnses);
            this.groupChecData.Controls.Add(this.label5);
            this.groupChecData.Controls.Add(this.txtManger);
            this.groupChecData.Controls.Add(this.label4);
            this.groupChecData.Controls.Add(this.cmbBankName);
            this.groupChecData.Controls.Add(this.label3);
            this.groupChecData.Controls.Add(this.cmbCurrency);
            this.groupChecData.Controls.Add(this.label10);
            this.groupChecData.Controls.Add(this.label2);
            this.groupChecData.Controls.Add(this.label1);
            this.groupChecData.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.groupChecData.ForeColor = System.Drawing.Color.Black;
            this.groupChecData.Location = new System.Drawing.Point(0, 137);
            this.groupChecData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupChecData.Name = "groupChecData";
            this.groupChecData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupChecData.Size = new System.Drawing.Size(482, 367);
            this.groupChecData.TabIndex = 8;
            this.groupChecData.TabStop = false;
            this.groupChecData.Text = "بيانات الشيك";
            // 
            // txtPHotoCheck
            // 
            this.txtPHotoCheck.Location = new System.Drawing.Point(6, 311);
            this.txtPHotoCheck.Multiline = true;
            this.txtPHotoCheck.Name = "txtPHotoCheck";
            this.txtPHotoCheck.Size = new System.Drawing.Size(149, 43);
            this.txtPHotoCheck.TabIndex = 11;
            this.txtPHotoCheck.TextChanged += new System.EventHandler(this.txtPHotoCheck_TextChanged);
            // 
            // btnInsertPic
            // 
            this.btnInsertPic.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnInsertPic.Location = new System.Drawing.Point(161, 311);
            this.btnInsertPic.Name = "btnInsertPic";
            this.btnInsertPic.Size = new System.Drawing.Size(187, 43);
            this.btnInsertPic.TabIndex = 10;
            this.btnInsertPic.Text = "صورة الشيك";
            this.btnInsertPic.UseVisualStyleBackColor = true;
            this.btnInsertPic.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbAlmustafid
            // 
            this.cmbAlmustafid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbAlmustafid.DataSource = this.almustavidBindingSource;
            this.cmbAlmustafid.DisplayMember = "AlmustavidName";
            this.cmbAlmustafid.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlmustafid.FormattingEnabled = true;
            this.cmbAlmustafid.Location = new System.Drawing.Point(6, 132);
            this.cmbAlmustafid.Name = "cmbAlmustafid";
            this.cmbAlmustafid.Size = new System.Drawing.Size(342, 35);
            this.cmbAlmustafid.TabIndex = 0;
            this.cmbAlmustafid.ValueMember = "AlmustavidCod";
            this.cmbAlmustafid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAlmustafid_KeyDown);
            // 
            // almustavidBindingSource
            // 
            this.almustavidBindingSource.DataMember = "Almustavid";
            this.almustavidBindingSource.DataSource = this.printCheckDataSetAlmustafid;
            // 
            // printCheckDataSetAlmustafid
            // 
            this.printCheckDataSetAlmustafid.DataSetName = "PrintCheckDataSetAlmustafid";
            this.printCheckDataSetAlmustafid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtChekDate
            // 
            this.txtChekDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtChekDate.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtChekDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtChekDate.Location = new System.Drawing.Point(171, 75);
            this.txtChekDate.Name = "txtChekDate";
            this.txtChekDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChekDate.RightToLeftLayout = true;
            this.txtChekDate.Size = new System.Drawing.Size(177, 28);
            this.txtChekDate.TabIndex = 7;
            // 
            // txtCheckNO
            // 
            this.txtCheckNO.BackColor = System.Drawing.Color.White;
            this.txtCheckNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckNO.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtCheckNO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCheckNO.Location = new System.Drawing.Point(172, 49);
            this.txtCheckNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheckNO.Name = "txtCheckNO";
            this.txtCheckNO.Size = new System.Drawing.Size(176, 26);
            this.txtCheckNO.TabIndex = 1;
            this.txtCheckNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCheckNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckNO_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(366, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "توقيع المدير";
            // 
            // txtManger
            // 
            this.txtManger.BackColor = System.Drawing.Color.PaleGreen;
            this.txtManger.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManger.ForeColor = System.Drawing.Color.Black;
            this.txtManger.Location = new System.Drawing.Point(108, 278);
            this.txtManger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManger.Name = "txtManger";
            this.txtManger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtManger.Size = new System.Drawing.Size(240, 35);
            this.txtManger.TabIndex = 8;
            this.txtManger.Text = "Amr Alaa";
            this.txtManger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtManger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtManger_KeyDown_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(375, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "رقم  الشيك";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(708, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 37);
            this.label9.TabIndex = 9;
            this.label9.Text = "شاشة تسجيل الشيكات الصادرة";
            // 
            // btnAddCheck
            // 
            this.btnAddCheck.BackColor = System.Drawing.Color.Blue;
            this.btnAddCheck.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnAddCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCheck.Location = new System.Drawing.Point(-2, 566);
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
            this.btnUpdateCheck.Enabled = false;
            this.btnUpdateCheck.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnUpdateCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateCheck.Location = new System.Drawing.Point(120, 566);
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
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(238, 566);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 60);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // currenceyTableAdapter
            // 
            this.currenceyTableAdapter.ClearBeforeFill = true;
            // 
            // view_AddCheckTableAdapter
            // 
            this.view_AddCheckTableAdapter.ClearBeforeFill = true;
            // 
            // view_AddCheckTableAdapter1
            // 
            this.view_AddCheckTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1216, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // almustavidTableAdapter
            // 
            this.almustavidTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1475, 31);
            this.fillByToolStrip.TabIndex = 15;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // btnDeletCheck
            // 
            this.btnDeletCheck.BackColor = System.Drawing.Color.Blue;
            this.btnDeletCheck.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnDeletCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletCheck.Location = new System.Drawing.Point(0, 632);
            this.btnDeletCheck.Name = "btnDeletCheck";
            this.btnDeletCheck.Size = new System.Drawing.Size(111, 50);
            this.btnDeletCheck.TabIndex = 16;
            this.btnDeletCheck.Text = "الغاء شيك";
            this.btnDeletCheck.UseVisualStyleBackColor = false;
            // 
            // btnPrintCheck
            // 
            this.btnPrintCheck.BackColor = System.Drawing.Color.Blue;
            this.btnPrintCheck.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnPrintCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintCheck.Location = new System.Drawing.Point(120, 632);
            this.btnPrintCheck.Name = "btnPrintCheck";
            this.btnPrintCheck.Size = new System.Drawing.Size(112, 50);
            this.btnPrintCheck.TabIndex = 17;
            this.btnPrintCheck.Text = "طباعة شيك";
            this.btnPrintCheck.UseVisualStyleBackColor = false;
            // 
            // pictureCheck
            // 
            this.pictureCheck.Location = new System.Drawing.Point(605, 218);
            this.pictureCheck.Name = "pictureCheck";
            this.pictureCheck.Size = new System.Drawing.Size(768, 255);
            this.pictureCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCheck.TabIndex = 18;
            this.pictureCheck.TabStop = false;
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBanks.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanks.Location = new System.Drawing.Point(12, 30);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(155, 38);
            this.btnBanks.TabIndex = 19;
            this.btnBanks.Text = "إضافة بنك";
            this.btnBanks.UseVisualStyleBackColor = false;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(173, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 38);
            this.button3.TabIndex = 19;
            this.button3.Text = "طباعة شيك";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofd";
            // 
            // FormAddCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1475, 719);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBanks);
            this.Controls.Add(this.pictureCheck);
            this.Controls.Add(this.btnPrintCheck);
            this.Controls.Add(this.btnDeletCheck);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateCheck);
            this.Controls.Add(this.btnAddCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupChecData);
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
            ((System.ComponentModel.ISupportInitialize)(this.viewAddCheckBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetDgvCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAddCheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetAllChecks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenceyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currenceyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTypBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSet4)).EndInit();
            this.groupChecData.ResumeLayout(false);
            this.groupChecData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.almustavidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printCheckDataSetAlmustafid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private PrintCheckDataSet printCheckDataSet;
        private System.Windows.Forms.BindingSource viewCheckBindingSource;
        //private PrintCheckDataSetTableAdapters.View_CheckTableAdapter view_CheckTableAdapter;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCurrency;
        //private PrintCheckDataSet1 printCheckDataSet1;
        private System.Windows.Forms.BindingSource currenceyBindingSource;
        //private PrintCheckDataSet1TableAdapters.CurrenceyTableAdapter currenceyTableAdapter;
        private System.Windows.Forms.ComboBox cmbBankName;
        private PrintCheckDataSet2 printCheckDataSet2;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private PrintCheckDataSet2TableAdapters.BanksTableAdapter banksTableAdapter;
        private System.Windows.Forms.ComboBox cmbExpnses;
        private System.Windows.Forms.ComboBox cmbChekTyp;
        private PrintCheckDataSet3 printCheckDataSet3;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private PrintCheckDataSet3TableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private PrintCheckDataSet4 printCheckDataSet4;
        private System.Windows.Forms.BindingSource checkTypBindingSource;
        private PrintCheckDataSet4TableAdapters.CheckTypTableAdapter checkTypTableAdapter;
        private System.Windows.Forms.GroupBox groupChecData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddCheck;
        private System.Windows.Forms.Button btnUpdateCheck;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtCheckID;
        public System.Windows.Forms.TextBox txtCheckNO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker txtChekDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private PrintCheckDataSetCurrency printCheckDataSetCurrency;
        private System.Windows.Forms.BindingSource currenceyBindingSource1;
        private PrintCheckDataSetCurrencyTableAdapters.CurrenceyTableAdapter currenceyTableAdapter;
        private PrintCheckDataSetAllChecks printCheckDataSetAllChecks;
        private System.Windows.Forms.BindingSource viewAddCheckBindingSource;
        private PrintCheckDataSetAllChecksTableAdapters.View_AddCheckTableAdapter view_AddCheckTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtManger;
        private PrintCheckDataSetDgvCheck printCheckDataSetDgvCheck;
        private System.Windows.Forms.BindingSource viewAddCheckBindingSource1;
        private PrintCheckDataSetDgvCheckTableAdapters.View_AddCheckTableAdapter view_AddCheckTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn almustafidNamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangerDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PrintCheckDataSetAlmustafid printCheckDataSetAlmustafid;
        private System.Windows.Forms.BindingSource almustavidBindingSource;
        private PrintCheckDataSetAlmustafidTableAdapters.AlmustavidTableAdapter almustavidTableAdapter;
        public System.Windows.Forms.ComboBox cmbAlmustafid;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button btnDeletCheck;
        private System.Windows.Forms.Button btnPrintCheck;
        private System.Windows.Forms.PictureBox pictureCheck;
        private System.Windows.Forms.Button btnInsertPic;
        private System.Windows.Forms.TextBox txtPHotoCheck;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}