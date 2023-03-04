using System;
using System.Collections.Generic;

namespace Utdl.Model {
        public class Course {
        private int distance;
        private List<Lapin> participer;
        private State state;
        private int id;
        public void Départ() {
            for(int j = 0;j<this.distance;j++) {
                for(int i = 0;i<this.participer.Count;i++) {
                    this.participer[i].Avancer();
                }
            }
        }

        public Lapin Gagnant() {
            Lapin gagnant = this.participer[0];
            foreach(Lapin lapin in this.participer) {
                if(lapin.Position>gagnant.Position) {
                    gagnant=lapin;
                }
            }
            return gagnant;
        }

        public Course(int id, int distance ,State state) {
            this.id=id;
            this.distance=distance;
            this.state=state;
            this.participer = new List<Lapin>();
        }

       
        public Course( int distance, State state)
        {
            this.participer = new List<Lapin>();
            this.distance = distance;
            this.state = state;
        }
        public Course(int distance) {
            this.distance=distance;
            this.participer=new List<Lapin>();
        }

        public void Add(Lapin nouveauParticipant) {
            
            this.participer.Add(nouveauParticipant);
        }

        public void Attribuer()
        {
            List<int> dossard = new List<int>();
            Random aleatoire = new Random();

            for (int i = 0; i < this.participer.Count; i++)
            {
                dossard.Add(i);
            }
            int choix = 0;

            foreach (Lapin lapin in this.participer)
            {
                choix = aleatoire.Next(0, dossard.Count);
                lapin.Dossard = dossard[choix];
                dossard.RemoveAt(choix);
            }



        }

        public void RemoveAt(int position) {
            if(position>-1&&position<this.participer.Count) {
                this.participer.RemoveAt(position);
            }
        }

        public List<Lapin> GetParticiper() {
            return this.participer;
        }

        public List<Lapin> Participer {
            get {
                return participer;
            }
        }

        public Lapin this[int position] {
            get {
                return this.participer[position];
            }
        }
        public int Count {
            get {
                return this.participer.Count;
            }
        }

        public State State {
            get {
                return this.state;
            }

            set {
                this.state = value;
            }
        }

        public int Id {
            get {
                return this.id;
            }
        }

        public void Remove() {
            this.state=State.deleted;
        }

        public int Distance {
            get {
                return this.distance;
            }
            set {
                this.distance=value;
            }
        }

        public List<Lapin> Podium()
        {
            List<Lapin> podium = new List<Lapin>();
            Lapin prems = this.participer[0];
            Lapin deums = this.participer[0];
            Lapin trems = this.participer[0];

            foreach (Lapin l in this.Participer)
            {
                if (l.Position > prems.Position)
                {
                    prems = l;
                }


            }

            podium.Add(prems);

            foreach (Lapin l in this.Participer)
            {
                if (l.Position > deums.Position && l.Position < prems.Position)
                {
                    deums = l;
                }


            }
            podium.Add(deums);
            foreach (Lapin l in this.Participer)
            {
                if (l.Position > trems.Position && l.Position < deums.Position)
                {
                    trems = l;
                }


            }
            podium.Add(trems);

            return podium;
        }

        public override string ToString()
        {
            string s;
            s = string.Format("La course n{0} d'une distance {1}",this.id,this.distance);
            return s;
        }

        
    }
}
