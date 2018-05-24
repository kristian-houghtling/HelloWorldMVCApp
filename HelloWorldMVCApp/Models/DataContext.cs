using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace HelloWorldMVCApp.Models
{
    public class HelloWorldContext : DbContext
    {
        public HelloWorldContext(DbContextOptions<HelloWorldContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<GradesModel> Grades { get; set; }

    }
}
