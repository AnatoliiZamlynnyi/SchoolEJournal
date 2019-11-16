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
    public partial class Teacher : Form
    {
        EfContext context;
        Teachers teacher;
        Disciplines disciplin;
        Ratings rating;
        static int itemS;
        static int itemR;
        public Teacher(Teachers teach)
        {
            InitializeComponent();
            context = new EfContext();
            teacher = new Teachers();
            disciplin = new Disciplines();
            teacher = teach;
            if (teacher.Avatar != null)
            {
                MemoryStream ms = new MemoryStream(teach.Avatar);
                pictureBoxTeacher.Image = Image.FromStream(ms);
            }
            labelTeacher.Text += teach.Name + " " + teach.Surname;
            var disName = context.Disciplines.ToList();
            foreach (var item in disName)
            {
                if (item.Id == this.teacher.DisciplinesID)
                    labelDiscipline.Text += item.Disciplin;
            }
            comboBoxClass.DataSource = context.Students.Where(x => x.Class > 0 && x.Class < 13).Select(x => x.Class).Distinct().ToList();
            dataGridViewClass.DataSource = context.Students.ToList();
        }

        private void BtnEditTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTeacher userTeacher = new UserTeacher(teacher, disciplin);
            userTeacher.ShowDialog();
            this.Close();
        }

        private void DataGridViewClass_MouseClick(object sender, MouseEventArgs e)
        {
            itemS = (int)dataGridViewClass.CurrentRow.Cells[0].Value;
            dataGridViewRating.DataSource = context.Ratings.Where(x => x.StudentId == itemS && x.DisciplinId == this.teacher.DisciplinesID).ToList();
        }

        private void BtnAddRating_Click(object sender, EventArgs e)
        {
            try
            {
                rating = new Ratings();
                rating.StudentId = (int)dataGridViewClass.CurrentRow.Cells[0].Value;
                var disName = context.Disciplines.ToList();
                foreach (var item in disName)
                {
                    if (item.Id == this.teacher.DisciplinesID)
                        rating.DisciplinId = item.Id;
                }
                rating.Rating = int.Parse(comboBoxRating.SelectedItem.ToString());
                context.Ratings.Add(rating);
                context.SaveChanges();
                dataGridViewRating.DataSource = RatingClass();
            }
            catch
            {
                MessageBox.Show("Оцінка вказана невірно!");
            }
        }

        private void DataGridViewRating_MouseClick(object sender, MouseEventArgs e)
        {
            itemR = (int)dataGridViewRating.CurrentRow.Cells[0].Value;
        }

        private void BtnEditRating_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemR > 0)
                {
                    context.Ratings.FirstOrDefault(x => x.Id == itemR).Rating = int.Parse(comboBoxRating.SelectedItem.ToString());
                    context.SaveChanges();
                }
                dataGridViewRating.DataSource = RatingClass();
            }
            catch
            {
                MessageBox.Show("Оцінка вказана невірно!");
            }

        }

        private void BtnDelRating_Click(object sender, EventArgs e)
        {
            context.Ratings.Remove(context.Ratings.FirstOrDefault(x => x.Id == itemR));
            context.SaveChanges();
            dataGridViewRating.DataSource = RatingClass();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            context.Dispose();
            context = new EfContext();
            context.SaveChanges();
            dataGridViewClass.DataSource = context.Students.ToList();
            dataGridViewRating.DataSource = context.Ratings.Where(x => x.StudentId == itemS && x.DisciplinId == this.teacher.DisciplinesID).ToList();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                List<Students> newSt = new List<Students>();
                foreach (var item in context.Students)
                {
                    if (item.Class == int.Parse(comboBoxClass.SelectedItem.ToString()))
                        newSt.Add(item);
                }
                dataGridViewClass.DataSource = newSt.ToList();
            }
            catch
            {
                MessageBox.Show("Клас вказано невірно!");
            }
        }

        private List<Ratings> RatingClass()
        {
            List<Ratings> newR = new List<Ratings>();
            foreach (var item in context.Ratings.Where(x => x.StudentId == itemS && x.DisciplinId == this.teacher.DisciplinesID).ToList())
            {
                if (item.StudentId == (int)dataGridViewClass.CurrentRow.Cells[0].Value)
                    newR.Add(item);
            }
            return newR.ToList();
        }
    }
}