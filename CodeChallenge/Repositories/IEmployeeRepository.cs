using CodeChallenge.Models;
using System;
using System.Threading.Tasks;

namespace CodeChallenge.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(String id);
        int GetNumberOfReports(string id);
        Compensation GetCompensationByEmployeeId(string employeeId);
        Employee Add(Employee employee);
        Compensation Add(Compensation employee);
        Employee Remove(Employee employee);
        Task SaveAsync();
    }
}