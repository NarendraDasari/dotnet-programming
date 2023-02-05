namespace Com.Chaitanya.Models
{
    public class Person
    {
        public string firstname;
       public string lastname;
        
        public  string dob;
        private int age;


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