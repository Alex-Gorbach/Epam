using System;


namespace Proj_1{
	
	protected class Pacient:Department{
		
		private string firstname_;
		private string lastname_;
        List<Diagnosis> diagnosis = new List<Diagnosis>();


        public string FirstName{
            get {return  firstname_;}
            set{firstname_=value; }
        }


        public string Lastname{
            get {return  lastname_;}
            set{ lastname_=value; }
        }

		
		public void Display()
        {
            Console.WriteLine(FirstName +" "+ Lastname )
        }
		
	}

    class Diagnosis{

        private string diagnosis_name;
        List<String> doctors_note =new List<String>();


        public string DiagnosisName{
            get { return diagnosis_name;}
            set { diagnosis_name=value;}
        }

        public LIst<string> DoctorsNote{

                get{ return doctors_note ;}
                set { doctors_note=value;}

        }

 } 

}
