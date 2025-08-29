using System.Collections.Generic;
using System.Threading.Tasks;
using TaskApp.API.Models;

namespace TaskApp.API.Data
{
    public interface ITaskRepository
    {
        void add<T>(T entity) where T : class;
        void delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> GetEmployees();

        Task<IEnumerable<Patient>> GetPatients();
        Task<Patient> GetPatient(int id);
    }
}