using System;

namespace Utdl.Model
{
    public class Lapin
    {
        private static int comptage;
        private static int increment;
        private static Random aleatoire;
        private State state;
        private string surnom;
        private int age;
        private int position;
        private int dossard;
        private int id;
        private int idCourse;

        static Lapin()
        {
            Lapin.comptage = 0;
            Lapin.increment = 1;
        }

        public static int Increment
        {
            get { return increment; }
            set { increment = value; }
        }

        public static int Comptage
        {
            get { return comptage; }
        }

        public static int Start
        {
            set { Lapin.comptage = value; }
        }

        public Lapin(string surnom, int age, State state)
        {
            this.surnom = surnom;
            this.age = age;
            this.position = 0;
            Lapin.aleatoire = new Random();
            this.dossard = Lapin.Comptage;
            Lapin.comptage = Lapin.comptage + Lapin.increment;
            this.state = state;
        }

        public Lapin(string surnom, int age, int idCourse, State state)
        {
            this.surnom = surnom;
            this.age = age;
            this.position = 0;
            Lapin.aleatoire = new Random();
            this.dossard = Lapin.Comptage;
            Lapin.comptage = Lapin.comptage + Lapin.increment;
            this.state = state;
            this.idCourse = idCourse;
        }

        public Lapin(int id, string surnom, int age, int dossard, int position, int idCourse, State state)
        {
            this.id = id;
            this.surnom = surnom;
            this.age = age;
            this.position = 0;
            this.state = state;
            this.idCourse = idCourse;
            Lapin.aleatoire = new Random();
            this.dossard = Lapin.Comptage;
            Lapin.comptage = Lapin.comptage + Lapin.increment;
        }
        public Lapin(int id, string surnom, int age, int dossard, int position, State state)
        {
            this.id = id;
            this.surnom = surnom;
            this.age = age;
            Lapin.aleatoire = new Random();
            this.dossard = Lapin.Comptage;
            Lapin.comptage = Lapin.comptage + Lapin.increment;
            this.position = 0;
            this.state = state;
            this.idCourse = idCourse;
        }

        public Lapin(string surnom, int age, int dossard, int position, int idCourse, State state)
        {

            this.surnom = surnom;
            this.age = age;
            this.position = 0;
            this.state = state;
            this.idCourse = idCourse;
            Lapin.aleatoire = new Random();
            this.dossard = Lapin.Comptage;
            Lapin.comptage = Lapin.comptage + Lapin.increment;
        }

        public string Surnom
        {
            get { return this.surnom; }
            set { this.surnom = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public int IdCourse
        {
            get { return this.idCourse; }
            set { this.idCourse = value; }
        }



        public void Avancer()
        {
            this.position = this.position + Lapin.aleatoire.Next(0, 6);
        }

        public int Dossard
        {
            get { return this.dossard; }
            set { this.dossard = value; }
        }

        public override string ToString()
        {
            return string.Format("Un lapin nommé {0} agé de {1} ans et dont la position est {2} dossard n° {3} de la course {4}", this.surnom, this.age, this.position, this.dossard, this.idCourse);
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public void Remove()
        {
            this.state = State.deleted;
        }

        public State State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
            }
        }


    }
}
