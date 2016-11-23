namespace Pinger
{
    partial class frmPing
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
            this.txtPing = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtPing
            // 
            this.txtPing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtPing.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtPing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPing.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPing.Location = new System.Drawing.Point(0, -5);
            this.txtPing.Multiline = true;
            this.txtPing.Name = "txtPing";
            this.txtPing.ReadOnly = true;
            this.txtPing.Size = new System.Drawing.Size(531, 340);
            this.txtPing.TabIndex = 0;
            this.txtPing.TextChanged += new System.EventHandler(this.txtPing_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 335);
            this.Controls.Add(this.txtPing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPing";
            this.Text = "Пинг ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPing_FormClosing);
            this.Load += new System.EventHandler(this.frmPing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPing;
        private System.Windows.Forms.Timer timer1;
    }
}