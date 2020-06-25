namespace timetable
{
    partial class AddTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeacherForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnCheckDayButton = new System.Windows.Forms.Button();
            this.CheckDayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkingDaysDataGrid = new System.Windows.Forms.DataGridView();
            this.DaysDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UnCheckLessonButton = new System.Windows.Forms.Button();
            this.CheckLessonButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TeacherLessonsDataGrid = new System.Windows.Forms.DataGridView();
            this.LessonsDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDaysDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherLessonsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LessonsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО преподавателя";
            // 
            // TeacherNameTextBox
            // 
            this.TeacherNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherNameTextBox.Location = new System.Drawing.Point(178, 12);
            this.TeacherNameTextBox.Name = "TeacherNameTextBox";
            this.TeacherNameTextBox.Size = new System.Drawing.Size(751, 26);
            this.TeacherNameTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddButton.Location = new System.Drawing.Point(188, 400);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 38);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CancelButton.Location = new System.Drawing.Point(652, 400);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(98, 38);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnCheckDayButton);
            this.groupBox1.Controls.Add(this.CheckDayButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.WorkingDaysDataGrid);
            this.groupBox1.Controls.Add(this.DaysDataGrid);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 340);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рабочие дни";
            // 
            // UnCheckDayButton
            // 
            this.UnCheckDayButton.FlatAppearance.BorderSize = 0;
            this.UnCheckDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnCheckDayButton.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnCheckDayButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UnCheckDayButton.Image = ((System.Drawing.Image)(resources.GetObject("UnCheckDayButton.Image")));
            this.UnCheckDayButton.Location = new System.Drawing.Point(205, 138);
            this.UnCheckDayButton.Name = "UnCheckDayButton";
            this.UnCheckDayButton.Size = new System.Drawing.Size(33, 33);
            this.UnCheckDayButton.TabIndex = 8;
            this.UnCheckDayButton.UseVisualStyleBackColor = true;
            this.UnCheckDayButton.Click += new System.EventHandler(this.UnCheckDayButton_Click);
            // 
            // CheckDayButton
            // 
            this.CheckDayButton.FlatAppearance.BorderSize = 0;
            this.CheckDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckDayButton.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckDayButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CheckDayButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckDayButton.Image")));
            this.CheckDayButton.Location = new System.Drawing.Point(205, 82);
            this.CheckDayButton.Name = "CheckDayButton";
            this.CheckDayButton.Size = new System.Drawing.Size(33, 33);
            this.CheckDayButton.TabIndex = 7;
            this.CheckDayButton.UseVisualStyleBackColor = true;
            this.CheckDayButton.Click += new System.EventHandler(this.CheckDayButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "рабочие дни преподавателя:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkingDaysDataGrid
            // 
            this.WorkingDaysDataGrid.AllowUserToAddRows = false;
            this.WorkingDaysDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkingDaysDataGrid.ColumnHeadersVisible = false;
            this.WorkingDaysDataGrid.Location = new System.Drawing.Point(253, 50);
            this.WorkingDaysDataGrid.Name = "WorkingDaysDataGrid";
            this.WorkingDaysDataGrid.RowHeadersVisible = false;
            this.WorkingDaysDataGrid.Size = new System.Drawing.Size(189, 276);
            this.WorkingDaysDataGrid.TabIndex = 1;
            // 
            // DaysDataGrid
            // 
            this.DaysDataGrid.AllowUserToAddRows = false;
            this.DaysDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaysDataGrid.ColumnHeadersVisible = false;
            this.DaysDataGrid.Location = new System.Drawing.Point(6, 50);
            this.DaysDataGrid.Name = "DaysDataGrid";
            this.DaysDataGrid.RowHeadersVisible = false;
            this.DaysDataGrid.Size = new System.Drawing.Size(193, 276);
            this.DaysDataGrid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UnCheckLessonButton);
            this.groupBox2.Controls.Add(this.CheckLessonButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TeacherLessonsDataGrid);
            this.groupBox2.Controls.Add(this.LessonsDataGrid);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(481, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 340);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Предметы";
            // 
            // UnCheckLessonButton
            // 
            this.UnCheckLessonButton.FlatAppearance.BorderSize = 0;
            this.UnCheckLessonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnCheckLessonButton.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnCheckLessonButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UnCheckLessonButton.Image = ((System.Drawing.Image)(resources.GetObject("UnCheckLessonButton.Image")));
            this.UnCheckLessonButton.Location = new System.Drawing.Point(203, 138);
            this.UnCheckLessonButton.Name = "UnCheckLessonButton";
            this.UnCheckLessonButton.Size = new System.Drawing.Size(33, 33);
            this.UnCheckLessonButton.TabIndex = 8;
            this.UnCheckLessonButton.UseVisualStyleBackColor = true;
            this.UnCheckLessonButton.Click += new System.EventHandler(this.UnCheckLessonButton_Click);
            // 
            // CheckLessonButton
            // 
            this.CheckLessonButton.FlatAppearance.BorderSize = 0;
            this.CheckLessonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckLessonButton.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckLessonButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CheckLessonButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckLessonButton.Image")));
            this.CheckLessonButton.Location = new System.Drawing.Point(203, 82);
            this.CheckLessonButton.Name = "CheckLessonButton";
            this.CheckLessonButton.Size = new System.Drawing.Size(33, 33);
            this.CheckLessonButton.TabIndex = 7;
            this.CheckLessonButton.UseVisualStyleBackColor = true;
            this.CheckLessonButton.Click += new System.EventHandler(this.CheckLessonButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "перечень дисциплин:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TeacherLessonsDataGrid
            // 
            this.TeacherLessonsDataGrid.AllowUserToAddRows = false;
            this.TeacherLessonsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherLessonsDataGrid.ColumnHeadersVisible = false;
            this.TeacherLessonsDataGrid.Location = new System.Drawing.Point(242, 50);
            this.TeacherLessonsDataGrid.Name = "TeacherLessonsDataGrid";
            this.TeacherLessonsDataGrid.RowHeadersVisible = false;
            this.TeacherLessonsDataGrid.Size = new System.Drawing.Size(191, 276);
            this.TeacherLessonsDataGrid.TabIndex = 1;
            // 
            // LessonsDataGrid
            // 
            this.LessonsDataGrid.AllowUserToAddRows = false;
            this.LessonsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LessonsDataGrid.ColumnHeadersVisible = false;
            this.LessonsDataGrid.Location = new System.Drawing.Point(6, 50);
            this.LessonsDataGrid.Name = "LessonsDataGrid";
            this.LessonsDataGrid.RowHeadersVisible = false;
            this.LessonsDataGrid.Size = new System.Drawing.Size(191, 276);
            this.LessonsDataGrid.TabIndex = 0;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TeacherNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового преподавателя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTeacherForm_FormClosed);
            this.Load += new System.EventHandler(this.AddTeacherForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDaysDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherLessonsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LessonsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeacherNameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UnCheckDayButton;
        private System.Windows.Forms.Button CheckDayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView WorkingDaysDataGrid;
        private System.Windows.Forms.DataGridView DaysDataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UnCheckLessonButton;
        private System.Windows.Forms.Button CheckLessonButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TeacherLessonsDataGrid;
        private System.Windows.Forms.DataGridView LessonsDataGrid;
    }
}