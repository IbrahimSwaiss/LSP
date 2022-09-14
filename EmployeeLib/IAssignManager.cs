public interface IAssignManager
{
    BaseEmployee AssignedManager{get;set;}
    void AssignManager(BaseEmployee manager);
}