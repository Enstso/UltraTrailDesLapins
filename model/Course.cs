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
        }
        public Course(int distance) {
            this.distance=distance;
            this.participer=new List<Lapin>();
        }

        public void Add(Lapin nouveauParticipant) {
            // nouveauParticipant.Dossard = this.Count + 1;
            this.participer.Add(nouveauParticipant);
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
                return this.State;
            }

            set {
                this.State = value;
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
        }
    }
}
