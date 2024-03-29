﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utdl.Dao;

namespace Utdl.View {
    public partial class FultraTrail:Form {
        public FultraTrail() {
            InitializeComponent();
            this.btnLesCourses.Click += this.btnLesCourses_Click;
            this.btnUneCourse.Click += this.btnUneCourse_Click;
            DaoConnectionSingleton.SetStringConnection("root","","localhost","dbUtdl");
        }

        private void btnUneCourse_Click(object sender,EventArgs e) {
            FcourseLapins fCourseLapin = new FcourseLapins();
            fCourseLapin.Show();
        }

        private void btnLesCourses_Click(object sender,EventArgs e) {
            FlesCourses fLesCourses = new FlesCourses();
            fLesCourses.Show();
        }

        private void FultraTrail_Load(object sender, EventArgs e)
        {

        }
    }
}
