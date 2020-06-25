namespace timetable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.EditTeacherButton = new System.Windows.Forms.Button();
            this.DeleteTeacherButton = new System.Windows.Forms.Button();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridTitleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowTableButton = new System.Windows.Forms.Button();
            this.TableNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TeachersDataGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.WorkingDaysDataGrid = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.LessonsDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimetableButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDaysDataGrid)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LessonsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimetableButton);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GridTitleLabel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 138);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FindTextBox);
            this.groupBox2.Controls.Add(this.EditTeacherButton);
            this.groupBox2.Controls.Add(this.DeleteTeacherButton);
            this.groupBox2.Controls.Add(this.AddTeacherButton);
            this.groupBox2.Controls.Add(this.FindButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(362, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "преподаватели";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(61, 28);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(174, 23);
            this.FindTextBox.TabIndex = 6;
            // 
            // EditTeacherButton
            // 
            this.EditTeacherButton.FlatAppearance.BorderSize = 0;
            this.EditTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("EditTeacherButton.Image")));
            this.EditTeacherButton.Location = new System.Drawing.Point(173, 56);
            this.EditTeacherButton.Name = "EditTeacherButton";
            this.EditTeacherButton.Size = new System.Drawing.Size(44, 37);
            this.EditTeacherButton.TabIndex = 5;
            this.EditTeacherButton.UseVisualStyleBackColor = true;
            this.EditTeacherButton.Click += new System.EventHandler(this.EditTeacherButton_Click);
            // 
            // DeleteTeacherButton
            // 
            this.DeleteTeacherButton.FlatAppearance.BorderSize = 0;
            this.DeleteTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteTeacherButton.Image")));
            this.DeleteTeacherButton.Location = new System.Drawing.Point(123, 57);
            this.DeleteTeacherButton.Name = "DeleteTeacherButton";
            this.DeleteTeacherButton.Size = new System.Drawing.Size(44, 37);
            this.DeleteTeacherButton.TabIndex = 4;
            this.DeleteTeacherButton.UseVisualStyleBackColor = true;
            this.DeleteTeacherButton.Click += new System.EventHandler(this.DeleteTeacherButton_Click);
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.FlatAppearance.BorderSize = 0;
            this.AddTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTeacherButton.Image")));
            this.AddTeacherButton.Location = new System.Drawing.Point(73, 56);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(44, 37);
            this.AddTeacherButton.TabIndex = 3;
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.FlatAppearance.BorderSize = 0;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Location = new System.Drawing.Point(241, 27);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(79, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ФИО : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(345, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "список преподавателей";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridTitleLabel
            // 
            this.GridTitleLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GridTitleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GridTitleLabel.Location = new System.Drawing.Point(22, 115);
            this.GridTitleLabel.Name = "GridTitleLabel";
            this.GridTitleLabel.Size = new System.Drawing.Size(306, 23);
            this.GridTitleLabel.TabIndex = 1;
            this.GridTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.ShowTableButton);
            this.groupBox1.Controls.Add(this.TableNameComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с данными";
            // 
            // EditButton
            // 
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(173, 56);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(44, 37);
            this.EditButton.TabIndex = 5;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(123, 57);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(44, 37);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(73, 56);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(44, 37);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowTableButton
            // 
            this.ShowTableButton.FlatAppearance.BorderSize = 0;
            this.ShowTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowTableButton.Location = new System.Drawing.Point(223, 27);
            this.ShowTableButton.Name = "ShowTableButton";
            this.ShowTableButton.Size = new System.Drawing.Size(79, 23);
            this.ShowTableButton.TabIndex = 2;
            this.ShowTableButton.Text = "показать";
            this.ShowTableButton.UseVisualStyleBackColor = true;
            this.ShowTableButton.Click += new System.EventHandler(this.ShowTableButton_Click);
            // 
            // TableNameComboBox
            // 
            this.TableNameComboBox.FormattingEnabled = true;
            this.TableNameComboBox.Items.AddRange(new object[] {
            "Дни недели",
            "Классы",
            "Уроки"});
            this.TableNameComboBox.Location = new System.Drawing.Point(73, 27);
            this.TableNameComboBox.Name = "TableNameComboBox";
            this.TableNameComboBox.Size = new System.Drawing.Size(144, 24);
            this.TableNameComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "таблица: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 403);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(342, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(655, 403);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(356, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 403);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TeachersDataGrid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20, 10, 10, 10);
            this.panel5.Size = new System.Drawing.Size(356, 403);
            this.panel5.TabIndex = 0;
            // 
            // TeachersDataGrid
            // 
            this.TeachersDataGrid.AllowUserToAddRows = false;
            this.TeachersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachersDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeachersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeachersDataGrid.Location = new System.Drawing.Point(20, 10);
            this.TeachersDataGrid.Name = "TeachersDataGrid";
            this.TeachersDataGrid.RowHeadersVisible = false;
            this.TeachersDataGrid.Size = new System.Drawing.Size(326, 383);
            this.TeachersDataGrid.TabIndex = 4;
            this.TeachersDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersDataGrid_CellEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(25, 10, 10, 10);
            this.panel3.Size = new System.Drawing.Size(342, 403);
            this.panel3.TabIndex = 3;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(25, 10);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.Size = new System.Drawing.Size(307, 383);
            this.DataGrid.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(299, 199);
            this.panel7.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(10, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 31);
            this.panel9.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.WorkingDaysDataGrid);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(10, 41);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(279, 148);
            this.panel8.TabIndex = 2;
            // 
            // WorkingDaysDataGrid
            // 
            this.WorkingDaysDataGrid.AllowUserToAddRows = false;
            this.WorkingDaysDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkingDaysDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkingDaysDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.WorkingDaysDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingDaysDataGrid.Location = new System.Drawing.Point(0, 0);
            this.WorkingDaysDataGrid.Name = "WorkingDaysDataGrid";
            this.WorkingDaysDataGrid.RowHeadersVisible = false;
            this.WorkingDaysDataGrid.Size = new System.Drawing.Size(279, 148);
            this.WorkingDaysDataGrid.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 199);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.panel10.Size = new System.Drawing.Size(299, 204);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(10, 30);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(279, 31);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.LessonsDataGrid);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(10, 61);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(279, 133);
            this.panel12.TabIndex = 2;
            // 
            // LessonsDataGrid
            // 
            this.LessonsDataGrid.AllowUserToAddRows = false;
            this.LessonsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LessonsDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LessonsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.LessonsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LessonsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.LessonsDataGrid.Name = "LessonsDataGrid";
            this.LessonsDataGrid.RowHeadersVisible = false;
            this.LessonsDataGrid.Size = new System.Drawing.Size(279, 133);
            this.LessonsDataGrid.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "рабочие дни";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(2, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "рабочие дисциплины";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimetableButton
            // 
            this.TimetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimetableButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimetableButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TimetableButton.Location = new System.Drawing.Point(848, 39);
            this.TimetableButton.Name = "TimetableButton";
            this.TimetableButton.Size = new System.Drawing.Size(136, 36);
            this.TimetableButton.TabIndex = 4;
            this.TimetableButton.Text = "расписание...";
            this.TimetableButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание уроков";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDaysDataGrid)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LessonsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TableNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ShowTableButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label GridTitleLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditTeacherButton;
        private System.Windows.Forms.Button DeleteTeacherButton;
        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView TeachersDataGrid;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView LessonsDataGrid;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView WorkingDaysDataGrid;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TimetableButton;
    }
}

