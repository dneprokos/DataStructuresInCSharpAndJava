namespace DataStructuresInCSharp.Implementations._CommonSteps
{
    public class Employee
    {
        public Employee(string fullName, string position, double salary)
        {
            FullName = fullName;
            Position = position;
            Salary = salary;
        }

        public string FullName { get; set; }
        public string Position { get; set; }
        public double? Salary { get; set; }
    }
}
