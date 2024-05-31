 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OOP_lab_3_API.Models;

namespace ex_storage.DateBase
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Employer> Employer {get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Vacancy> Vacancy { get; set; }


    }
}
 