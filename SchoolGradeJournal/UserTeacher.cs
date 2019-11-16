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
    public partial class UserTeacher : Form
    {
        EfContext context;
        Image avatarT = null;
        Teachers teacher = new Teachers();
        Disciplines disciplines = new Disciplines();
        public UserTeacher(Teachers teach, Disciplines dis)
        {
            InitializeComponent();
            context = new EfContext();
            teacher = teach;
            textBoxNameT.Text = teach.Name;
            textBoxLNT.Text = teach.Surname;
            var list = context.Disciplines.Select(x => x.Disciplin).ToList();
            comboBoxDis.DataSource = list;
            textBoxLTeacher.Text = teach.Login;
            if (teacher.Avatar != null)
            {
                MemoryStream ms = new MemoryStream(teach.Avatar);
                pictureBoxTeacher.Image = Image.FromStream(ms);
            }
        }

        private void BtnAddPhotoTeacher_Click(object sender, EventArgs e)
        {
            OpenFileDialog tmpImg = new OpenFileDialog();
            tmpImg.Filter = "Pictures | *.img; *.jpg; *.jpeg; *.png; *.bmp";
            if (tmpImg.ShowDialog() == DialogResult.OK)
            {
                string filePath = tmpImg.FileName;
                avatarT = new Bitmap(filePath);
                avatarT = ResizeImg(avatarT as Bitmap);
                pictureBoxTeacher.Image = avatarT;
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

        private static byte[] ConvertImageToByteArray(Image img)
        {
            using (var pic = new MemoryStream())
            {
                img.Save(pic, System.Drawing.Imaging.ImageFormat.Jpeg);
                return pic.ToArray();
            }
        }

        private void BtnSaveTeacher_Click(object sender, EventArgs e)
        {
            if (textBoxNameT.Text != "" && textBoxLNT.Text != "" && comboBoxDis.Text != "" && textBoxLTeacher.Text != "" && textBoxPassT.Text != "")
            {
                context.Teachers.FirstOrDefault(x => x.Id == teacher.Id).Name = textBoxNameT.Text;
                context.Teachers.FirstOrDefault(x => x.Id == teacher.Id).Login = textBoxLNT.Text;
                var disName = context.Disciplines.ToList();
                foreach (var item in disName)
                {
                    if (item.Disciplin == comboBoxDis.SelectedText)
                        context.Disciplines.FirstOrDefault(x => x.Id == teacher.Id).Id = item.Id;
                }
                context.Teachers.FirstOrDefault(x => x.Id == teacher.Id).Login = textBoxLTeacher.Text;
                context.Teachers.FirstOrDefault(x => x.Id == teacher.Id).Password = CodingGetHash(textBoxPassT.Text);
                context.Teachers.FirstOrDefault(x => x.Id == teacher.Id).Avatar = ConvertImageToByteArray(pictureBoxTeacher.Image);
                context.SaveChanges();
                this.Hide();
                Teacher t = new Teacher(teacher);
                t.ShowDialog();
                context.Dispose();
                this.Close();
            }
            else
                MessageBox.Show("Незаповненні усі поля, заповніть будь-ласка");
        }

        public static string CodingGetHash(string password)
        {
            using (var hash = SHA1.Create())
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2")));
        }

        private void BtnCloseTeacher_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddDisp_Click(object sender, EventArgs e)
        {
            if (context.Disciplines.Any(x => x.Disciplin != comboBoxDis.Text) && comboBoxDis.Text != "")
            {
                Disciplines newDisp = new Disciplines();
                newDisp.Disciplin = comboBoxDis.Text;
                context.Disciplines.Add(newDisp);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Такий предмет вже існує!");
            }
        }

        private void BtnDelT_Click(object sender, EventArgs e)
        {
            context.Teachers.Remove(context.Teachers.FirstOrDefault(x => x.Id == this.teacher.Id));
            context.SaveChanges();
            this.Close();

        }
    }
}