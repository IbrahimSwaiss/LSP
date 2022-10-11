namespace EmployeeLib.Abstract
{
    public interface IBaseEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public void CalculatePerHourRate(int rank);
    }
}
