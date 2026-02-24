namespace ReportMaster2
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colFinanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFinanceTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFinanceExport = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFinanceFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTaskTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTaskExport = new Guna.UI2.WinForms.Guna2Button();
            this.cmbTaskFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvEvents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colEventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventRemind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEventTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEventExport = new Guna.UI2.WinForms.Guna2Button();
            this.cmbEventFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(1, 15);
            this.guna2TabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1313, 598);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guna2DataGridView1);
            this.tabPage1.Controls.Add(this.guna2Panel1);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1125, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Финансы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.guna2DataGridView1.ColumnHeadersHeight = 15;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFinanceId,
            this.colFinanceTitle,
            this.colFinanceCategory,
            this.colFinanceDate,
            this.colFinanceAmount});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle33;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(4, 4);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1117, 484);
            this.guna2DataGridView1.TabIndex = 1;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 15;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Удалить);
            this.guna2DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.guna2DataGridView1.ContextMenuStripChanged += new System.EventHandler(this.btnTaskExport_Click);
            this.guna2DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2DataGridView1_KeyDown);
            // 
            // colFinanceId
            // 
            this.colFinanceId.FillWeight = 50F;
            this.colFinanceId.HeaderText = "ID";
            this.colFinanceId.MinimumWidth = 6;
            this.colFinanceId.Name = "colFinanceId";
            this.colFinanceId.ReadOnly = true;
            // 
            // colFinanceTitle
            // 
            this.colFinanceTitle.FillWeight = 200F;
            this.colFinanceTitle.HeaderText = "Название";
            this.colFinanceTitle.MinimumWidth = 6;
            this.colFinanceTitle.Name = "colFinanceTitle";
            this.colFinanceTitle.ReadOnly = true;
            // 
            // colFinanceCategory
            // 
            this.colFinanceCategory.FillWeight = 120F;
            this.colFinanceCategory.HeaderText = "Категория";
            this.colFinanceCategory.MinimumWidth = 6;
            this.colFinanceCategory.Name = "colFinanceCategory";
            this.colFinanceCategory.ReadOnly = true;
            // 
            // colFinanceDate
            // 
            dataGridViewCellStyle31.Format = "d";
            dataGridViewCellStyle31.NullValue = null;
            this.colFinanceDate.DefaultCellStyle = dataGridViewCellStyle31;
            this.colFinanceDate.HeaderText = "Дата";
            this.colFinanceDate.MinimumWidth = 6;
            this.colFinanceDate.Name = "colFinanceDate";
            this.colFinanceDate.ReadOnly = true;
            // 
            // colFinanceAmount
            // 
            dataGridViewCellStyle32.Format = "N2";
            dataGridViewCellStyle32.NullValue = null;
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle32;
            this.colFinanceAmount.FillWeight = 50F;
            this.colFinanceAmount.HeaderText = "Сумма";
            this.colFinanceAmount.MinimumWidth = 6;
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.lblFinanceTotal);
            this.guna2Panel1.Controls.Add(this.btnFinanceExport);
            this.guna2Panel1.Controls.Add(this.cmbFinanceFilter);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(4, 488);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1117, 98);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblFinanceTotal
            // 
            this.lblFinanceTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinanceTotal.Location = new System.Drawing.Point(759, 37);
            this.lblFinanceTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFinanceTotal.Name = "lblFinanceTotal";
            this.lblFinanceTotal.Size = new System.Drawing.Size(75, 22);
            this.lblFinanceTotal.TabIndex = 2;
            this.lblFinanceTotal.Text = "Итог: 0 ₽";
            // 
            // btnFinanceExport
            // 
            this.btnFinanceExport.BorderRadius = 5;
            this.btnFinanceExport.BorderThickness = 1;
            this.btnFinanceExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinanceExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinanceExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinanceExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinanceExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinanceExport.ForeColor = System.Drawing.Color.White;
            this.btnFinanceExport.Location = new System.Drawing.Point(449, 23);
            this.btnFinanceExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinanceExport.Name = "btnFinanceExport";
            this.btnFinanceExport.Size = new System.Drawing.Size(240, 55);
            this.btnFinanceExport.TabIndex = 1;
            this.btnFinanceExport.Text = "Экспорт CSV";
            this.btnFinanceExport.Click += new System.EventHandler(this.btnFinanceExport_Click);
            // 
            // cmbFinanceFilter
            // 
            this.cmbFinanceFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFinanceFilter.BorderColor = System.Drawing.Color.Black;
            this.cmbFinanceFilter.BorderRadius = 5;
            this.cmbFinanceFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFinanceFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinanceFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFinanceFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFinanceFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFinanceFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFinanceFilter.ItemHeight = 30;
            this.cmbFinanceFilter.Location = new System.Drawing.Point(38, 23);
            this.cmbFinanceFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFinanceFilter.Name = "cmbFinanceFilter";
            this.cmbFinanceFilter.Size = new System.Drawing.Size(185, 36);
            this.cmbFinanceFilter.TabIndex = 0;
            this.cmbFinanceFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFinanceFilter_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTasks);
            this.tabPage2.Controls.Add(this.guna2Panel2);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1125, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTasks
            // 
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            this.dgvTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvTasks.ColumnHeadersHeight = 15;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTaskId,
            this.colTaskTitle,
            this.colTaskCategory,
            this.colTaskDate,
            this.colTaskStatus,
            this.colTaskDueDate});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTasks.Location = new System.Drawing.Point(4, 4);
            this.dgvTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.Size = new System.Drawing.Size(1117, 484);
            this.dgvTasks.TabIndex = 2;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTasks.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTasks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTasks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTasks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTasks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvTasks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTasks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTasks.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvTasks.ThemeStyle.ReadOnly = true;
            this.dgvTasks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTasks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTasks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvTasks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTasks.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTasks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTasks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTasks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellDoubleClick);
            this.dgvTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTasks_KeyDown);
            // 
            // colTaskId
            // 
            this.colTaskId.FillWeight = 50F;
            this.colTaskId.HeaderText = "ID";
            this.colTaskId.MinimumWidth = 6;
            this.colTaskId.Name = "colTaskId";
            this.colTaskId.ReadOnly = true;
            // 
            // colTaskTitle
            // 
            this.colTaskTitle.FillWeight = 200F;
            this.colTaskTitle.HeaderText = "Название";
            this.colTaskTitle.MinimumWidth = 6;
            this.colTaskTitle.Name = "colTaskTitle";
            this.colTaskTitle.ReadOnly = true;
            // 
            // colTaskCategory
            // 
            this.colTaskCategory.FillWeight = 120F;
            this.colTaskCategory.HeaderText = "Категория";
            this.colTaskCategory.MinimumWidth = 6;
            this.colTaskCategory.Name = "colTaskCategory";
            this.colTaskCategory.ReadOnly = true;
            // 
            // colTaskDate
            // 
            dataGridViewCellStyle36.Format = "d";
            dataGridViewCellStyle36.NullValue = null;
            this.colTaskDate.DefaultCellStyle = dataGridViewCellStyle36;
            this.colTaskDate.HeaderText = "Дата";
            this.colTaskDate.MinimumWidth = 6;
            this.colTaskDate.Name = "colTaskDate";
            this.colTaskDate.ReadOnly = true;
            // 
            // colTaskStatus
            // 
            this.colTaskStatus.HeaderText = "Статус";
            this.colTaskStatus.MinimumWidth = 6;
            this.colTaskStatus.Name = "colTaskStatus";
            this.colTaskStatus.ReadOnly = true;
            // 
            // colTaskDueDate
            // 
            dataGridViewCellStyle37.Format = "d";
            dataGridViewCellStyle37.NullValue = null;
            this.colTaskDueDate.DefaultCellStyle = dataGridViewCellStyle37;
            this.colTaskDueDate.HeaderText = "Срок сдачи";
            this.colTaskDueDate.MinimumWidth = 6;
            this.colTaskDueDate.Name = "colTaskDueDate";
            this.colTaskDueDate.ReadOnly = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Controls.Add(this.lblTaskTotal);
            this.guna2Panel2.Controls.Add(this.btnTaskExport);
            this.guna2Panel2.Controls.Add(this.cmbTaskFilter);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(4, 488);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1117, 98);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lblTaskTotal
            // 
            this.lblTaskTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskTotal.Location = new System.Drawing.Point(714, 37);
            this.lblTaskTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTaskTotal.Name = "lblTaskTotal";
            this.lblTaskTotal.Size = new System.Drawing.Size(75, 22);
            this.lblTaskTotal.TabIndex = 2;
            this.lblTaskTotal.Text = "Итог: 0 ₽";
            // 
            // btnTaskExport
            // 
            this.btnTaskExport.BorderRadius = 5;
            this.btnTaskExport.BorderThickness = 1;
            this.btnTaskExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaskExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaskExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaskExport.ForeColor = System.Drawing.Color.White;
            this.btnTaskExport.Location = new System.Drawing.Point(449, 23);
            this.btnTaskExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaskExport.Name = "btnTaskExport";
            this.btnTaskExport.Size = new System.Drawing.Size(240, 55);
            this.btnTaskExport.TabIndex = 1;
            this.btnTaskExport.Text = "Экспорт CSV";
            this.btnTaskExport.Click += new System.EventHandler(this.btnTaskExport_Click);
            // 
            // cmbTaskFilter
            // 
            this.cmbTaskFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskFilter.BorderColor = System.Drawing.Color.Black;
            this.cmbTaskFilter.BorderRadius = 5;
            this.cmbTaskFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTaskFilter.ItemHeight = 30;
            this.cmbTaskFilter.Location = new System.Drawing.Point(35, 23);
            this.cmbTaskFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTaskFilter.Name = "cmbTaskFilter";
            this.cmbTaskFilter.Size = new System.Drawing.Size(185, 36);
            this.cmbTaskFilter.TabIndex = 0;
            this.cmbTaskFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTaskFilter_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvEvents);
            this.tabPage3.Controls.Add(this.guna2Panel3);
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1125, 590);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "События";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvEvents
            // 
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            this.dgvEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle39;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvEvents.ColumnHeadersHeight = 15;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEventId,
            this.colEventTitle,
            this.colEventCategory,
            this.colEventDate,
            this.colEventPlace,
            this.colEventRemind});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvents.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEvents.Location = new System.Drawing.Point(0, 0);
            this.dgvEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.Size = new System.Drawing.Size(1125, 492);
            this.dgvEvents.TabIndex = 4;
            this.dgvEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEvents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEvents.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEvents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEvents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEvents.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvEvents.ThemeStyle.ReadOnly = true;
            this.dgvEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEvents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEvents.ThemeStyle.RowsStyle.Height = 22;
            this.dgvEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEvents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellDoubleClick);
            this.dgvEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEvents_KeyDown);
            // 
            // colEventId
            // 
            this.colEventId.FillWeight = 50F;
            this.colEventId.HeaderText = "ID";
            this.colEventId.MinimumWidth = 6;
            this.colEventId.Name = "colEventId";
            this.colEventId.ReadOnly = true;
            // 
            // colEventTitle
            // 
            this.colEventTitle.FillWeight = 200F;
            this.colEventTitle.HeaderText = "Название";
            this.colEventTitle.MinimumWidth = 6;
            this.colEventTitle.Name = "colEventTitle";
            this.colEventTitle.ReadOnly = true;
            // 
            // colEventCategory
            // 
            this.colEventCategory.FillWeight = 120F;
            this.colEventCategory.HeaderText = "Категория";
            this.colEventCategory.MinimumWidth = 6;
            this.colEventCategory.Name = "colEventCategory";
            this.colEventCategory.ReadOnly = true;
            // 
            // colEventDate
            // 
            dataGridViewCellStyle41.Format = "d";
            dataGridViewCellStyle41.NullValue = null;
            this.colEventDate.DefaultCellStyle = dataGridViewCellStyle41;
            this.colEventDate.HeaderText = "Дата";
            this.colEventDate.MinimumWidth = 6;
            this.colEventDate.Name = "colEventDate";
            this.colEventDate.ReadOnly = true;
            // 
            // colEventPlace
            // 
            this.colEventPlace.FillWeight = 150F;
            this.colEventPlace.HeaderText = "Место";
            this.colEventPlace.MinimumWidth = 6;
            this.colEventPlace.Name = "colEventPlace";
            this.colEventPlace.ReadOnly = true;
            // 
            // colEventRemind
            // 
            this.colEventRemind.FillWeight = 80F;
            this.colEventRemind.HeaderText = "Напомнить";
            this.colEventRemind.MinimumWidth = 6;
            this.colEventRemind.Name = "colEventRemind";
            this.colEventRemind.ReadOnly = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Controls.Add(this.lblEventTotal);
            this.guna2Panel3.Controls.Add(this.btnEventExport);
            this.guna2Panel3.Controls.Add(this.cmbEventFilter);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 492);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1125, 98);
            this.guna2Panel3.TabIndex = 3;
            // 
            // lblEventTotal
            // 
            this.lblEventTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblEventTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEventTotal.Location = new System.Drawing.Point(757, 37);
            this.lblEventTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEventTotal.Name = "lblEventTotal";
            this.lblEventTotal.Size = new System.Drawing.Size(75, 22);
            this.lblEventTotal.TabIndex = 2;
            this.lblEventTotal.Text = "Итог: 0 ₽";
            // 
            // btnEventExport
            // 
            this.btnEventExport.BorderRadius = 5;
            this.btnEventExport.BorderThickness = 1;
            this.btnEventExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEventExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEventExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEventExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEventExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEventExport.ForeColor = System.Drawing.Color.White;
            this.btnEventExport.Location = new System.Drawing.Point(449, 23);
            this.btnEventExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEventExport.Name = "btnEventExport";
            this.btnEventExport.Size = new System.Drawing.Size(240, 55);
            this.btnEventExport.TabIndex = 1;
            this.btnEventExport.Text = "Экспорт CSV";
            this.btnEventExport.Click += new System.EventHandler(this.btnEventExport_Click);
            // 
            // cmbEventFilter
            // 
            this.cmbEventFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbEventFilter.BorderColor = System.Drawing.Color.Black;
            this.cmbEventFilter.BorderRadius = 5;
            this.cmbEventFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEventFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEventFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEventFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEventFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEventFilter.ItemHeight = 30;
            this.cmbEventFilter.Location = new System.Drawing.Point(35, 23);
            this.cmbEventFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEventFilter.Name = "cmbEventFilter";
            this.cmbEventFilter.Size = new System.Drawing.Size(185, 36);
            this.cmbEventFilter.TabIndex = 0;
            this.cmbEventFilter.SelectedIndexChanged += new System.EventHandler(this.cmbEventFilter_SelectedIndexChanged);
            this.cmbEventFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEventFilter_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(552, 622);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить запись";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFinanceTotal;
        private Guna.UI2.WinForms.Guna2Button btnFinanceExport;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFinanceFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskDueDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskTotal;
        private Guna.UI2.WinForms.Guna2Button btnTaskExport;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventRemind;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEventTotal;
        private Guna.UI2.WinForms.Guna2Button btnEventExport;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEventFilter;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}

