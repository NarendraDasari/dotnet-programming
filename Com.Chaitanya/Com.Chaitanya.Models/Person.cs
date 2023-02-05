namespace Com.Chaitanya.Models
{
    public class Person
    {
       
        private string firstname;
       private string lastname;
        
        private  string dob;
        private int age;


        public string FirstName
        {
            set {
                this.firstname = value;

            }
            get {
                return this.firstname;
            }
        }


        public string LastName
        {
            set
            {
                this.lastname = value;
            }
            get
            {
                return this.lastname;
            }

        }
        public string DateOfBirth
        {
            set
            {
                this.dob = value;
            }
            get
            {
                return this.dob;

            }
        }
        public int Age
        {
            set
            {
                this.age = value;

            }
            get
            {
                return this.age;
            }
        }


        public void setFirstname(string fname)
        {
            this.firstname = fname;
        }
        public string getFirstname()
        {
            return this.firstname;

        }

        public void setLastname(string lname)
        {
            this.lastname = lname;

        }

        public string getLastname()
        {
            return this.lastname;

        }
        // This is a setter
        public void setDob(string dob1)
        {


            this.dob = dob1;
        }


        // This is a getter.
        public string getDob()
        {
            return this.dob;
        }




        public int GetAge()
        {
            //we have to create an DATE object from dob string .
            //we have to current date also.
            //difference of current date and previous date is AGE.


            DateTime birthdate = DateTime.Parse(dob);
            DateTime current_date=DateTime.Now;
            double total_days= (current_date - birthdate).TotalDays;

           double years= total_days / 365;
            age = (int)years;

            return age;
            

        }
    }
}