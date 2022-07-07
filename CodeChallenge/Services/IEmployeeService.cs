using CodeChallenge.Models;
using System;

namespace CodeChallenge.Services
{
    public interface IEmployeeService
    {
        Employee GetById(String id);
        ReportingStructure GetReportingStructure(String id);
        Compensation GetCompensationByEmployeeId(String employeeId);
        Employee Create(Employee employee);
        Compensation Create(Compensation employee);
        Employee Replace(Employee originalEmployee, Employee newEmployee);
    }
}
