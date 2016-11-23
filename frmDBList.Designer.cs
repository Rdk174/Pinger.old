namespace Pinger
{
    partial class frmDBList
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
            this.dgvPosList = new System.Windows.Forms.DataGridView();
            this.eGAISESPOSLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eGAIS_ES_POS_LISTTableAdapter = new Pinger.DataSet1TableAdapters.EGAIS_ES_POS_LISTTableAdapter();
            this.dataSet1 = new Pinger.DataSet1();
            this.cHANGEPRICEENABLEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXTERNALINNSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYNCTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESTSENABLEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSRARIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vERSIONUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vERSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORBIDDENPERIODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wARNINGPERIODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERSINNSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEBEGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eGAISESPOSLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosList
            // 
            this.dgvPosList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPosList.AutoGenerateColumns = false;
            this.dgvPosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEGIDDataGridViewTextBoxColumn,
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.dATEBEGINDataGridViewTextBoxColumn,
            this.dATEENDDataGridViewTextBoxColumn,
            this.sUPPLIERSINNSDataGridViewTextBoxColumn,
            this.wARNINGPERIODDataGridViewTextBoxColumn,
            this.fORBIDDENPERIODDataGridViewTextBoxColumn,
            this.vERSIONDataGridViewTextBoxColumn,
            this.vERSIONUPDATEDataGridViewTextBoxColumn,
            this.fSRARIDDataGridViewTextBoxColumn,
            this.tSDataGridViewTextBoxColumn,
            this.rESTSENABLEDDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.sYNCTIMEDataGridViewTextBoxColumn,
            this.cOMPNAMEDataGridViewTextBoxColumn,
            this.eXTERNALINNSDataGridViewTextBoxColumn,
            this.cHANGEPRICEENABLEDDataGridViewTextBoxColumn});
            this.dgvPosList.DataSource = this.eGAISESPOSLISTBindingSource;
            this.dgvPosList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPosList.Location = new System.Drawing.Point(12, 12);
            this.dgvPosList.Name = "dgvPosList";
            this.dgvPosList.ReadOnly = true;
            this.dgvPosList.Size = new System.Drawing.Size(1236, 440);
            this.dgvPosList.TabIndex = 0;
            // 
            // eGAISESPOSLISTBindingSource
            // 
            this.eGAISESPOSLISTBindingSource.DataSource = this.dataSet1BindingSource;
            this.eGAISESPOSLISTBindingSource.CurrentChanged += new System.EventHandler(this.eGAISESPOSLISTBindingSource_CurrentChanged);
            // 
            // eGAIS_ES_POS_LISTTableAdapter
            // 
            this.eGAIS_ES_POS_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHANGEPRICEENABLEDDataGridViewTextBoxColumn
            // 
            this.cHANGEPRICEENABLEDDataGridViewTextBoxColumn.DataPropertyName = "CHANGE_PRICE_ENABLED";
            this.cHANGEPRICEENABLEDDataGridViewTextBoxColumn.HeaderText = "CHANGE_PRICE_ENABLED";
            this.cHANGEPRICEENABLEDDataGridViewTextBoxColumn.Name = "cHANGEPRICEENABLEDDataGridViewTextBoxColumn";
            this.cHANGEPRICEENABLEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eXTERNALINNSDataGridViewTextBoxColumn
            // 
            this.eXTERNALINNSDataGridViewTextBoxColumn.DataPropertyName = "EXTERNAL_INNS";
            this.eXTERNALINNSDataGridViewTextBoxColumn.HeaderText = "EXTERNAL_INNS";
            this.eXTERNALINNSDataGridViewTextBoxColumn.Name = "eXTERNALINNSDataGridViewTextBoxColumn";
            this.eXTERNALINNSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPNAMEDataGridViewTextBoxColumn
            // 
            this.cOMPNAMEDataGridViewTextBoxColumn.DataPropertyName = "COMP_NAME";
            this.cOMPNAMEDataGridViewTextBoxColumn.HeaderText = "COMP_NAME";
            this.cOMPNAMEDataGridViewTextBoxColumn.Name = "cOMPNAMEDataGridViewTextBoxColumn";
            this.cOMPNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sYNCTIMEDataGridViewTextBoxColumn
            // 
            this.sYNCTIMEDataGridViewTextBoxColumn.DataPropertyName = "SYNC_TIME";
            this.sYNCTIMEDataGridViewTextBoxColumn.HeaderText = "SYNC_TIME";
            this.sYNCTIMEDataGridViewTextBoxColumn.Name = "sYNCTIMEDataGridViewTextBoxColumn";
            this.sYNCTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            this.iPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rESTSENABLEDDataGridViewTextBoxColumn
            // 
            this.rESTSENABLEDDataGridViewTextBoxColumn.DataPropertyName = "RESTS_ENABLED";
            this.rESTSENABLEDDataGridViewTextBoxColumn.HeaderText = "RESTS_ENABLED";
            this.rESTSENABLEDDataGridViewTextBoxColumn.Name = "rESTSENABLEDDataGridViewTextBoxColumn";
            this.rESTSENABLEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tSDataGridViewTextBoxColumn
            // 
            this.tSDataGridViewTextBoxColumn.DataPropertyName = "TS";
            this.tSDataGridViewTextBoxColumn.HeaderText = "TS";
            this.tSDataGridViewTextBoxColumn.Name = "tSDataGridViewTextBoxColumn";
            this.tSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fSRARIDDataGridViewTextBoxColumn
            // 
            this.fSRARIDDataGridViewTextBoxColumn.DataPropertyName = "FSRAR_ID";
            this.fSRARIDDataGridViewTextBoxColumn.HeaderText = "FSRAR_ID";
            this.fSRARIDDataGridViewTextBoxColumn.Name = "fSRARIDDataGridViewTextBoxColumn";
            this.fSRARIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vERSIONUPDATEDataGridViewTextBoxColumn
            // 
            this.vERSIONUPDATEDataGridViewTextBoxColumn.DataPropertyName = "VERSION_UPDATE";
            this.vERSIONUPDATEDataGridViewTextBoxColumn.HeaderText = "VERSION_UPDATE";
            this.vERSIONUPDATEDataGridViewTextBoxColumn.Name = "vERSIONUPDATEDataGridViewTextBoxColumn";
            this.vERSIONUPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vERSIONDataGridViewTextBoxColumn
            // 
            this.vERSIONDataGridViewTextBoxColumn.DataPropertyName = "VERSION";
            this.vERSIONDataGridViewTextBoxColumn.HeaderText = "VERSION";
            this.vERSIONDataGridViewTextBoxColumn.Name = "vERSIONDataGridViewTextBoxColumn";
            this.vERSIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fORBIDDENPERIODDataGridViewTextBoxColumn
            // 
            this.fORBIDDENPERIODDataGridViewTextBoxColumn.DataPropertyName = "FORBIDDEN_PERIOD";
            this.fORBIDDENPERIODDataGridViewTextBoxColumn.HeaderText = "FORBIDDEN_PERIOD";
            this.fORBIDDENPERIODDataGridViewTextBoxColumn.Name = "fORBIDDENPERIODDataGridViewTextBoxColumn";
            this.fORBIDDENPERIODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wARNINGPERIODDataGridViewTextBoxColumn
            // 
            this.wARNINGPERIODDataGridViewTextBoxColumn.DataPropertyName = "WARNING_PERIOD";
            this.wARNINGPERIODDataGridViewTextBoxColumn.HeaderText = "WARNING_PERIOD";
            this.wARNINGPERIODDataGridViewTextBoxColumn.Name = "wARNINGPERIODDataGridViewTextBoxColumn";
            this.wARNINGPERIODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUPPLIERSINNSDataGridViewTextBoxColumn
            // 
            this.sUPPLIERSINNSDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIERS_INNS";
            this.sUPPLIERSINNSDataGridViewTextBoxColumn.HeaderText = "SUPPLIERS_INNS";
            this.sUPPLIERSINNSDataGridViewTextBoxColumn.Name = "sUPPLIERSINNSDataGridViewTextBoxColumn";
            this.sUPPLIERSINNSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEENDDataGridViewTextBoxColumn
            // 
            this.dATEENDDataGridViewTextBoxColumn.DataPropertyName = "DATE_END";
            this.dATEENDDataGridViewTextBoxColumn.HeaderText = "DATE_END";
            this.dATEENDDataGridViewTextBoxColumn.Name = "dATEENDDataGridViewTextBoxColumn";
            this.dATEENDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEBEGINDataGridViewTextBoxColumn
            // 
            this.dATEBEGINDataGridViewTextBoxColumn.DataPropertyName = "DATE_BEGIN";
            this.dATEBEGINDataGridViewTextBoxColumn.HeaderText = "DATE_BEGIN";
            this.dATEBEGINDataGridViewTextBoxColumn.Name = "dATEBEGINDataGridViewTextBoxColumn";
            this.dATEBEGINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEGIDDataGridViewTextBoxColumn
            // 
            this.rEGIDDataGridViewTextBoxColumn.DataPropertyName = "REG_ID";
            this.rEGIDDataGridViewTextBoxColumn.HeaderText = "REG_ID";
            this.rEGIDDataGridViewTextBoxColumn.Name = "rEGIDDataGridViewTextBoxColumn";
            this.rEGIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmDBList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 464);
            this.Controls.Add(this.dgvPosList);
            this.Name = "frmDBList";
            this.Text = "frmDBList";
            this.MaximumSizeChanged += new System.EventHandler(this.frmDBList_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.frmDBList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eGAISESPOSLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosList;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource eGAISESPOSLISTBindingSource;
        private DataSet1TableAdapters.EGAIS_ES_POS_LISTTableAdapter eGAIS_ES_POS_LISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEBEGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERSINNSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wARNINGPERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORBIDDENPERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vERSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vERSIONUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSRARIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESTSENABLEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYNCTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXTERNALINNSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHANGEPRICEENABLEDDataGridViewTextBoxColumn;
        private DataSet1 dataSet1;
    }
}