using ScholCL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SchoolGradeJournal
{
    public partial class UserStudent : Form
    {
        EfContext context;
        Image avatarS = null;
        Students student = new Students();
        public UserStudent(Students stud)
        {
            InitializeComponent();
            context = new EfContext();
            student = stud;
            textBoxNameS.Text = stud.Name;
            textBoxLNS.Text = stud.Surname;
            comboBoxClass.Text = stud.Class.ToString();
            textBoxLS.Text = stud.Login;
            if (stud.Avatar != null)
            {
                MemoryStream ms = new MemoryStream(stud.Avatar);
                pictureBoxStudent.Image = Image.FromStream(ms);
            }
        }

        private void BtnAddPhotoS_Click(object sender, EventArgs e)
        {
            OpenFileDialog tmpImg = new OpenFileDialog();
            tmpImg.Filter = "Pictures | *.img; *.jpg; *.jpeg; *.png; *.bmp";
            if (tmpImg.ShowDialog() == DialogResult.OK)
            {
                string filePath = tmpImg.FileName;
                avatarS = new Bitmap(filePath);
                avatarS = ResizeImg(avatarS as Bitmap);
                pictureBoxStudent.Image = avatarS;
            }
        }

        public Bitmap ResizeImg(Bitmap img)
        {
            int width = 100;
            int height = 130;
            double rW = img.Width / width;
            double rH = img.Height / height; ;
            double resize = rH > rW ? rH : rW;
            width = (int)(img.Width / resize);
            height = (int)(img.Height / resize);
            Image newAvatar = new Bitmap(width, height);
            Graphics tmpGraph = Graphics.FromImage(newAvatar);
            tmpGraph.DrawImage(img, 0, 0, width, height);
            return newAvatar as Bitmap;
        }

        public byte[] ConvertImageToByteArray(Image img)
        {
            using (var pic = new MemoryStream())
            {
                img.Save(pic, System.Drawing.Imaging.ImageFormat.Jpeg);
                return pic.ToArray();
            }
        }

        private void BtnSaveS_Click(object sender, EventArgs e)
        {
            if (textBoxNameS.Text != "" && textBoxLNS.Text != "" && comboBoxClass.Text != "" && textBoxLS.Text != "" && textBoxPassS.Text != "" && int.Parse(comboBoxClass.Text) >= 1 && int.Parse(comboBoxClass.Text) <= 12)
            {
                context.Students.FirstOrDefault(x => x.Id == student.Id).Name = textBoxNameS.Text;
                context.Students.FirstOrDefault(x => x.Id == student.Id).Login = textBoxLNS.Text;
                context.Students.FirstOrDefault(x => x.Id == student.Id).Class = int.Parse(comboBoxClass.Text);
                context.Students.FirstOrDefault(x => x.Id == student.Id).Login = textBoxLS.Text;
                context.Students.FirstOrDefault(x => x.Id == student.Id).Password = CodingGetHash(textBoxPassS.Text);
                context.Students.FirstOrDefault(x => x.Id == student.Id).Avatar = ConvertImageToByteArray(pictureBoxStudent.Image);
                context.SaveChanges();
                this.Hide();
                Student s = new Student(student);
                s.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Незаповненні усі поля або клас вказано невірно!\n Спробуйте будь-ласка ще раз!!!");
        }

        public static string CodingGetHash(string password)
        {
            using (var hash = SHA1.Create())
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2")));
        }

        private void BtnCloseS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelS_Click(object sender, EventArgs e)
        {
            context.Students.Remove(context.Students.FirstOrDefault(x => x.Id == this.student.Id));
            context.SaveChanges();
            this.Close();
        }
    }
}