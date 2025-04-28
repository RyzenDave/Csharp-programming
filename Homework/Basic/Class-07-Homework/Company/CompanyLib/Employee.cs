namespace CompanyLib
{

    public class Employee

    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        protected double Salary { get; set; }
    
    public Employee(string firstname, string lastname, double salary)
        {
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
        }
        public enum Role
        {
            SalesRep,
            Manager,
            Contractor,
            CEO
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName}-{LastName}-{Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
