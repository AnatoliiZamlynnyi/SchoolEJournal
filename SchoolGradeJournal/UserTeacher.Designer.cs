namespace SchoolGradeJournal
{
    partial class UserTeacher
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
            this.textBoxLTeacher = new System.Windows.Forms.TextBox();
            this.labelLTeacher = new System.Windows.Forms.Label();
            this.textBoxLNT = new System.Windows.Forms.TextBox();
            this.labelLNT = new System.Windows.Forms.Label();
            this.textBoxPassT = new System.Windows.Forms.TextBox();
            this.labelPassT = new System.Windows.Forms.Label();
            this.textBoxNameT = new System.Windows.Forms.TextBox();
            this.labelNameT = new System.Windows.Forms.Label();
            this.pictureBoxTeacher = new System.Windows.Forms.PictureBox();
            this.btnSaveTeacher = new System.Windows.Forms.Button();
            this.btnCloseTeacher = new System.Windows.Forms.Button();
            this.btnAddPhotoTeacher = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDisp = new System.Windows.Forms.Button();
            this.comboBoxDis = new System.Windows.Forms.ComboBox();
            this.btnDelT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLTeacher
            // 
            this.textBoxLTeacher.Location = new System.Drawing.Point(119, 123);
            this.textBoxLTeacher.Name = "textBoxLTeacher";
            this.textBoxLTeacher.Size = new System.Drawing.Size(205, 20);
            this.textBoxLTeacher.TabIndex = 26;
            // 
            // labelLTeacher
            // 
            this.labelLTeacher.AutoSize = true;
            this.labelLTeacher.Location = new System.Drawing.Point(192, 108);
            this.labelLTeacher.Name = "labelLTeacher";
            this.labelLTeacher.Size = new System.Drawing.Size(38, 13);
            this.labelLTeacher.TabIndex = 25;
            this.labelLTeacher.Text = "Логин";
            // 
            // textBoxLNT
            // 
            this.textBoxLNT.Location = new System.Drawing.Point(120, 51);
            this.textBoxLNT.Name = "textBoxLNT";
            this.textBoxLNT.Size = new System.Drawing.Size(205, 20);
            this.textBoxLNT.TabIndex = 21;
            // 
            // labelLNT
            // 
            this.labelLNT.AutoSize = true;
            this.labelLNT.Location = new System.Drawing.Point(176, 38);
            this.labelLNT.Name = "labelLNT";
            this.labelLNT.Size = new System.Drawing.Size(99, 13);
            this.labelLNT.TabIndex = 20;
            this.labelLNT.Text = "Прізвище вчителя";
            // 
            // textBoxPassT
            // 
            this.textBoxPassT.Location = new System.Drawing.Point(119, 159);
            this.textBoxPassT.Name = "textBoxPassT";
            this.textBoxPassT.PasswordChar = '*';
            this.textBoxPassT.Size = new System.Drawing.Size(205, 20);
            this.textBoxPassT.TabIndex = 28;
            // 
            // labelPassT
            // 
            this.labelPassT.AutoSize = true;
            this.labelPassT.Location = new System.Drawing.Point(192, 144);
            this.labelPassT.Name = "labelPassT";
            this.labelPassT.Size = new System.Drawing.Size(45, 13);
            this.labelPassT.TabIndex = 27;
            this.labelPassT.Text = "Пароль";
            // 
            // textBoxNameT
            // 
            this.textBoxNameT.Location = new System.Drawing.Point(120, 16);
            this.textBoxNameT.Name = "textBoxNameT";
            this.textBoxNameT.Size = new System.Drawing.Size(205, 20);
            this.textBoxNameT.TabIndex = 19;
            // 
            // labelNameT
            // 
            this.labelNameT.AutoSize = true;
            this.labelNameT.Location = new System.Drawing.Point(189, 2);
            this.labelNameT.Name = "labelNameT";
            this.labelNameT.Size = new System.Drawing.Size(69, 13);
            this.labelNameT.TabIndex = 18;
            this.labelNameT.Text = "Ім\'я вчителя";
            // 
            // pictureBoxTeacher
            // 
            this.pictureBoxTeacher.Location = new System.Drawing.Point(8, 9);
            this.pictureBoxTeacher.Name = "pictureBoxTeacher";
            this.pictureBoxTeacher.Size = new System.Drawing.Size(100, 130);
            this.pictureBoxTeacher.TabIndex = 26;
            this.pictureBoxTeacher.TabStop = false;
            // 
            // btnSaveTeacher
            // 
            this.btnSaveTeacher.BackColor = System.Drawing.Color.Red;
            this.btnSaveTeacher.Location = new System.Drawing.Point(119, 185);
            this.btnSaveTeacher.Name = "btnSaveTeacher";
            this.btnSaveTeacher.Size = new System.Drawing.Size(100, 35);
            this.btnSaveTeacher.TabIndex = 30;
            this.btnSaveTeacher.Text = "Зберегти користувача";
            this.btnSaveTeacher.UseVisualStyleBackColor = false;
            this.btnSaveTeacher.Click += new System.EventHandler(this.BtnSaveTeacher_Click);
            // 
            // btnCloseTeacher
            // 
            this.btnCloseTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCloseTeacher.Location = new System.Drawing.Point(13, 185);
            this.btnCloseTeacher.Name = "btnCloseTeacher";
            this.btnCloseTeacher.Size = new System.Drawing.Size(100, 35);
            this.btnCloseTeacher.TabIndex = 31;
            this.btnCloseTeacher.Text = "Відмінити";
            this.btnCloseTeacher.UseVisualStyleBackColor = false;
            this.btnCloseTeacher.Click += new System.EventHandler(this.BtnCloseTeacher_Click);
            // 
            // btnAddPhotoTeacher
            // 
            this.btnAddPhotoTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddPhotoTeacher.Location = new System.Drawing.Point(8, 148);
            this.btnAddPhotoTeacher.Name = "btnAddPhotoTeacher";
            this.btnAddPhotoTeacher.Size = new System.Drawing.Size(100, 20);
            this.btnAddPhotoTeacher.TabIndex = 29;
            this.btnAddPhotoTeacher.Text = "Додати фото";
            this.btnAddPhotoTeacher.UseVisualStyleBackColor = false;
            this.btnAddPhotoTeacher.Click += new System.EventHandler(this.BtnAddPhotoTeacher_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Предмет викладання";
            // 
            // btnAddDisp
            // 
            this.btnAddDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddDisp.Location = new System.Drawing.Point(262, 74);
            this.btnAddDisp.Name = "btnAddDisp";
            this.btnAddDisp.Size = new System.Drawing.Size(61, 34);
            this.btnAddDisp.TabIndex = 24;
            this.btnAddDisp.Text = "Додати предмет";
            this.btnAddDisp.UseVisualStyleBackColor = false;
            this.btnAddDisp.Click += new System.EventHandler(this.BtnAddDisp_Click);
            // 
            // comboBoxDis
            // 
            this.comboBoxDis.FormattingEnabled = true;
            this.comboBoxDis.Location = new System.Drawing.Point(120, 87);
            this.comboBoxDis.Name = "comboBoxDis";
            this.comboBoxDis.Size = new System.Drawing.Size(138, 21);
            this.comboBoxDis.TabIndex = 23;
            // 
            // btnDelT
            // 
            this.btnDelT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelT.Location = new System.Drawing.Point(223, 185);
            this.btnDelT.Name = "btnDelT";
            this.btnDelT.Size = new System.Drawing.Size(100, 35);
            this.btnDelT.TabIndex = 43;
            this.btnDelT.Text = "Видалити користувача";
            this.btnDelT.UseVisualStyleBackColor = false;
            this.btnDelT.Click += new System.EventHandler(this.BtnDelT_Click);
            // 
            // UserTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(331, 227);
            this.Controls.Add(this.btnDelT);
            this.Controls.Add(this.btnAddDisp);
            this.Controls.Add(this.comboBoxDis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPhotoTeacher);
            this.Controls.Add(this.btnCloseTeacher);
            this.Controls.Add(this.btnSaveTeacher);
            this.Controls.Add(this.pictureBoxTeacher);
            this.Controls.Add(this.textBoxLTeacher);
            this.Controls.Add(this.labelLTeacher);
            this.Controls.Add(this.textBoxLNT);
            this.Controls.Add(this.labelLNT);
            this.Controls.Add(this.textBoxPassT);
            this.Controls.Add(this.labelPassT);
            this.Controls.Add(this.textBoxNameT);
            this.Controls.Add(this.labelNameT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування вчителя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLTeacher;
        private System.Windows.Forms.Label labelLTeacher;
        private System.Windows.Forms.TextBox textBoxLNT;
        private System.Windows.Forms.Label labelLNT;
        private System.Windows.Forms.TextBox textBoxPassT;
        private System.Windows.Forms.Label labelPassT;
        private System.Windows.Forms.TextBox textBoxNameT;
        private System.Windows.Forms.Label labelNameT;
        private System.Windows.Forms.PictureBox pictureBoxTeacher;
        private System.Windows.Forms.Button btnSaveTeacher;
        private System.Windows.Forms.Button btnCloseTeacher;
        private System.Windows.Forms.Button btnAddPhotoTeacher;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDisp;
        private System.Windows.Forms.ComboBox comboBoxDis;
        private System.Windows.Forms.Button btnDelT;
    }
}