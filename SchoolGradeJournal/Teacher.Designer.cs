namespace SchoolGradeJournal
{
    partial class Teacher
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
            this.labelTeacher = new System.Windows.Forms.Label();
            this.pictureBoxTeacher = new System.Windows.Forms.PictureBox();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.btnDelRating = new System.Windows.Forms.Button();
            this.btnEditRating = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewRating = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTeacher.Location = new System.Drawing.Point(122, 9);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(103, 20);
            this.labelTeacher.TabIndex = 0;
            this.labelTeacher.Text = "Викладач: ";
            // 
            // pictureBoxTeacher
            // 
            this.pictureBoxTeacher.Location = new System.Drawing.Point(7, 8);
            this.pictureBoxTeacher.Name = "pictureBoxTeacher";
            this.pictureBoxTeacher.Size = new System.Drawing.Size(100, 130);
            this.pictureBoxTeacher.TabIndex = 1;
            this.pictureBoxTeacher.TabStop = false;
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscipline.ForeColor = System.Drawing.Color.Blue;
            this.labelDiscipline.Location = new System.Drawing.Point(122, 35);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(96, 20);
            this.labelDiscipline.TabIndex = 2;
            this.labelDiscipline.Text = "Предмет: ";
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.BackColor = System.Drawing.Color.Yellow;
            this.btnEditTeacher.Location = new System.Drawing.Point(7, 153);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(99, 35);
            this.btnEditTeacher.TabIndex = 3;
            this.btnEditTeacher.Text = "Змінити дані викладача";
            this.btnEditTeacher.UseVisualStyleBackColor = false;
            this.btnEditTeacher.Click += new System.EventHandler(this.BtnEditTeacher_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(12, 207);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(66, 13);
            this.labelClass.TabIndex = 4;
            this.labelClass.Text = "Вибір класу";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(7, 223);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(54, 21);
            this.comboBoxClass.TabIndex = 5;
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(3, 4);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.RowTemplate.Height = 130;
            this.dataGridViewClass.Size = new System.Drawing.Size(749, 325);
            this.dataGridViewClass.TabIndex = 6;
            this.dataGridViewClass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewClass_MouseClick);
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxRating.Location = new System.Drawing.Point(7, 268);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRating.TabIndex = 7;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(20, 249);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(41, 13);
            this.labelRating.TabIndex = 8;
            this.labelRating.Text = "Оцінка";
            // 
            // btnAddRating
            // 
            this.btnAddRating.BackColor = System.Drawing.Color.Yellow;
            this.btnAddRating.Location = new System.Drawing.Point(8, 295);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(99, 23);
            this.btnAddRating.TabIndex = 9;
            this.btnAddRating.Text = "Додати";
            this.btnAddRating.UseVisualStyleBackColor = false;
            this.btnAddRating.Click += new System.EventHandler(this.BtnAddRating_Click);
            // 
            // btnDelRating
            // 
            this.btnDelRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelRating.Location = new System.Drawing.Point(8, 353);
            this.btnDelRating.Name = "btnDelRating";
            this.btnDelRating.Size = new System.Drawing.Size(99, 23);
            this.btnDelRating.TabIndex = 10;
            this.btnDelRating.Text = "Видалити";
            this.btnDelRating.UseVisualStyleBackColor = false;
            this.btnDelRating.Click += new System.EventHandler(this.BtnDelRating_Click);
            // 
            // btnEditRating
            // 
            this.btnEditRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditRating.Location = new System.Drawing.Point(8, 324);
            this.btnEditRating.Name = "btnEditRating";
            this.btnEditRating.Size = new System.Drawing.Size(99, 23);
            this.btnEditRating.TabIndex = 12;
            this.btnEditRating.Text = "Змінити";
            this.btnEditRating.UseVisualStyleBackColor = false;
            this.btnEditRating.Click += new System.EventHandler(this.BtnEditRating_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Location = new System.Drawing.Point(8, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dataGridViewRating
            // 
            this.dataGridViewRating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRating.Location = new System.Drawing.Point(3, 9);
            this.dataGridViewRating.Name = "dataGridViewRating";
            this.dataGridViewRating.Size = new System.Drawing.Size(749, 164);
            this.dataGridViewRating.TabIndex = 14;
            this.dataGridViewRating.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewRating_MouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(113, 59);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewClass);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewRating);
            this.splitContainer1.Size = new System.Drawing.Size(758, 523);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.TabIndex = 15;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Yellow;
            this.btnOk.Location = new System.Drawing.Point(67, 223);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(39, 21);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(877, 587);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEditRating);
            this.Controls.Add(this.btnDelRating);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.btnEditTeacher);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.pictureBoxTeacher);
            this.Controls.Add(this.labelTeacher);
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вчитель";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.PictureBox pictureBoxTeacher;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.Button btnDelRating;
        private System.Windows.Forms.Button btnEditRating;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewRating;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOk;
    }
}

