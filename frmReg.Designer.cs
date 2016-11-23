namespace Pinger
{
    partial class frmReg
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
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listRegid = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtFsrarID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtKpp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAP = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Планшет:";
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(126, 6);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(241, 21);
            this.cmbName.TabIndex = 1;
            this.cmbName.DisplayMemberChanged += new System.EventHandler(this.cmbName_DisplayMemberChanged);
            this.cmbName.TextChanged += new System.EventHandler(this.cmbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер регистрации:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listRegid
            // 
            this.listRegid.FormattingEnabled = true;
            this.listRegid.Location = new System.Drawing.Point(126, 36);
            this.listRegid.Name = "listRegid";
            this.listRegid.Size = new System.Drawing.Size(241, 43);
            this.listRegid.TabIndex = 3;
            this.listRegid.SelectedIndexChanged += new System.EventHandler(this.listRegid_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "АП:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(126, 137);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(241, 20);
            this.txtAP.TabIndex = 5;
            this.txtAP.TextChanged += new System.EventHandler(this.txtAP_TextChanged);
            // 
            // txtFsrarID
            // 
            this.txtFsrarID.Location = new System.Drawing.Point(126, 111);
            this.txtFsrarID.Name = "txtFsrarID";
            this.txtFsrarID.Size = new System.Drawing.Size(166, 20);
            this.txtFsrarID.TabIndex = 7;
            this.txtFsrarID.Leave += new System.EventHandler(this.txtFsrarID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ЕГАИС:";
            // 
            // txtTS
            // 
            this.txtTS.Location = new System.Drawing.Point(126, 166);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(241, 20);
            this.txtTS.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон ТП:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 221);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(660, 182);
            this.textBox1.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(597, 178);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 37);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Текст запроса";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtKpp
            // 
            this.txtKpp.Location = new System.Drawing.Point(126, 85);
            this.txtKpp.Name = "txtKpp";
            this.txtKpp.Size = new System.Drawing.Size(166, 20);
            this.txtKpp.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "КПП:";
            // 
            // btnAP
            // 
            this.btnAP.Location = new System.Drawing.Point(298, 85);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(69, 46);
            this.btnAP.TabIndex = 15;
            this.btnAP.Text = "Получить АП";
            this.btnAP.UseVisualStyleBackColor = true;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(176, 192);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(110, 23);
            this.btnReg.TabIndex = 16;
            this.btnReg.Text = "Зарегистрировать";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 415);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnAP);
            this.Controls.Add(this.txtKpp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFsrarID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listRegid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReg";
            this.Text = "Регистрация нового планшета";
            this.Load += new System.EventHandler(this.frmReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listRegid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.TextBox txtFsrarID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtKpp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAP;
        private System.Windows.Forms.Button btnReg;
    }
}