using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ScholCL;

namespace SchoolGradeJournal
{
    public partial class Login : Form
    {
        EfContext context;
        Teachers teachers;
        Students students;
        Disciplines disciplines;
        static int idD;
        public Login()
        {
            InitializeComponent();
            splitContainerTeacher.Panel1Collapsed = false;
            splitContainerTeacher.Panel2Collapsed = true;
            splitContainerStudent.Panel1Collapsed = false;
            splitContainerStudent.Panel2Collapsed = true;
            context = new EfContext();
        }

        private void BtnEnterS_Click(object sender, EventArgs e)
        {
            string log = textBoxUNameS.Text;
            string pass = CodingGetHash(textBoxUPassS.Text);
            students = context.Students.FirstOrDefault(x => x.Login == log && x.Password == pass);
            if (students == null)
            {
                labelErrorS.Text = "Ім'я або пароль невірнi. Спробуйте ще раз.";
                textBoxUNameS.Clear();
                textBoxUPassS.Clear();
            }
            else
            {
                labelErrorS.Text = "";
                textBoxUNameS.Clear();
                textBoxUPassS.Clear();
                Student s = new Student(students);
                s.ShowDialog();
            }
        }

        private void BtnEnterT_Click_1(object sender, EventArgs e)
        {
            string log = textBoxUNameT.Text;
            string pass = CodingGetHash(textBoxUPassT.Text);
            teachers = context.Teachers.FirstOrDefault(x => x.Login == log && x.Password == pass);
            if (teachers == null)
            {
                labelErrorT.Text = "Ім'я або пароль невірнi. Спробуйте ще раз.";
                textBoxUNameT.Clear();
                textBoxUPassT.Clear();
            }
            else
            {
                labelErrorT.Text = "";
                textBoxUNameT.Clear();
                textBoxUPassT.Clear();
                Teacher t = new Teacher(teachers);
                t.ShowDialog();
            }
        }

        private void BtnReestrT_Click(object sender, EventArgs e)
        {
            splitContainerTeacher.Panel1Collapsed = true;
            splitContainerTeacher.Panel2Collapsed = false;
            var list = context.Disciplines.Select(x => x.Disciplin).ToList();
            comboBoxDis.DataSource = list;
        }

        private void BtnReestrS_Click(object sender, EventArgs e)
        {
            splitContainerStudent.Panel1Collapsed = true;
            splitContainerStudent.Panel2Collapsed = false;
        }

        private void BtnRT_Click(object sender, EventArgs e)
        {
            var listD = context.Disciplines.ToList();
            foreach (var item in listD)
            {
                if (comboBoxDis.Text == item.Disciplin.ToString())
                    idD = item.Id;
            }
            Teachers newTeachers = new Teachers();
            disciplines = new Disciplines();
            if (textBoxRTName.Text != "" && textBoxRTLN.Text != "" && textBoxRTL.Text != "" && textBoxRTPass.Text != "")
            {
                if (context.Teachers.Any(x => x.Login == textBoxRTL.Text))
                {
                    labelRTError.Text = "Оберіть інший логін!";
                    textBoxRTL.Clear();
                    textBoxRTPass.Clear();
                }
                else
                {
                    try
                    {
                        newTeachers.Name = textBoxRTName.Text;
                        newTeachers.Surname = textBoxRTLN.Text;
                        newTeachers.DisciplinesID = idD;
                        newTeachers.Login = textBoxRTL.Text;
                        newTeachers.Password = CodingGetHash(textBoxRTPass.Text);
                        context.Teachers.Add(newTeachers);
                        context.SaveChanges();
                        textBoxRTName.Clear();
                        textBoxRTLN.Clear();
                        textBoxRTL.Clear();
                        textBoxRTPass.Clear();
                        splitContainerTeacher.Panel1Collapsed = false;
                        splitContainerTeacher.Panel2Collapsed = true;
                    }
                    catch
                    {
                        MessageBox.Show("Такого предмету не існує!\nДодайте спочатку Ваш предмет!");
                    }
                }
            }
        }

        private void BtnRS_Click(object sender, EventArgs e)
        {
            Students newStudents = new Students();
            if (textBoxRSName.Text != "" && textBoxRSLN.Text != "" && comboBoxClass.Text != "" && textBoxRSL.Text != "" && textBoxRSPass.Text != "" && int.Parse(comboBoxClass.Text) >= 1 && int.Parse(comboBoxClass.Text) <= 12)
            {
                if (context.Students.Any(x => x.Login == textBoxRSL.Text))
                {
                    labelRSError.Text = "Оберіть інший логін!";
                    textBoxRSL.Clear();
                    textBoxRSPass.Clear();
                }
                newStudents.Name = textBoxRSName.Text;
                newStudents.Surname = textBoxRSLN.Text;
                newStudents.Login = textBoxRSL.Text;
                newStudents.Class = int.Parse(comboBoxClass.Text);
                newStudents.Password = CodingGetHash(textBoxRSPass.Text);
                context.Students.Add(newStudents);
                context.SaveChanges();
                textBoxRSName.Clear();
                textBoxRSLN.Clear();
                textBoxRSL.Clear();
                textBoxRSPass.Clear();
                splitContainerStudent.Panel1Collapsed = false;
                splitContainerStudent.Panel2Collapsed = true;
            }
            else
                MessageBox.Show("Незаповненні усі поля або клас вказано невірно!\n Спробуйте будь-ласка ще раз!!!");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public static string CodingGetHash(string password)
        {
            using (var hash = SHA1.Create())
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2")));
        }

        private void BtnResT_Click(object sender, EventArgs e)
        {
            splitContainerTeacher.Panel1Collapsed = false;
            splitContainerTeacher.Panel2Collapsed = true;
        }

        private void BtnResS_Click(object sender, EventArgs e)
        {
            splitContainerStudent.Panel1Collapsed = false;
            splitContainerStudent.Panel2Collapsed = true;
        }

        private void BtnAddDisp_Click(object sender, EventArgs e)
        {
            Disciplines newDisp = new Disciplines();
            if (context.Disciplines.Any(x => x.Disciplin != comboBoxDis.Text) && comboBoxDis.Text!="" || context.Disciplines.Count() == 0)
            {
                newDisp.Disciplin = comboBoxDis.Text;
                context.Disciplines.Add(newDisp);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Такий предмет вже існує!");
            }
        }
    }
}