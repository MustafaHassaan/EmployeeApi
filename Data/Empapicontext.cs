using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeApi.Data
{
    public class Empapicontext : DbContext
    {
        public Empapicontext(DbContextOptions<Empapicontext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
