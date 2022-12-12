using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utdl.Model;

namespace Utdl.View {
    public partial class FeditLapin:Form {
        State state;
        ListBox.ObjectCollection items;
        int id;
        public FeditLapin(State state, ListBox.ObjectCollection items,int id) {
            InitializeComponent();
            btnValider.Click += this.btnValider_Click;
            this.state = state;
            this.items = items;
            this.id = id;
            
            switch (state)
            {
                case State.added:
                    this.Text = "Création d'un lapin";
                    break;
                case State.modified:
                    this.Text = "Modification d'un lapin";
                    this.tbSurnom.Text = ((Lapin)items[id]).Surnom;
                    this.tbAge.Text = ((Lapin)items[id]).Age.ToString();
                    this.tbDossard.Text = ((Lapin)items[id]).Dossard.ToString();
                    this.tbPosition.Text = ((Lapin)items[id]).Position.ToString();
                    break;
                case State.deleted:
                    this.Text = "Suppression d'un lapin";
                    break;
                case State.unChanged:
                    this.Text = "Consultation d'un lapin";
                    break;
                default:
                    break;
            }
        }

       
        private void btnValider_Click(object sender,EventArgs e) {
            switch (this.state)
            {
                case State.added:
                    items.Add(new Lapin(tbSurnom.Text, Convert.ToInt32(tbAge.Text),id, this.state));
                    this.Close();
                    break;
                case State.modified:
                    Lapin lapin = (Lapin)items[this.id];
                    lapin.State = state;
                    lapin.Surnom = this.tbSurnom.Text;
                    lapin.Age = Convert.ToInt32(this.tbAge.Text);
                    this.Close();
                    break;
                case State.deleted:
                    break;
                case State.unChanged:
                    break;
                default:
                    break;

            }
        }

        private void FeditLapin_Load(object sender, EventArgs e)
        {

        }
    }
}
