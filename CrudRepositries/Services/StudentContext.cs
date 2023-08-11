using CrudRepositries.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudRepositries.Services
{
    public class StudentContext:DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {
            
        }
        public DbSet<Student> Student { get; set; }
    }
 

}
