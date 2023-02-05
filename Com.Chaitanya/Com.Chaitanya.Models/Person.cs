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
        
            get
            {
                //we have to create an DATE object from dob string .
                //we have to current date also.
                //difference of current date and previous date is AGE.

                DateTime birthdate = DateTime.Parse(dob);
                DateTime current_date = DateTime.Now;
                double total_days = (current_date - birthdate).TotalDays;

                double years = total_days / 365;
                age = (int)years;

              
                return this.age;
            }
        }

    

    }
}