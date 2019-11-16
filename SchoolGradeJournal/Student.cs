using ScholCL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SchoolGradeJournal
{
    public partial class Student : Form
    {
        EfContext context;
        Students student;
        public Student(Students stud)
        {
            InitializeComponent();
            context = new EfContext();
            student = new Students();
            student = stud;
            labelDisp.Text = "";
            labelTeach.Text = "";
            labelRatin.Text = "";
            labelStudent.Text += student.Name + " " + student.Surname;
            labelClass.Text += student.Class.ToString();
            if (stud.Avatar != null)
            {
                MemoryStream ms = new MemoryStream(stud.Avatar);
                picBoxStudent.Image = Image.FromStream(ms);
            }
            listViewDis.Clear();
            ViewListDisciplines();
        }

        private void BtnEditStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserStudent userStudent = new UserStudent(student);
            userStudent.ShowDialog();
            this.Close();
        }

        private void ViewListDisciplines()
        {
            ImageList il;
            EfContext context = new EfContext();
            var listR = context.Ratings.Where(x => x.StudentId == this.student.Id).ToList();
            var listT = context.Teachers.ToList().Distinct();
            var listD = context.Disciplines.ToList().Distinct();
            var listS = context.Students.ToList();
            il = new ImageList();
            il.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\" + "School.png"));
            il.ImageSize = new Size(60, 60);
            il.ColorDepth = ColorDepth.Depth32Bit;
            listViewDis.LargeImageList = il;
            listViewDis.SmallImageList = il;
            listViewDis.Columns.Add("Предмет", 100);
            listViewDis.Columns.Add("Викладач", 100);
            foreach (var itemD in listD)
            {
                ListViewItem items = new ListViewItem(itemD.Disciplin, 0);
                foreach (var itemT in listT)
                {
                    if (itemT.DisciplinesID == itemD.Id)
                        items.SubItems.Add(itemT.Name + " " + itemT.Surname);
                }
                listViewDis.Items.Add(items);
            }
        }

        private void RbList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton view = (RadioButton)sender;
            if (view.Checked == true)
            {
                switch (view.Text)
                {
                    case "Список":
                        listViewDis.View = View.List;
                        break;
                    case "Детально":
                        listViewDis.View = View.Details;
                        break;
                    case "Плитка":
                        listViewDis.View = View.Tile;
                        break;
                    case "Іконка":
                        listViewDis.View = View.SmallIcon;
                        break;
                    case "Значок":
                        listViewDis.View = View.LargeIcon;
                        break;
                }
            }
        }

        public Discipl Progress(string strDis)
        {
            Discipl temp = new Discipl();
            var d = context.Disciplines.FirstOrDefault(x => x.Disciplin == strDis);
            temp.ID = context.Disciplines.FirstOrDefault(x => x.Id == d.Id).Id;
            temp.Teacher = context.Teachers.FirstOrDefault(x => x.DisciplinesID == d.Id).Name + " " + context.Teachers.FirstOrDefault(x => x.DisciplinesID == d.Id).Surname;
            temp.Disciplin = context.Disciplines.FirstOrDefault(x => x.Id == d.Id).Disciplin;
            var ratingList = context.Ratings.Where(x => x.DisciplinId == d.Id && x.StudentId == this.student.Id).Select(x => x.Rating).ToList();
            foreach (var rl in ratingList)
                temp.Rating += rl + ", ";
            return temp;
        }

        private void ListViewDis_MouseClick(object sender, MouseEventArgs e)
        {
            labelDisp.Text = "Успішність по предмету: " + Progress(listViewDis.SelectedItems[0].Text).Disciplin;
            labelTeach.Text = "Викладач предмету: " + Progress(listViewDis.SelectedItems[0].Text).Teacher;
            labelRatin.Text = "Оцінки по предмету: " + Progress(listViewDis.SelectedItems[0].Text).Rating;
        }
    }
}