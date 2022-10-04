public interface IAssignManager<T>
{
    T AssignedManager{get;set;}
    void AssignManager(T manager);
}