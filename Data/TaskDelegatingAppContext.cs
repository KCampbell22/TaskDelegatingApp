using Microsoft.EntityFrameworkCore;
using TaskDelegatingApp.Models;


namespace TaskDelegatingApp.Data
{
    public class TaskDelegatingAppContext : DbContext
    {
        public TaskDelegatingAppContext(DbContextOptions<TaskDelegatingAppContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }

        public DbSet<TaskDelegatingApp.Models.Day> Day { get; set; }

        public DbSet<TaskDelegatingApp.Models.TaskItem> TaskItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TaskItem>(entity =>
            {
                entity.HasOne(e => e.Day).WithMany(e => e.TaskItems);
                entity.Navigation(e => e.Day).AutoInclude();
                entity.Navigation(e => e.Person).AutoInclude();
              

            });
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasMany(e => e.TaskItems).WithOne(e => e.Person);
                entity.Navigation(e => e.TaskItems).AutoInclude();
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.Navigation(e => e.People).AutoInclude();
                entity.Navigation(e => e.TaskItems).AutoInclude();
            });

            
        }
    }
}
