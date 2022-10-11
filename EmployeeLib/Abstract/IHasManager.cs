using EmployeeLib.Concrete;

namespace EmployeeLib.Abstract
{
    public interface IHasManager 
    {
        public Manager Manager { get; set; }
        public void AssignManager(Manager manager);
    }
}
