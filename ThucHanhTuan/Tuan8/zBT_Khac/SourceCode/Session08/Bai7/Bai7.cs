using System;

class Hospital {
    public abstract class HospitalEmployee {
        private string name;
        private int id;
        private string address;

        public string Name {
            get { return name; }
            set { name=value; }
        }

        public int ID {
            get { return id; }
            set { id=value; }
        }
        public string Addr {
            get { return address; }
            set { address=value; }
        }
        public class Doctor : HospitalEmployee {
            public Doctor() { }
        }


        public class Nurse : HospitalEmployee {
            public Nurse() {

            }
        }
    }
}

