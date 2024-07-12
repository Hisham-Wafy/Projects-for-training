

namespace Day_2_OOP_Assignment
{

    public enum SecurityLevel
    {

        guest, Developer, secretary ,DBA
    }
    internal class Employee
    {
        #region Attributes

        private int id;
        private string? name;
        private decimal? salary;
        private DateOnly hire_date;
        private char? gender;
        private int? security_level;

        #endregion

        #region property
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Salary { get; set; }

        public DateTime Hire_date
        {
            get;


            set;
        }

        public int? Security_level { get; set; }

        public char Gender 
        {

            get => default;
            set
            {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' or 'F'");
                }
            }
        }

        #endregion

        public override string ToString()
        {
            return string.Format( $"ID : {id} \n Name : {name} \n Salary : {salary} \n Gender : {gender} \n Hire Date : {hire_date}  ");
        }

        public Employee(int id , string name , decimal salary , char Gender , DateOnly hire_Date)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.Gender = Gender;
            this.hire_date = hire_Date;
        }

       
    }   
}
