namespace Contab
{
    partial class OperationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Informations = new System.Windows.Forms.Panel();
            this.lbl_Currency = new System.Windows.Forms.Label();
            this.lbl_CurrencyValue = new System.Windows.Forms.Label();
            this.lbl_CurrentMoney = new System.Windows.Forms.Label();
            this.lbl_CurrentMoneyValue = new System.Windows.Forms.Label();
            this.lbl_StartingDate = new System.Windows.Forms.Label();
            this.lbl_StartingDateValue = new System.Windows.Forms.Label();
            this.lbl_StartingMoney = new System.Windows.Forms.Label();
            this.lbl_StartingMoneyValue = new System.Windows.Forms.Label();
            this.lbl_UserValue = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.pnl_Data = new System.Windows.Forms.Panel();
            this.dgv_Operations = new System.Windows.Forms.DataGridView();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_ViewChart = new System.Windows.Forms.Button();
            this.pnl_AddSubtract = new System.Windows.Forms.Panel();
            this.chk_ColorsAddSubtract = new System.Windows.Forms.CheckBox();
            this.lbl_AddColor = new System.Windows.Forms.Label();
            this.lbl_SubtractColorExplanation = new System.Windows.Forms.Label();
            this.lbl_AddColorExplanation = new System.Windows.Forms.Label();
            this.lbl_SubtractColor = new System.Windows.Forms.Label();
            this.pnl_ExpectedMoney = new System.Windows.Forms.Panel();
            this.chk_ColorsExpectedMoney = new System.Windows.Forms.CheckBox();
            this.lbl_ExpectedColor = new System.Windows.Forms.Label();
            this.lbl_ExpectedColorExplanation = new System.Windows.Forms.Label();
            this.lbl_NotExpectedColor = new System.Windows.Forms.Label();
            this.lbl_NotExpectedColorExplanation = new System.Windows.Forms.Label();
            this.btn_OpenNotes = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_AddOperation = new System.Windows.Forms.Button();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddSubtract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAfterOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedMoneyAfterOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_Informations.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Operations)).BeginInit();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_AddSubtract.SuspendLayout();
            this.pnl_ExpectedMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Informations
            // 
            this.pnl_Informations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Informations.Controls.Add(this.lbl_Currency);
            this.pnl_Informations.Controls.Add(this.lbl_CurrencyValue);
            this.pnl_Informations.Controls.Add(this.lbl_CurrentMoney);
            this.pnl_Informations.Controls.Add(this.lbl_CurrentMoneyValue);
            this.pnl_Informations.Controls.Add(this.lbl_StartingDate);
            this.pnl_Informations.Controls.Add(this.lbl_StartingDateValue);
            this.pnl_Informations.Controls.Add(this.lbl_StartingMoney);
            this.pnl_Informations.Controls.Add(this.lbl_StartingMoneyValue);
            this.pnl_Informations.Controls.Add(this.lbl_UserValue);
            this.pnl_Informations.Controls.Add(this.lbl_User);
            this.pnl_Informations.Location = new System.Drawing.Point(10, 11);
            this.pnl_Informations.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Informations.Name = "pnl_Informations";
            this.pnl_Informations.Size = new System.Drawing.Size(1013, 35);
            this.pnl_Informations.TabIndex = 0;
            // 
            // lbl_Currency
            // 
            this.lbl_Currency.AutoSize = true;
            this.lbl_Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Currency.Location = new System.Drawing.Point(387, 10);
            this.lbl_Currency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Currency.Name = "lbl_Currency";
            this.lbl_Currency.Size = new System.Drawing.Size(73, 17);
            this.lbl_Currency.TabIndex = 10;
            this.lbl_Currency.Text = "Currency: ";
            // 
            // lbl_CurrencyValue
            // 
            this.lbl_CurrencyValue.AutoSize = true;
            this.lbl_CurrencyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrencyValue.Location = new System.Drawing.Point(458, 10);
            this.lbl_CurrencyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CurrencyValue.Name = "lbl_CurrencyValue";
            this.lbl_CurrencyValue.Size = new System.Drawing.Size(0, 17);
            this.lbl_CurrencyValue.TabIndex = 9;
            // 
            // lbl_CurrentMoney
            // 
            this.lbl_CurrentMoney.AutoSize = true;
            this.lbl_CurrentMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentMoney.Location = new System.Drawing.Point(538, 10);
            this.lbl_CurrentMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CurrentMoney.Name = "lbl_CurrentMoney";
            this.lbl_CurrentMoney.Size = new System.Drawing.Size(109, 17);
            this.lbl_CurrentMoney.TabIndex = 8;
            this.lbl_CurrentMoney.Text = "Current Money: ";
            // 
            // lbl_CurrentMoneyValue
            // 
            this.lbl_CurrentMoneyValue.AutoSize = true;
            this.lbl_CurrentMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentMoneyValue.Location = new System.Drawing.Point(643, 10);
            this.lbl_CurrentMoneyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CurrentMoneyValue.Name = "lbl_CurrentMoneyValue";
            this.lbl_CurrentMoneyValue.Size = new System.Drawing.Size(0, 17);
            this.lbl_CurrentMoneyValue.TabIndex = 7;
            // 
            // lbl_StartingDate
            // 
            this.lbl_StartingDate.AutoSize = true;
            this.lbl_StartingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartingDate.Location = new System.Drawing.Point(764, 10);
            this.lbl_StartingDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StartingDate.Name = "lbl_StartingDate";
            this.lbl_StartingDate.Size = new System.Drawing.Size(99, 17);
            this.lbl_StartingDate.TabIndex = 6;
            this.lbl_StartingDate.Text = "Starting Date: ";
            // 
            // lbl_StartingDateValue
            // 
            this.lbl_StartingDateValue.AutoSize = true;
            this.lbl_StartingDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartingDateValue.Location = new System.Drawing.Point(860, 10);
            this.lbl_StartingDateValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StartingDateValue.Name = "lbl_StartingDateValue";
            this.lbl_StartingDateValue.Size = new System.Drawing.Size(0, 17);
            this.lbl_StartingDateValue.TabIndex = 5;
            // 
            // lbl_StartingMoney
            // 
            this.lbl_StartingMoney.AutoSize = true;
            this.lbl_StartingMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartingMoney.Location = new System.Drawing.Point(185, 10);
            this.lbl_StartingMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StartingMoney.Name = "lbl_StartingMoney";
            this.lbl_StartingMoney.Size = new System.Drawing.Size(111, 17);
            this.lbl_StartingMoney.TabIndex = 4;
            this.lbl_StartingMoney.Text = "Starting Money: ";
            // 
            // lbl_StartingMoneyValue
            // 
            this.lbl_StartingMoneyValue.AutoSize = true;
            this.lbl_StartingMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartingMoneyValue.Location = new System.Drawing.Point(292, 10);
            this.lbl_StartingMoneyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StartingMoneyValue.Name = "lbl_StartingMoneyValue";
            this.lbl_StartingMoneyValue.Size = new System.Drawing.Size(0, 17);
            this.lbl_StartingMoneyValue.TabIndex = 3;
            // 
            // lbl_UserValue
            // 
            this.lbl_UserValue.AutoSize = true;
            this.lbl_UserValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserValue.Location = new System.Drawing.Point(46, 10);
            this.lbl_UserValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserValue.Name = "lbl_UserValue";
            this.lbl_UserValue.Size = new System.Drawing.Size(0, 17);
            this.lbl_UserValue.TabIndex = 1;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(10, 10);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(46, 17);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "User: ";
            // 
            // pnl_Data
            // 
            this.pnl_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Data.Controls.Add(this.dgv_Operations);
            this.pnl_Data.Location = new System.Drawing.Point(10, 51);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(1013, 483);
            this.pnl_Data.TabIndex = 1;
            // 
            // dgv_Operations
            // 
            this.dgv_Operations.AllowUserToAddRows = false;
            this.dgv_Operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Operations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.CurrentMoney,
            this.AddSubtract,
            this.Reason,
            this.MoneyAfterOperation,
            this.ExpectedMoneyAfterOperation,
            this.OperationDate,
            this.CurrentDate,
            this.Edit});
            this.dgv_Operations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Operations.Location = new System.Drawing.Point(0, 0);
            this.dgv_Operations.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Operations.Name = "dgv_Operations";
            this.dgv_Operations.RowTemplate.Height = 24;
            this.dgv_Operations.Size = new System.Drawing.Size(1011, 481);
            this.dgv_Operations.TabIndex = 0;
            this.dgv_Operations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Operations_CellClick);
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Buttons.Controls.Add(this.btn_ViewChart);
            this.pnl_Buttons.Controls.Add(this.pnl_AddSubtract);
            this.pnl_Buttons.Controls.Add(this.pnl_ExpectedMoney);
            this.pnl_Buttons.Controls.Add(this.btn_OpenNotes);
            this.pnl_Buttons.Controls.Add(this.btn_Logout);
            this.pnl_Buttons.Controls.Add(this.btn_AddOperation);
            this.pnl_Buttons.Location = new System.Drawing.Point(10, 539);
            this.pnl_Buttons.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(1013, 64);
            this.pnl_Buttons.TabIndex = 2;
            // 
            // btn_ViewChart
            // 
            this.btn_ViewChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewChart.Location = new System.Drawing.Point(248, 16);
            this.btn_ViewChart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewChart.Name = "btn_ViewChart";
            this.btn_ViewChart.Size = new System.Drawing.Size(93, 33);
            this.btn_ViewChart.TabIndex = 15;
            this.btn_ViewChart.Text = "View Chart";
            this.btn_ViewChart.UseVisualStyleBackColor = true;
            this.btn_ViewChart.Click += new System.EventHandler(this.btn_ViewChart_Click);
            // 
            // pnl_AddSubtract
            // 
            this.pnl_AddSubtract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_AddSubtract.Controls.Add(this.chk_ColorsAddSubtract);
            this.pnl_AddSubtract.Controls.Add(this.lbl_AddColor);
            this.pnl_AddSubtract.Controls.Add(this.lbl_SubtractColorExplanation);
            this.pnl_AddSubtract.Controls.Add(this.lbl_AddColorExplanation);
            this.pnl_AddSubtract.Controls.Add(this.lbl_SubtractColor);
            this.pnl_AddSubtract.Location = new System.Drawing.Point(829, 3);
            this.pnl_AddSubtract.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_AddSubtract.Name = "pnl_AddSubtract";
            this.pnl_AddSubtract.Size = new System.Drawing.Size(180, 57);
            this.pnl_AddSubtract.TabIndex = 14;
            // 
            // chk_ColorsAddSubtract
            // 
            this.chk_ColorsAddSubtract.AutoSize = true;
            this.chk_ColorsAddSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ColorsAddSubtract.Location = new System.Drawing.Point(6, 3);
            this.chk_ColorsAddSubtract.Margin = new System.Windows.Forms.Padding(2);
            this.chk_ColorsAddSubtract.Name = "chk_ColorsAddSubtract";
            this.chk_ColorsAddSubtract.Size = new System.Drawing.Size(174, 21);
            this.chk_ColorsAddSubtract.TabIndex = 2;
            this.chk_ColorsAddSubtract.Text = "Colors for Add/Subtract";
            this.chk_ColorsAddSubtract.UseVisualStyleBackColor = true;
            this.chk_ColorsAddSubtract.CheckedChanged += new System.EventHandler(this.chk_ColorsAddSubtract_CheckedChanged);
            // 
            // lbl_AddColor
            // 
            this.lbl_AddColor.AutoSize = true;
            this.lbl_AddColor.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl_AddColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AddColor.Location = new System.Drawing.Point(6, 32);
            this.lbl_AddColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AddColor.MaximumSize = new System.Drawing.Size(14, 15);
            this.lbl_AddColor.MinimumSize = new System.Drawing.Size(14, 15);
            this.lbl_AddColor.Name = "lbl_AddColor";
            this.lbl_AddColor.Size = new System.Drawing.Size(14, 15);
            this.lbl_AddColor.TabIndex = 9;
            // 
            // lbl_SubtractColorExplanation
            // 
            this.lbl_SubtractColorExplanation.AutoSize = true;
            this.lbl_SubtractColorExplanation.Location = new System.Drawing.Point(78, 32);
            this.lbl_SubtractColorExplanation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SubtractColorExplanation.Name = "lbl_SubtractColorExplanation";
            this.lbl_SubtractColorExplanation.Size = new System.Drawing.Size(53, 13);
            this.lbl_SubtractColorExplanation.TabIndex = 12;
            this.lbl_SubtractColorExplanation.Text = "- Subtract";
            // 
            // lbl_AddColorExplanation
            // 
            this.lbl_AddColorExplanation.AutoSize = true;
            this.lbl_AddColorExplanation.Location = new System.Drawing.Point(24, 32);
            this.lbl_AddColorExplanation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AddColorExplanation.Name = "lbl_AddColorExplanation";
            this.lbl_AddColorExplanation.Size = new System.Drawing.Size(32, 13);
            this.lbl_AddColorExplanation.TabIndex = 10;
            this.lbl_AddColorExplanation.Text = "- Add";
            // 
            // lbl_SubtractColor
            // 
            this.lbl_SubtractColor.AutoSize = true;
            this.lbl_SubtractColor.BackColor = System.Drawing.Color.Red;
            this.lbl_SubtractColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SubtractColor.Location = new System.Drawing.Point(60, 32);
            this.lbl_SubtractColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SubtractColor.MaximumSize = new System.Drawing.Size(14, 15);
            this.lbl_SubtractColor.MinimumSize = new System.Drawing.Size(14, 15);
            this.lbl_SubtractColor.Name = "lbl_SubtractColor";
            this.lbl_SubtractColor.Size = new System.Drawing.Size(14, 15);
            this.lbl_SubtractColor.TabIndex = 11;
            // 
            // pnl_ExpectedMoney
            // 
            this.pnl_ExpectedMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_ExpectedMoney.Controls.Add(this.chk_ColorsExpectedMoney);
            this.pnl_ExpectedMoney.Controls.Add(this.lbl_ExpectedColor);
            this.pnl_ExpectedMoney.Controls.Add(this.lbl_ExpectedColorExplanation);
            this.pnl_ExpectedMoney.Controls.Add(this.lbl_NotExpectedColor);
            this.pnl_ExpectedMoney.Controls.Add(this.lbl_NotExpectedColorExplanation);
            this.pnl_ExpectedMoney.Location = new System.Drawing.Point(623, 2);
            this.pnl_ExpectedMoney.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ExpectedMoney.Name = "pnl_ExpectedMoney";
            this.pnl_ExpectedMoney.Size = new System.Drawing.Size(202, 57);
            this.pnl_ExpectedMoney.TabIndex = 13;
            // 
            // chk_ColorsExpectedMoney
            // 
            this.chk_ColorsExpectedMoney.AutoSize = true;
            this.chk_ColorsExpectedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ColorsExpectedMoney.Location = new System.Drawing.Point(8, 3);
            this.chk_ColorsExpectedMoney.Margin = new System.Windows.Forms.Padding(2);
            this.chk_ColorsExpectedMoney.Name = "chk_ColorsExpectedMoney";
            this.chk_ColorsExpectedMoney.Size = new System.Drawing.Size(196, 21);
            this.chk_ColorsExpectedMoney.TabIndex = 4;
            this.chk_ColorsExpectedMoney.Text = "Colors for Expected Money";
            this.chk_ColorsExpectedMoney.UseVisualStyleBackColor = true;
            this.chk_ColorsExpectedMoney.CheckedChanged += new System.EventHandler(this.chk_ColorsExpectedMoney_CheckedChanged);
            // 
            // lbl_ExpectedColor
            // 
            this.lbl_ExpectedColor.AutoSize = true;
            this.lbl_ExpectedColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_ExpectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ExpectedColor.Location = new System.Drawing.Point(8, 32);
            this.lbl_ExpectedColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ExpectedColor.MaximumSize = new System.Drawing.Size(14, 15);
            this.lbl_ExpectedColor.MinimumSize = new System.Drawing.Size(14, 15);
            this.lbl_ExpectedColor.Name = "lbl_ExpectedColor";
            this.lbl_ExpectedColor.Size = new System.Drawing.Size(14, 15);
            this.lbl_ExpectedColor.TabIndex = 5;
            // 
            // lbl_ExpectedColorExplanation
            // 
            this.lbl_ExpectedColorExplanation.AutoSize = true;
            this.lbl_ExpectedColorExplanation.Location = new System.Drawing.Point(26, 32);
            this.lbl_ExpectedColorExplanation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ExpectedColorExplanation.Name = "lbl_ExpectedColorExplanation";
            this.lbl_ExpectedColorExplanation.Size = new System.Drawing.Size(58, 13);
            this.lbl_ExpectedColorExplanation.TabIndex = 6;
            this.lbl_ExpectedColorExplanation.Text = "- Expected";
            // 
            // lbl_NotExpectedColor
            // 
            this.lbl_NotExpectedColor.AutoSize = true;
            this.lbl_NotExpectedColor.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_NotExpectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_NotExpectedColor.Location = new System.Drawing.Point(86, 32);
            this.lbl_NotExpectedColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NotExpectedColor.MaximumSize = new System.Drawing.Size(14, 15);
            this.lbl_NotExpectedColor.MinimumSize = new System.Drawing.Size(14, 15);
            this.lbl_NotExpectedColor.Name = "lbl_NotExpectedColor";
            this.lbl_NotExpectedColor.Size = new System.Drawing.Size(14, 15);
            this.lbl_NotExpectedColor.TabIndex = 7;
            // 
            // lbl_NotExpectedColorExplanation
            // 
            this.lbl_NotExpectedColorExplanation.AutoSize = true;
            this.lbl_NotExpectedColorExplanation.Location = new System.Drawing.Point(104, 32);
            this.lbl_NotExpectedColorExplanation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NotExpectedColorExplanation.Name = "lbl_NotExpectedColorExplanation";
            this.lbl_NotExpectedColorExplanation.Size = new System.Drawing.Size(78, 13);
            this.lbl_NotExpectedColorExplanation.TabIndex = 8;
            this.lbl_NotExpectedColorExplanation.Text = "- Not Expected";
            // 
            // btn_OpenNotes
            // 
            this.btn_OpenNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenNotes.Location = new System.Drawing.Point(136, 16);
            this.btn_OpenNotes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OpenNotes.Name = "btn_OpenNotes";
            this.btn_OpenNotes.Size = new System.Drawing.Size(107, 33);
            this.btn_OpenNotes.TabIndex = 3;
            this.btn_OpenNotes.Text = "Open Notes";
            this.btn_OpenNotes.UseVisualStyleBackColor = true;
            this.btn_OpenNotes.Click += new System.EventHandler(this.btnOpenNotes_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(346, 16);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(70, 33);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_AddOperation
            // 
            this.btn_AddOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOperation.Location = new System.Drawing.Point(14, 16);
            this.btn_AddOperation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddOperation.Name = "btn_AddOperation";
            this.btn_AddOperation.Size = new System.Drawing.Size(118, 33);
            this.btn_AddOperation.TabIndex = 0;
            this.btn_AddOperation.Text = "Add Operation";
            this.btn_AddOperation.UseVisualStyleBackColor = true;
            this.btn_AddOperation.Click += new System.EventHandler(this.btn_AddOperation_Click);
            // 
            // Nr
            // 
            this.Nr.HeaderText = "Nr";
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            this.Nr.Width = 40;
            // 
            // CurrentMoney
            // 
            this.CurrentMoney.HeaderText = "Current Money";
            this.CurrentMoney.Name = "CurrentMoney";
            this.CurrentMoney.ReadOnly = true;
            this.CurrentMoney.Width = 70;
            // 
            // AddSubtract
            // 
            this.AddSubtract.HeaderText = "Add/Subtract";
            this.AddSubtract.Name = "AddSubtract";
            this.AddSubtract.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Width = 380;
            // 
            // MoneyAfterOperation
            // 
            this.MoneyAfterOperation.HeaderText = "Money after operation";
            this.MoneyAfterOperation.Name = "MoneyAfterOperation";
            this.MoneyAfterOperation.ReadOnly = true;
            this.MoneyAfterOperation.Width = 70;
            // 
            // ExpectedMoneyAfterOperation
            // 
            this.ExpectedMoneyAfterOperation.HeaderText = "Expected money after operation";
            this.ExpectedMoneyAfterOperation.Name = "ExpectedMoneyAfterOperation";
            this.ExpectedMoneyAfterOperation.ReadOnly = true;
            this.ExpectedMoneyAfterOperation.Width = 70;
            // 
            // OperationDate
            // 
            this.OperationDate.HeaderText = "Operation Date";
            this.OperationDate.Name = "OperationDate";
            this.OperationDate.ReadOnly = true;
            this.OperationDate.Width = 70;
            // 
            // CurrentDate
            // 
            this.CurrentDate.HeaderText = "Current Date";
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.ReadOnly = true;
            this.CurrentDate.Width = 130;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Contab.Properties.Resources.Edit;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 20;
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 618);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.pnl_Informations);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 657);
            this.MinimumSize = new System.Drawing.Size(1050, 657);
            this.Name = "OperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OperationsForm_FormClosed);
            this.pnl_Informations.ResumeLayout(false);
            this.pnl_Informations.PerformLayout();
            this.pnl_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Operations)).EndInit();
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_AddSubtract.ResumeLayout(false);
            this.pnl_AddSubtract.PerformLayout();
            this.pnl_ExpectedMoney.ResumeLayout(false);
            this.pnl_ExpectedMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Informations;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Panel pnl_Data;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Label lbl_UserValue;
        private System.Windows.Forms.Label lbl_StartingMoneyValue;
        private System.Windows.Forms.Label lbl_StartingMoney;
        private System.Windows.Forms.Label lbl_StartingDate;
        private System.Windows.Forms.Label lbl_StartingDateValue;
        private System.Windows.Forms.DataGridView dgv_Operations;
        private System.Windows.Forms.CheckBox chk_ColorsAddSubtract;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_AddOperation;
        private System.Windows.Forms.Button btn_OpenNotes;
        private System.Windows.Forms.Label lbl_CurrentMoney;
        private System.Windows.Forms.Label lbl_CurrentMoneyValue;
        private System.Windows.Forms.CheckBox chk_ColorsExpectedMoney;
        private System.Windows.Forms.Label lbl_ExpectedColor;
        private System.Windows.Forms.Label lbl_NotExpectedColorExplanation;
        private System.Windows.Forms.Label lbl_NotExpectedColor;
        private System.Windows.Forms.Label lbl_ExpectedColorExplanation;
        private System.Windows.Forms.Label lbl_SubtractColorExplanation;
        private System.Windows.Forms.Label lbl_SubtractColor;
        private System.Windows.Forms.Label lbl_AddColorExplanation;
        private System.Windows.Forms.Label lbl_AddColor;
        private System.Windows.Forms.Panel pnl_ExpectedMoney;
        private System.Windows.Forms.Panel pnl_AddSubtract;
        private System.Windows.Forms.Label lbl_Currency;
        private System.Windows.Forms.Label lbl_CurrencyValue;
        private System.Windows.Forms.Button btn_ViewChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddSubtract;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAfterOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedMoneyAfterOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentDate;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}