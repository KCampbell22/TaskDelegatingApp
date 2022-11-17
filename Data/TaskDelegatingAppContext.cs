using Microsoft.EntityFrameworkCore;
using TaskDelegatingApp.Models;


namespace TaskDelegatingApp.Data
{
    public class TaskDelegatingAppContext : DbContext
    {
        public TaskDelegatingAppContext(DbContextOptions<TaskDelegatingAppContext> options)
            : base(options)
        { }

        public DbSet<Person> Person { get; set; }

        public DbSet<TaskDelegatingApp.Models.Day> Day { get; set; }

        public DbSet<TaskDelegatingApp.Models.TaskItem> TaskItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TaskItem>().HasOne(e => e.Day).WithMany(e => e.TaskItems);
            modelBuilder.Entity<Person>().HasMany(e => e.TaskItems).WithOne(e => e.Person);

            
        }
    }
}
