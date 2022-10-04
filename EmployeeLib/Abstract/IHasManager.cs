namespace EmployeeLib.Abstract
{
    public interface IHasManager<T> where T : IBaseEmployee
    {
        public T Manager { get; set; }
        public void AssignManager(T manager);
    }
}
