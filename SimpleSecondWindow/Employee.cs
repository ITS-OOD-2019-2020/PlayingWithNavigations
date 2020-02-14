namespace SimpleSecondWindow
{
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{ID:D4}: {Name} {Salary:C}";
        }
    }
}