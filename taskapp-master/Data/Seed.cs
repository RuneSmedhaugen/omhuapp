using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using TaskApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskApp.API.Data
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (await context.Employees.AnyAsync()) return;

            using var client = new HttpClient();
            var json = await client.GetStringAsync("https://omhuapp.no/api/data.json");

            // Emplyee list
            var employees = JsonConvert.DeserializeObject<List<Employee>>(json);

            // Patiens list
            var patients = new List<Patient>();
            foreach (var employee in employees)
            {
                if (employee.Patients != null)
                {
                    foreach (var patient in employee.Patients)
                    {
                        patients.Add(patient);
                    }
                }
            }

            context.Employees.AddRange(employees);
            context.Patients.AddRange(patients);
            await context.SaveChangesAsync();
        }
    }
}