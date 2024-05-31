using ex_storage.DateBase;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Storage_MS_SQL
{
    public class SqlServerContextFactory
    {
        private const string DbContextString = 
        public DataContext CreateDbContext(string[] args)
        {
            var optionBielder = new DbContextOptionsBuilder<DataContext>();
            optionBielder.UseSqlServer("", b => b.MigrationsAssembly(typeof(SqlServerContextFactory).Namespace));
        }
    }
}