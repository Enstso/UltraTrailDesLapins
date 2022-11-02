using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utdl.Dao;
using Utdl.Model;

namespace Utdl.View
{
    public partial class FcourseLapins : Form
    {

        public FcourseLapins()
        {
            InitializeComponent();
            btnAdd.Click += this.btnAdd_Click;
            btnEdit.Click += this.btnEdit_Click;
            btnDelete.Click += this.btnDelete_Click;
            btnSave.Click += this.btnSave_Click;
            DaoCourse course = new DaoCourse();
            List<Course> courses = course.GetAll();
            cbCourse.DataSource = courses;
            cbCourse.ValueMember = "id";
            cbCourse.DisplayMember = "id";
            this.load(new DaoLapin().GetAll(cbCourse.SelectedIndex));
        }

        private void btnSave_Click(object sender, System.EventArgs e)   
        {
            
            List<Lapin> lapins = new List<Lapin>();
            foreach (object o in lbLesLapins.Items)
            {
                lapins.Add((Lapin)o);
            }
            new DaoLapin().SaveChanges(lapins);
            this.load(lapins);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (lbLesLapins.SelectedIndex == -1)
                return;
            int position = lbLesLapins.SelectedIndex;
            ((Lapin)lbLesLapins.Items[position]).Remove();
            lbLesLapins.Items[position] = lbLesLapins.Items[position];
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (lbLesLapins.SelectedIndex == -1)
                return;
            int position = lbLesLapins.SelectedIndex;
            FeditLapin fedit = new FeditLapin(State.modified, lbLesLapins.Items, position);
            fedit.Show();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            FeditLapin fedit = new FeditLapin(State.added, lbLesLapins.Items, 0);
            fedit.Show();
        }
        private void load(List<Lapin> lapins)
        {
            lbLesLapins.Items.Clear();
            foreach (Lapin l in lapins)
            {
                lbLesLapins.Items.Add(l);
            }
        }

        private void FcourseLapins_Load(object sender, EventArgs e)
        {
            

        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
