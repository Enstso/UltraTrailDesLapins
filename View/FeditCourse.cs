using System;
using System.Windows.Forms;
using Utdl.Model;

namespace Utdl.View {
    public partial class FeditCourse:Form {
        State state;
        ListBox.ObjectCollection items;
        int position;

        public FeditCourse(State state,ListBox.ObjectCollection items,int position) {
            InitializeComponent();
            btnValider.Click+=this.BtnValider_Click;
            this.state=state;
            this.items=items;
            this.position = position;
            switch(state){
                case State.added:
                    this.Text="Création d'une course";
                    break;
                case State.modified:
                    this.Text="Modification d'une course";
                    break;
                case State.deleted:
                    this.Text="Suppression d'une course";
                    break;
                case State.unChanged:
                    this.Text="Consultation d'une course";
                    break;
                default:
                    break;
            }
        }

        private void BtnValider_Click(object sender,EventArgs e) {
            switch(this.state) {
                case State.added:
                    items.Add(new Course(Convert.ToInt32(this.tbDistance.Text),this.state));
                    break;
                case State.modified:
                    Course course = (Course)items[this.position];
                    course.Distance = Convert.ToInt32(this.tbDistance.Text);
                    items[this.position]=course;
                    break;
                case State.deleted:
                    break;
                case State.unChanged:
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void FeditCourse_Load(object sender, EventArgs e)
        {

        }
    }
}