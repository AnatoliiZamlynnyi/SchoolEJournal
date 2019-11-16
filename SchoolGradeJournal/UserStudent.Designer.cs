namespace SchoolGradeJournal
{
    partial class UserStudent
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
            this.btnAddPhotoS = new System.Windows.Forms.Button();
            this.btnCloseS = new System.Windows.Forms.Button();
            this.btnSaveS = new System.Windows.Forms.Button();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.textBoxLS = new System.Windows.Forms.TextBox();
            this.labelRTL = new System.Windows.Forms.Label();
            this.textBoxLNS = new System.Windows.Forms.TextBox();
            this.labelRTLN = new System.Windows.Forms.Label();
            this.textBoxPassS = new System.Windows.Forms.TextBox();
            this.labelRTPass = new System.Windows.Forms.Label();
            this.textBoxNameS = new System.Windows.Forms.TextBox();
            this.labelRTName = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.btnDelS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPhotoS
            // 
            this.btnAddPhotoS.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddPhotoS.Location = new System.Drawing.Point(12, 148);
            this.btnAddPhotoS.Name = "btnAddPhotoS";
            this.btnAddPhotoS.Size = new System.Drawing.Size(100, 20);
            this.btnAddPhotoS.TabIndex = 39;
            this.btnAddPhotoS.Text = "Додати фото";
            this.btnAddPhotoS.UseVisualStyleBackColor = false;
            this.btnAddPhotoS.Click += new System.EventHandler(this.BtnAddPhotoS_Click);
            // 
            // btnCloseS
            // 
            this.btnCloseS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCloseS.Location = new System.Drawing.Point(12, 181);
            this.btnCloseS.Name = "btnCloseS";
            this.btnCloseS.Size = new System.Drawing.Size(100, 35);
            this.btnCloseS.TabIndex = 41;
            this.btnCloseS.Text = "Відмінити";
            this.btnCloseS.UseVisualStyleBackColor = false;
            this.btnCloseS.Click += new System.EventHandler(this.BtnCloseS_Click);
            // 
            // btnSaveS
            // 
            this.btnSaveS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveS.Location = new System.Drawing.Point(118, 181);
            this.btnSaveS.Name = "btnSaveS";
            this.btnSaveS.Size = new System.Drawing.Size(100, 35);
            this.btnSaveS.TabIndex = 40;
            this.btnSaveS.Text = "Зберегти користувача";
            this.btnSaveS.UseVisualStyleBackColor = false;
            this.btnSaveS.Click += new System.EventHandler(this.BtnSaveS_Click);
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(100, 130);
            this.pictureBoxStudent.TabIndex = 38;
            this.pictureBoxStudent.TabStop = false;
            // 
            // textBoxLS
            // 
            this.textBoxLS.Location = new System.Drawing.Point(118, 120);
            this.textBoxLS.Name = "textBoxLS";
            this.textBoxLS.Size = new System.Drawing.Size(205, 20);
            this.textBoxLS.TabIndex = 36;
            // 
            // labelRTL
            // 
            this.labelRTL.AutoSize = true;
            this.labelRTL.Location = new System.Drawing.Point(118, 104);
            this.labelRTL.Name = "labelRTL";
            this.labelRTL.Size = new System.Drawing.Size(38, 13);
            this.labelRTL.TabIndex = 35;
            this.labelRTL.Text = "Логин";
            // 
            // textBoxLNS
            // 
            this.textBoxLNS.Location = new System.Drawing.Point(118, 62);
            this.textBoxLNS.Name = "textBoxLNS";
            this.textBoxLNS.Size = new System.Drawing.Size(205, 20);
            this.textBoxLNS.TabIndex = 33;
            // 
            // labelRTLN
            // 
            this.labelRTLN.AutoSize = true;
            this.labelRTLN.Location = new System.Drawing.Point(115, 46);
            this.labelRTLN.Name = "labelRTLN";
            this.labelRTLN.Size = new System.Drawing.Size(81, 13);
            this.labelRTLN.TabIndex = 32;
            this.labelRTLN.Text = "Прізвище учня";
            // 
            // textBoxPassS
            // 
            this.textBoxPassS.Location = new System.Drawing.Point(118, 158);
            this.textBoxPassS.Name = "textBoxPassS";
            this.textBoxPassS.PasswordChar = '*';
            this.textBoxPassS.Size = new System.Drawing.Size(205, 20);
            this.textBoxPassS.TabIndex = 38;
            // 
            // labelRTPass
            // 
            this.labelRTPass.AutoSize = true;
            this.labelRTPass.Location = new System.Drawing.Point(116, 142);
            this.labelRTPass.Name = "labelRTPass";
            this.labelRTPass.Size = new System.Drawing.Size(45, 13);
            this.labelRTPass.TabIndex = 37;
            this.labelRTPass.Text = "Пароль";
            // 
            // textBoxNameS
            // 
            this.textBoxNameS.Location = new System.Drawing.Point(118, 23);
            this.textBoxNameS.Name = "textBoxNameS";
            this.textBoxNameS.Size = new System.Drawing.Size(205, 20);
            this.textBoxNameS.TabIndex = 31;
            // 
            // labelRTName
            // 
            this.labelRTName.AutoSize = true;
            this.labelRTName.Location = new System.Drawing.Point(118, 7);
            this.labelRTName.Name = "labelRTName";
            this.labelRTName.Size = new System.Drawing.Size(51, 13);
            this.labelRTName.TabIndex = 30;
            this.labelRTName.Text = "Ім\'я учня";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(121, 88);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(32, 13);
            this.labelClass.TabIndex = 33;
            this.labelClass.Text = "Клас";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
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
            this.comboBoxClass.Location = new System.Drawing.Point(200, 88);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClass.TabIndex = 34;
            // 
            // btnDelS
            // 
            this.btnDelS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelS.Location = new System.Drawing.Point(222, 182);
            this.btnDelS.Name = "btnDelS";
            this.btnDelS.Size = new System.Drawing.Size(100, 35);
            this.btnDelS.TabIndex = 42;
            this.btnDelS.Text = "Видалити користувача";
            this.btnDelS.UseVisualStyleBackColor = false;
            this.btnDelS.Click += new System.EventHandler(this.BtnDelS_Click);
            // 
            // UserStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(330, 222);
            this.Controls.Add(this.btnDelS);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.btnAddPhotoS);
            this.Controls.Add(this.btnCloseS);
            this.Controls.Add(this.btnSaveS);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.textBoxLS);
            this.Controls.Add(this.labelRTL);
            this.Controls.Add(this.textBoxLNS);
            this.Controls.Add(this.labelRTLN);
            this.Controls.Add(this.textBoxPassS);
            this.Controls.Add(this.labelRTPass);
            this.Controls.Add(this.textBoxNameS);
            this.Controls.Add(this.labelRTName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування учня";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPhotoS;
        private System.Windows.Forms.Button btnCloseS;
        private System.Windows.Forms.Button btnSaveS;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.TextBox textBoxLS;
        private System.Windows.Forms.Label labelRTL;
        private System.Windows.Forms.TextBox textBoxLNS;
        private System.Windows.Forms.Label labelRTLN;
        private System.Windows.Forms.TextBox textBoxPassS;
        private System.Windows.Forms.Label labelRTPass;
        private System.Windows.Forms.TextBox textBoxNameS;
        private System.Windows.Forms.Label labelRTName;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Button btnDelS;
    }
}