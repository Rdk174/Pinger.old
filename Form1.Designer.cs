namespace Pinger
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.gridAddresses = new System.Windows.Forms.DataGridView();
            this.columnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIPAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIndicator = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnUTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPKI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPosVers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSyncDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoadServ = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьСведенияОбUTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPing = new System.Windows.Forms.ToolStripMenuItem();
            this.uTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraVNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьСписокПланшетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOOO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.утилитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зарегистрироватьПланшетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьВExcellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timerRLabel = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerBaloon = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.timerReloadServ = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridAddresses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl1.Location = new System.Drawing.Point(258, 19);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(120, 20);
            this.ipAddressControl1.TabIndex = 5;
            this.ipAddressControl1.Text = "0.0.0.0";
            this.ipAddressControl1.Enter += new System.EventHandler(this.ipAddressControl1_Enter);
            this.ipAddressControl1.Leave += new System.EventHandler(this.ipAddressControl1_Leave);
            // 
            // gridAddresses
            // 
            this.gridAddresses.AllowUserToAddRows = false;
            this.gridAddresses.AllowUserToDeleteRows = false;
            this.gridAddresses.AllowUserToResizeColumns = false;
            this.gridAddresses.AllowUserToResizeRows = false;
            this.gridAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIndex,
            this.columnName,
            this.columnOOO,
            this.columnAdress,
            this.columnIPAdres,
            this.columnPort,
            this.columnIndicator,
            this.columnUTM,
            this.columnPKI,
            this.columnGost,
            this.columnPosVers,
            this.columnSyncDate});
            this.gridAddresses.ContextMenuStrip = this.contextMenuStrip1;
            this.gridAddresses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridAddresses.Location = new System.Drawing.Point(12, 56);
            this.gridAddresses.MultiSelect = false;
            this.gridAddresses.Name = "gridAddresses";
            this.gridAddresses.RowHeadersVisible = false;
            this.gridAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAddresses.Size = new System.Drawing.Size(1131, 421);
            this.gridAddresses.TabIndex = 0;
            this.gridAddresses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAddresses_CellClick);
            this.gridAddresses.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridAddresses_CellMouseDown);
            this.gridAddresses.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridAddresses_UserAddedRow);
            this.gridAddresses.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridAddresses_UserDeletedRow);
            // 
            // columnIndex
            // 
            this.columnIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnIndex.FillWeight = 50F;
            this.columnIndex.Frozen = true;
            this.columnIndex.HeaderText = "№ п/п";
            this.columnIndex.Name = "columnIndex";
            this.columnIndex.ReadOnly = true;
            this.columnIndex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnIndex.Width = 50;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnName.Frozen = true;
            this.columnName.HeaderText = "Планшет";
            this.columnName.Name = "columnName";
            this.columnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnName.Width = 70;
            // 
            // columnOOO
            // 
            this.columnOOO.Frozen = true;
            this.columnOOO.HeaderText = "ООО";
            this.columnOOO.Name = "columnOOO";
            this.columnOOO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnOOO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnOOO.Width = 150;
            // 
            // columnAdress
            // 
            this.columnAdress.Frozen = true;
            this.columnAdress.HeaderText = "Адрес";
            this.columnAdress.Name = "columnAdress";
            this.columnAdress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnAdress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnAdress.Width = 210;
            // 
            // columnIPAdres
            // 
            this.columnIPAdres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnIPAdres.Frozen = true;
            this.columnIPAdres.HeaderText = "IP адрес";
            this.columnIPAdres.Name = "columnIPAdres";
            this.columnIPAdres.ReadOnly = true;
            this.columnIPAdres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnIPAdres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnIPAdres.Width = 80;
            // 
            // columnPort
            // 
            this.columnPort.Frozen = true;
            this.columnPort.HeaderText = "Порт";
            this.columnPort.Name = "columnPort";
            this.columnPort.ReadOnly = true;
            this.columnPort.Width = 60;
            // 
            // columnIndicator
            // 
            this.columnIndicator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnIndicator.Frozen = true;
            this.columnIndicator.HeaderText = "Статус";
            this.columnIndicator.Image = global::Pinger.Properties.Resources.red;
            this.columnIndicator.Name = "columnIndicator";
            this.columnIndicator.ReadOnly = true;
            this.columnIndicator.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnIndicator.Width = 50;
            // 
            // columnUTM
            // 
            this.columnUTM.FillWeight = 80F;
            this.columnUTM.Frozen = true;
            this.columnUTM.HeaderText = "Версия UTM";
            this.columnUTM.Name = "columnUTM";
            this.columnUTM.ReadOnly = true;
            this.columnUTM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnUTM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnUTM.Width = 80;
            // 
            // columnPKI
            // 
            this.columnPKI.Frozen = true;
            this.columnPKI.HeaderText = "PKI серт.";
            this.columnPKI.Name = "columnPKI";
            this.columnPKI.ReadOnly = true;
            this.columnPKI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnPKI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnPKI.Width = 80;
            // 
            // columnGost
            // 
            this.columnGost.Frozen = true;
            this.columnGost.HeaderText = "ГОСТ серт.";
            this.columnGost.Name = "columnGost";
            this.columnGost.ReadOnly = true;
            this.columnGost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnGost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnGost.Width = 80;
            // 
            // columnPosVers
            // 
            this.columnPosVers.Frozen = true;
            this.columnPosVers.HeaderText = "Версия ПО";
            this.columnPosVers.Name = "columnPosVers";
            this.columnPosVers.ReadOnly = true;
            this.columnPosVers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnPosVers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnPosVers.Width = 80;
            // 
            // columnSyncDate
            // 
            this.columnSyncDate.Frozen = true;
            this.columnSyncDate.HeaderText = "Дата синхронизации";
            this.columnSyncDate.Name = "columnSyncDate";
            this.columnSyncDate.ReadOnly = true;
            this.columnSyncDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnSyncDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnSyncDate.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.обновитьToolStripMenuItem,
            this.ToolStripMenuItemLoadServ,
            this.получитьСведенияОбUTMToolStripMenuItem,
            this.toolStripMenuItemPing,
            this.uTMToolStripMenuItem,
            this.ultraVNCToolStripMenuItem,
            this.обновитьСписокПланшетовToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(264, 186);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(260, 6);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemLoadServ
            // 
            this.ToolStripMenuItemLoadServ.Name = "ToolStripMenuItemLoadServ";
            this.ToolStripMenuItemLoadServ.Size = new System.Drawing.Size(263, 22);
            this.ToolStripMenuItemLoadServ.Text = "Загрузить данные с сервера MAVT";
            this.ToolStripMenuItemLoadServ.Click += new System.EventHandler(this.загрузитьДанныеССервераMAVTToolStripMenuItem_Click);
            // 
            // получитьСведенияОбUTMToolStripMenuItem
            // 
            this.получитьСведенияОбUTMToolStripMenuItem.Name = "получитьСведенияОбUTMToolStripMenuItem";
            this.получитьСведенияОбUTMToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.получитьСведенияОбUTMToolStripMenuItem.Text = "Получить сведения о всех UTM";
            this.получитьСведенияОбUTMToolStripMenuItem.Click += new System.EventHandler(this.получитьСведенияОбUTMToolStripMenuItem_Click);
            // 
            // toolStripMenuItemPing
            // 
            this.toolStripMenuItemPing.Name = "toolStripMenuItemPing";
            this.toolStripMenuItemPing.Size = new System.Drawing.Size(263, 22);
            this.toolStripMenuItemPing.Text = "Пинг";
            this.toolStripMenuItemPing.Click += new System.EventHandler(this.toolStripMenuItemPing_Click_1);
            // 
            // uTMToolStripMenuItem
            // 
            this.uTMToolStripMenuItem.Name = "uTMToolStripMenuItem";
            this.uTMToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.uTMToolStripMenuItem.Text = "UTM";
            this.uTMToolStripMenuItem.Click += new System.EventHandler(this.uTMToolStripMenuItem_Click);
            // 
            // ultraVNCToolStripMenuItem
            // 
            this.ultraVNCToolStripMenuItem.Enabled = false;
            this.ultraVNCToolStripMenuItem.Name = "ultraVNCToolStripMenuItem";
            this.ultraVNCToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.ultraVNCToolStripMenuItem.Text = "Ultra VNC";
            this.ultraVNCToolStripMenuItem.Visible = false;
            this.ultraVNCToolStripMenuItem.Click += new System.EventHandler(this.ultraVNCToolStripMenuItem_Click);
            // 
            // обновитьСписокПланшетовToolStripMenuItem
            // 
            this.обновитьСписокПланшетовToolStripMenuItem.Name = "обновитьСписокПланшетовToolStripMenuItem";
            this.обновитьСписокПланшетовToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.обновитьСписокПланшетовToolStripMenuItem.Text = "Обновить список планшетов";
            this.обновитьСписокПланшетовToolStripMenuItem.Click += new System.EventHandler(this.обновитьСписокПланшетовToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(57, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(122, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOOO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ipAddressControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(422, 19);
            this.txtPort.Mask = "0000";
            this.txtPort.Name = "txtPort";
            this.txtPort.PromptChar = ' ';
            this.txtPort.Size = new System.Drawing.Size(60, 20);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "8080";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Порт";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtOOO
            // 
            this.txtOOO.Location = new System.Drawing.Point(525, 19);
            this.txtOOO.Name = "txtOOO";
            this.txtOOO.Size = new System.Drawing.Size(524, 20);
            this.txtOOO.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ООО";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1055, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 46);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP адрес";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(64, 45);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(985, 20);
            this.txtAdress.TabIndex = 7;
            this.txtAdress.Enter += new System.EventHandler(this.txtAdress_Enter);
            this.txtAdress.Leave += new System.EventHandler(this.txtAdress_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Адрес";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Планшет";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.утилитыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.открытьToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "Новый";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.новыйСписокToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.openToolStripMenuItem1.Text = "Открыть...";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveToolStripMenuItem.Text = "Сохранить...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsToolStripMenuItem.Image = global::Pinger.Properties.Resources.шестеренка64;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // утилитыToolStripMenuItem
            // 
            this.утилитыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зарегистрироватьПланшетToolStripMenuItem,
            this.выгрузитьВExcellToolStripMenuItem});
            this.утилитыToolStripMenuItem.Name = "утилитыToolStripMenuItem";
            this.утилитыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.утилитыToolStripMenuItem.Text = "Сервис";
            // 
            // зарегистрироватьПланшетToolStripMenuItem
            // 
            this.зарегистрироватьПланшетToolStripMenuItem.Name = "зарегистрироватьПланшетToolStripMenuItem";
            this.зарегистрироватьПланшетToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.зарегистрироватьПланшетToolStripMenuItem.Text = "Зарегистрировать планшет";
            this.зарегистрироватьПланшетToolStripMenuItem.Click += new System.EventHandler(this.зарегистрироватьПланшетToolStripMenuItem_Click);
            // 
            // выгрузитьВExcellToolStripMenuItem
            // 
            this.выгрузитьВExcellToolStripMenuItem.Name = "выгрузитьВExcellToolStripMenuItem";
            this.выгрузитьВExcellToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.выгрузитьВExcellToolStripMenuItem.Text = "Выгрузить в Excell";
            this.выгрузитьВExcellToolStripMenuItem.Click += new System.EventHandler(this.toExcellToolStripMenuItem_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 120000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.Filter = "json|*.json";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.Filter = "json|*.json";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolLabelAddress,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1155, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel.Text = "Готово";
            // 
            // toolLabelAddress
            // 
            this.toolLabelAddress.Name = "toolLabelAddress";
            this.toolLabelAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolLabelAddress.Size = new System.Drawing.Size(63, 17);
            this.toolLabelAddress.Text = "MAVT0000";
            this.toolLabelAddress.Visible = false;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // timerRLabel
            // 
            this.timerRLabel.Interval = 2000;
            this.timerRLabel.Tick += new System.EventHandler(this.timerRLabel_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Пингоштука 2016";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timerBaloon
            // 
            this.timerBaloon.Interval = 12000;
            this.timerBaloon.Tick += new System.EventHandler(this.timerBaloon_Tick);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(600, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.TabStop = false;
            this.button2.Text = "button2";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerReloadServ
            // 
            this.timerReloadServ.Interval = 1800000;
            this.timerReloadServ.Tick += new System.EventHandler(this.timerReloadServ_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAddresses);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пингоштука 2016";
            this.MaximumSizeChanged += new System.EventHandler(this.frmMain_MaximumSizeChanged);
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Deactivate += new System.EventHandler(this.frmMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAddresses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        public System.Windows.Forms.DataGridView gridAddresses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Timer timerRLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.ToolStripMenuItem uTMToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ultraVNCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьСведенияОбUTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPing;
        private System.Windows.Forms.TextBox txtOOO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelAddress;
        private System.Windows.Forms.Timer timerBaloon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIPAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPort;
        private System.Windows.Forms.DataGridViewImageColumn columnIndicator;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPKI;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGost;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPosVers;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSyncDate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoadServ;
        private System.Windows.Forms.ToolStripMenuItem обновитьСписокПланшетовToolStripMenuItem;
        private System.Windows.Forms.Timer timerReloadServ;
        private System.Windows.Forms.ToolStripMenuItem утилитыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зарегистрироватьПланшетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьВExcellToolStripMenuItem;
    }
}

