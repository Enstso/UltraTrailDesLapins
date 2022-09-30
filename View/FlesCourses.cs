using System.Collections.Generic;
using System.Windows.Forms;
using Utdl.Dao;
using Model;

namespace Utdl.View {
    public partial class FlesCourses:Form {
        public FlesCourses() {
            InitializeComponent();
            btnAdd.Click += this.btnAdd_Click;
            btnEdit.Click += this.btnEdit_Click;
            btnDelete.Click += this.btnDelete_Click;
            btnSave.Click += this.btnSave_Click;
        }

        private void btnSave_Click(object sender,System.EventArgs e) {
            List<Course> courses = new List<Course>();
            foreach(object o in lbCourses.Items) {
                courses.Add((Course)o);
            }
            new DaoCourse().SaveChanges(courses);
            this.load(courses);
        }

        private void btnDelete_Click(object sender,System.EventArgs e) {
            if(lbCourses.SelectedIndex==-1) {
                return;
            }
            int position = lbCourses.SelectedIndex;
            ((Course)lbCourses.Items[position]).Remove();
            lbCourses.Items[position]=lbCourses.Items[position];
        }

        private void btnEdit_Click(object sender,System.EventArgs e) {
            if(lbCourses.SelectedIndex ==-1) {
                return;
            }
            int position = lbCourses.SelectedIndex;
            FeditCourse fEdit = new FeditCourse(State.modified,lbCourses.Items,0);
            fEdit.Show();
        }

        private void btnAdd_Click(object sender,System.EventArgs e) {
            FeditCourse fEdit = new FeditCourse(State.added,lbCourses.Items,0);
            fEdit.Show();

        }

        private void load(List<Course> courses) {
            lbCourses.Items.Clear();
            foreach(Course c in courses) {
                lbCourses.Items.Add(c);
            }
        }
    }
}
