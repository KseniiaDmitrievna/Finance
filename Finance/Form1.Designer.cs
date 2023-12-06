namespace Finance
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonOpenSetting = new System.Windows.Forms.Button();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.buttonAddName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.comboBoxName1 = new System.Windows.Forms.ComboBox();
            this.buttonSortName = new System.Windows.Forms.Button();
            this.buttonSortCategory = new System.Windows.Forms.Button();
            this.btnConclusionDate = new System.Windows.Forms.Button();
            this.comboBoxCategory1 = new System.Windows.Forms.ComboBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStop = new System.Windows.Forms.DateTimePicker();
            this.groupAddOperation = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonSendOperation = new System.Windows.Forms.Button();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupAddOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1737, 73);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // buttonOpenSetting
            // 
            this.buttonOpenSetting.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOpenSetting.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenSetting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenSetting.Name = "buttonOpenSetting";
            this.buttonOpenSetting.Size = new System.Drawing.Size(174, 25);
            this.buttonOpenSetting.TabIndex = 26;
            this.buttonOpenSetting.Text = "Открыть настройки";
            this.buttonOpenSetting.UseVisualStyleBackColor = false;
            this.buttonOpenSetting.Click += new System.EventHandler(this.buttonOpenSetting_Click);
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Controls.Add(this.buttonAddName);
            this.groupBoxSetting.Controls.Add(this.label1);
            this.groupBoxSetting.Controls.Add(this.label2);
            this.groupBoxSetting.Controls.Add(this.textBoxAddCategory);
            this.groupBoxSetting.Controls.Add(this.textBoxAddName);
            this.groupBoxSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSetting.Location = new System.Drawing.Point(0, 73);
            this.groupBoxSetting.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSetting.Size = new System.Drawing.Size(1737, 88);
            this.groupBoxSetting.TabIndex = 32;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Настройка";
            // 
            // buttonAddName
            // 
            this.buttonAddName.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddName.Location = new System.Drawing.Point(1214, 23);
            this.buttonAddName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddName.Name = "buttonAddName";
            this.buttonAddName.Size = new System.Drawing.Size(123, 32);
            this.buttonAddName.TabIndex = 24;
            this.buttonAddName.Text = "Добавить";
            this.buttonAddName.UseVisualStyleBackColor = false;
            this.buttonAddName.Click += new System.EventHandler(this.buttonAddName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(551, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите категорию, которую хотите добавить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите имя, которое хотите добавить";
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.Location = new System.Drawing.Point(921, 27);
            this.textBoxAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(175, 22);
            this.textBoxAddCategory.TabIndex = 1;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddName.Location = new System.Drawing.Point(342, 27);
            this.textBoxAddName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(175, 22);
            this.textBoxAddName.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(13, 167);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(638, 705);
            this.dataGridView.TabIndex = 33;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(13, 852);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(638, 32);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Удалить строку\r\n";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 908);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1596, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1737, 61);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.labelK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonShowAll);
            this.groupBox1.Controls.Add(this.comboBoxName1);
            this.groupBox1.Controls.Add(this.buttonSortName);
            this.groupBox1.Controls.Add(this.buttonSortCategory);
            this.groupBox1.Controls.Add(this.btnConclusionDate);
            this.groupBox1.Controls.Add(this.comboBoxCategory1);
            this.groupBox1.Controls.Add(this.dateTimeStart);
            this.groupBox1.Controls.Add(this.dateTimeStop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(697, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.MinimumSize = new System.Drawing.Size(451, 506);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(451, 506);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // labelK
            // 
            this.labelK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelK.Location = new System.Drawing.Point(3, 425);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(445, 79);
            this.labelK.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "По";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "С";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAll.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonShowAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.Location = new System.Drawing.Point(251, 373);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(181, 50);
            this.buttonShowAll.TabIndex = 19;
            this.buttonShowAll.Text = "Показать всё";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // comboBoxName1
            // 
            this.comboBoxName1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxName1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName1.FormattingEnabled = true;
            this.comboBoxName1.Location = new System.Drawing.Point(228, 39);
            this.comboBoxName1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxName1.Name = "comboBoxName1";
            this.comboBoxName1.Size = new System.Drawing.Size(215, 27);
            this.comboBoxName1.TabIndex = 14;
            this.comboBoxName1.Text = "Выбрать...";
            // 
            // buttonSortName
            // 
            this.buttonSortName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSortName.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSortName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortName.Location = new System.Drawing.Point(235, 93);
            this.buttonSortName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortName.Name = "buttonSortName";
            this.buttonSortName.Size = new System.Drawing.Size(210, 30);
            this.buttonSortName.TabIndex = 15;
            this.buttonSortName.Text = " По имени";
            this.buttonSortName.UseVisualStyleBackColor = false;
            this.buttonSortName.Click += new System.EventHandler(this.buttonSortName_Click);
            // 
            // buttonSortCategory
            // 
            this.buttonSortCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSortCategory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSortCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.buttonSortCategory.Location = new System.Drawing.Point(7, 93);
            this.buttonSortCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortCategory.Name = "buttonSortCategory";
            this.buttonSortCategory.Size = new System.Drawing.Size(223, 32);
            this.buttonSortCategory.TabIndex = 13;
            this.buttonSortCategory.Text = "По категории";
            this.buttonSortCategory.UseVisualStyleBackColor = false;
            this.buttonSortCategory.Click += new System.EventHandler(this.buttonSortCategory_Click);
            // 
            // btnConclusionDate
            // 
            this.btnConclusionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConclusionDate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConclusionDate.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btnConclusionDate.Location = new System.Drawing.Point(56, 297);
            this.btnConclusionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConclusionDate.Name = "btnConclusionDate";
            this.btnConclusionDate.Size = new System.Drawing.Size(278, 35);
            this.btnConclusionDate.TabIndex = 18;
            this.btnConclusionDate.Text = "Вывод по дате";
            this.btnConclusionDate.UseVisualStyleBackColor = false;
            this.btnConclusionDate.Click += new System.EventHandler(this.btnConclusionDate_Click);
            // 
            // comboBoxCategory1
            // 
            this.comboBoxCategory1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory1.FormattingEnabled = true;
            this.comboBoxCategory1.Location = new System.Drawing.Point(7, 39);
            this.comboBoxCategory1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory1.Name = "comboBoxCategory1";
            this.comboBoxCategory1.Size = new System.Drawing.Size(215, 27);
            this.comboBoxCategory1.TabIndex = 12;
            this.comboBoxCategory1.Text = "Выбрать...";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeStart.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.dateTimeStart.Location = new System.Drawing.Point(56, 194);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(278, 27);
            this.dateTimeStart.TabIndex = 16;
            this.dateTimeStart.Value = new System.DateTime(2023, 2, 28, 12, 29, 43, 0);
            // 
            // dateTimeStop
            // 
            this.dateTimeStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeStop.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.dateTimeStop.Location = new System.Drawing.Point(56, 240);
            this.dateTimeStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeStop.Name = "dateTimeStop";
            this.dateTimeStop.Size = new System.Drawing.Size(278, 27);
            this.dateTimeStop.TabIndex = 17;
            // 
            // groupAddOperation
            // 
            this.groupAddOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAddOperation.BackColor = System.Drawing.Color.White;
            this.groupAddOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupAddOperation.Controls.Add(this.dateTime);
            this.groupAddOperation.Controls.Add(this.comboBoxName);
            this.groupAddOperation.Controls.Add(this.comboBoxCategory);
            this.groupAddOperation.Controls.Add(this.buttonSendOperation);
            this.groupAddOperation.Controls.Add(this.labelComment);
            this.groupAddOperation.Controls.Add(this.textBoxComment);
            this.groupAddOperation.Controls.Add(this.labelDate);
            this.groupAddOperation.Controls.Add(this.labelCategory);
            this.groupAddOperation.Controls.Add(this.labelName);
            this.groupAddOperation.Controls.Add(this.textBoxSum);
            this.groupAddOperation.Controls.Add(this.labelSum);
            this.groupAddOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAddOperation.Location = new System.Drawing.Point(1190, 167);
            this.groupAddOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAddOperation.MinimumSize = new System.Drawing.Size(451, 506);
            this.groupAddOperation.Name = "groupAddOperation";
            this.groupAddOperation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupAddOperation.Size = new System.Drawing.Size(469, 506);
            this.groupAddOperation.TabIndex = 37;
            this.groupAddOperation.TabStop = false;
            this.groupAddOperation.Text = "Добавление операции";
            // 
            // dateTime
            // 
            this.dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.dateTime.Location = new System.Drawing.Point(184, 222);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(261, 27);
            this.dateTime.TabIndex = 27;
            this.dateTime.Value = new System.DateTime(2023, 3, 23, 0, 0, 0, 0);
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(184, 44);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(261, 27);
            this.comboBoxName.TabIndex = 12;
            this.comboBoxName.Text = "Выбрать...";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(184, 160);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(261, 27);
            this.comboBoxCategory.TabIndex = 11;
            this.comboBoxCategory.Text = "Выбрать...";
            // 
            // buttonSendOperation
            // 
            this.buttonSendOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendOperation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSendOperation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendOperation.Location = new System.Drawing.Point(195, 407);
            this.buttonSendOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSendOperation.Name = "buttonSendOperation";
            this.buttonSendOperation.Size = new System.Drawing.Size(219, 54);
            this.buttonSendOperation.TabIndex = 10;
            this.buttonSendOperation.Text = "Добавить операцию";
            this.buttonSendOperation.UseVisualStyleBackColor = false;
            this.buttonSendOperation.Click += new System.EventHandler(this.buttonSendOperation_Click);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(20, 302);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(124, 20);
            this.labelComment.TabIndex = 9;
            this.labelComment.Text = "Комментарий";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(184, 297);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(153, 32);
            this.textBoxComment.TabIndex = 8;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(20, 228);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 20);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(20, 164);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(98, 20);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Категория";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя ";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSum.Location = new System.Drawing.Point(184, 100);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(261, 26);
            this.textBoxSum.TabIndex = 1;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(20, 103);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(63, 20);
            this.labelSum.TabIndex = 0;
            this.labelSum.Text = "Сумма";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1737, 969);
            this.panel1.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1737, 969);
            this.Controls.Add(this.groupAddOperation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.buttonOpenSetting);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Мои финансы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAddOperation.ResumeLayout(false);
            this.groupAddOperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonOpenSetting;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.Button buttonAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.ComboBox comboBoxName1;
        private System.Windows.Forms.Button buttonSortName;
        private System.Windows.Forms.Button buttonSortCategory;
        private System.Windows.Forms.Button btnConclusionDate;
        private System.Windows.Forms.ComboBox comboBoxCategory1;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeStop;
        private System.Windows.Forms.GroupBox groupAddOperation;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonSendOperation;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Panel panel1;
    }
}