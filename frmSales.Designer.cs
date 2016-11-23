namespace Pinger
{
    partial class frmSales
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
            this.datBegin = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.cmdCompName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.SuspendLayout();
            // 
            // datBegin
            // 
            this.datBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datBegin.Location = new System.Drawing.Point(84, 19);
            this.datBegin.Name = "datBegin";
            this.datBegin.RightToLeftLayout = true;
            this.datBegin.Size = new System.Drawing.Size(85, 20);
            this.datBegin.TabIndex = 0;
            this.datBegin.Value = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
            // 
            // datEnd
            // 
            this.datEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datEnd.Location = new System.Drawing.Point(84, 45);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(85, 20);
            this.datEnd.TabIndex = 0;
            // 
            // cmdCompName
            // 
            this.cmdCompName.FormattingEnabled = true;
            this.cmdCompName.Location = new System.Drawing.Point(70, 34);
            this.cmdCompName.Name = "cmdCompName";
            this.cmdCompName.Size = new System.Drawing.Size(85, 21);
            this.cmdCompName.TabIndex = 1;
            this.cmdCompName.SelectedIndexChanged += new System.EventHandler(this.cmdCompName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Планшет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата начала";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datBegin);
            this.groupBox1.Controls.Add(this.datEnd);
            this.groupBox1.Location = new System.Drawing.Point(161, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата конца";
            // 
            // gridSales
            // 
            this.gridSales.AllowUserToAddRows = false;
            this.gridSales.AllowUserToDeleteRows = false;
            this.gridSales.AllowUserToResizeColumns = false;
            this.gridSales.AllowUserToResizeRows = false;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime,
            this.colType,
            this.colName,
            this.colPrice,
            this.colAmount});
            this.gridSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridSales.Location = new System.Drawing.Point(12, 94);
            this.gridSales.MultiSelect = false;
            this.gridSales.Name = "gridSales";
            this.gridSales.RowHeadersVisible = false;
            this.gridSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSales.Size = new System.Drawing.Size(755, 353);
            this.gridSales.TabIndex = 4;
            // 
            // colTime
            // 
            this.colTime.Frozen = true;
            this.colTime.HeaderText = "Время";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 150;
            // 
            // colType
            // 
            this.colType.Frozen = true;
            this.colType.HeaderText = "Тип операции";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.Frozen = true;
            this.colName.HeaderText = "Товар";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 285;
            // 
            // colPrice
            // 
            this.colPrice.Frozen = true;
            this.colPrice.HeaderText = "Цена";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.Frozen = true;
            this.colAmount.HeaderText = "Сумма";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 458);
            this.Controls.Add(this.gridSales);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCompName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSales";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datBegin;
        private System.Windows.Forms.DateTimePicker datEnd;
        private System.Windows.Forms.ComboBox cmdCompName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}