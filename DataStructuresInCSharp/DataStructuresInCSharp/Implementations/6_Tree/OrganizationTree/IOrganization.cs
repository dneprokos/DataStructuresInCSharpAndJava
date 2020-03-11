using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._6_Tree.OrganizationTree
{
    public interface IOrganization
    {
        Employee AddEmployee(string fullName, JobTitle position, Employee chief);
        Employee RemoveEmployee(Employee employee);
        List<Employee> FindEmployee(string fullName);
        void PrintChiefsHierarchy(Employee employee);
    }
}
