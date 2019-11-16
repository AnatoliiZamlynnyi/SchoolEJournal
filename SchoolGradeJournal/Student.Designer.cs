namespace SchoolGradeJournal
{
    partial class Student
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
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.labelClass = new System.Windows.Forms.Label();
            this.picBoxStudent = new System.Windows.Forms.PictureBox();
            this.labelStudent = new System.Windows.Forms.Label();
            this.listViewDis = new System.Windows.Forms.ListView();
            this.rbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.rbLargeIcon = new System.Windows.Forms.RadioButton();
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.labelDisp = new System.Windows.Forms.Label();
            this.labelTeach = new System.Windows.Forms.Label();
            this.labelRatin = new System.Windows.Forms.Label();
            this.labelView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditStudent.Location = new System.Drawing.Point(7, 139);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(99, 35);
            this.btnEditStudent.TabIndex = 17;
            this.btnEditStudent.Text = "Змінити дані учня";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.BtnEditStudent_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelClass.Location = new System.Drawing.Point(126, 31);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(60, 20);
            this.labelClass.TabIndex = 16;
            this.labelClass.Text = "Клас: ";
            // 
            // picBoxStudent
            // 
            this.picBoxStudent.Location = new System.Drawing.Point(7, 3);
            this.picBoxStudent.Name = "picBoxStudent";
            this.picBoxStudent.Size = new System.Drawing.Size(100, 130);
            this.picBoxStudent.TabIndex = 15;
            this.picBoxStudent.TabStop = false;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStudent.Location = new System.Drawing.Point(126, 9);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(70, 20);
            this.labelStudent.TabIndex = 14;
            this.labelStudent.Text = "Учень: ";
            // 
            // listViewDis
            // 
            this.listViewDis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDis.HideSelection = false;
            this.listViewDis.Location = new System.Drawing.Point(112, 122);
            this.listViewDis.Name = "listViewDis";
            this.listViewDis.Size = new System.Drawing.Size(498, 192);
            this.listViewDis.TabIndex = 0;
            this.listViewDis.UseCompatibleStateImageBehavior = false;
            this.listViewDis.View = System.Windows.Forms.View.List;
            this.listViewDis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewDis_MouseClick);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Location = new System.Drawing.Point(12, 272);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(58, 17);
            this.rbSmallIcon.TabIndex = 26;
            this.rbSmallIcon.Text = "Іконка";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.RbList_CheckedChanged);
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Location = new System.Drawing.Point(12, 229);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(75, 17);
            this.rbDetails.TabIndex = 25;
            this.rbDetails.Text = "Детально";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.RbList_CheckedChanged);
            // 
            // rbLargeIcon
            // 
            this.rbLargeIcon.AutoSize = true;
            this.rbLargeIcon.Location = new System.Drawing.Point(12, 293);
            this.rbLargeIcon.Name = "rbLargeIcon";
            this.rbLargeIcon.Size = new System.Drawing.Size(61, 17);
            this.rbLargeIcon.TabIndex = 24;
            this.rbLargeIcon.Text = "Значок";
            this.rbLargeIcon.UseVisualStyleBackColor = true;
            this.rbLargeIcon.CheckedChanged += new System.EventHandler(this.RbList_CheckedChanged);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Location = new System.Drawing.Point(12, 252);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(62, 17);
            this.rbTile.TabIndex = 23;
            this.rbTile.Text = "Плитка";
            this.rbTile.UseVisualStyleBackColor = true;
            this.rbTile.CheckedChanged += new System.EventHandler(this.RbList_CheckedChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Checked = true;
            this.rbList.Location = new System.Drawing.Point(12, 206);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(62, 17);
            this.rbList.TabIndex = 22;
            this.rbList.TabStop = true;
            this.rbList.Text = "Список";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.RbList_CheckedChanged);
            // 
            // labelDisp
            // 
            this.labelDisp.AutoSize = true;
            this.labelDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelDisp.Location = new System.Drawing.Point(126, 56);
            this.labelDisp.Name = "labelDisp";
            this.labelDisp.Size = new System.Drawing.Size(75, 16);
            this.labelDisp.TabIndex = 27;
            this.labelDisp.Text = "labelDisp";
            // 
            // labelTeach
            // 
            this.labelTeach.AutoSize = true;
            this.labelTeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTeach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTeach.Location = new System.Drawing.Point(126, 77);
            this.labelTeach.Name = "labelTeach";
            this.labelTeach.Size = new System.Drawing.Size(87, 16);
            this.labelTeach.TabIndex = 28;
            this.labelTeach.Text = "labelTeach";
            // 
            // labelRatin
            // 
            this.labelRatin.AutoSize = true;
            this.labelRatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRatin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRatin.Location = new System.Drawing.Point(126, 99);
            this.labelRatin.Name = "labelRatin";
            this.labelRatin.Size = new System.Drawing.Size(90, 20);
            this.labelRatin.TabIndex = 29;
            this.labelRatin.Text = "labelRatin";
            // 
            // labelView
            // 
            this.labelView.AutoSize = true;
            this.labelView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelView.Location = new System.Drawing.Point(27, 190);
            this.labelView.Name = "labelView";
            this.labelView.Size = new System.Drawing.Size(43, 13);
            this.labelView.TabIndex = 30;
            this.labelView.Text = "Вигляд";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(622, 326);
            this.Controls.Add(this.labelView);
            this.Controls.Add(this.labelRatin);
            this.Controls.Add(this.labelTeach);
            this.Controls.Add(this.labelDisp);
            this.Controls.Add(this.listViewDis);
            this.Controls.Add(this.rbSmallIcon);
            this.Controls.Add(this.rbDetails);
            this.Controls.Add(this.rbLargeIcon);
            this.Controls.Add(this.rbTile);
            this.Controls.Add(this.rbList);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.picBoxStudent);
            this.Controls.Add(this.labelStudent);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учень";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.PictureBox picBoxStudent;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.ListView listViewDis;
        private System.Windows.Forms.RadioButton rbSmallIcon;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.RadioButton rbLargeIcon;
        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.Label labelDisp;
        private System.Windows.Forms.Label labelTeach;
        private System.Windows.Forms.Label labelRatin;
        private System.Windows.Forms.Label labelView;
    }
}