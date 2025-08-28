using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskApp.API.Data {
    public class TaskRepository : ITaskRepository {
        private readonly DataContext context;

        public TaskRepository(DataContext context) {
            this.context = context;
        }
        
        public void add<T>(T entity) where T : class {
            this.context.Add(entity);
        }

        public void delete<T>(T entity) where T : class {
            this.context.Remove(entity);
        }

        public async Task<bool> SaveAll() {
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<Employee> GetEmployee(int id) {
            var employee = await this.context.Employees.Include(e => e.Patients).FirstOrDefaultAsync(u => u.Id == id);
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployees() {
            var employees = await this.context.Employees.Include(e => e.Patients).ToListAsync();
            return employees;
        }
    }
}