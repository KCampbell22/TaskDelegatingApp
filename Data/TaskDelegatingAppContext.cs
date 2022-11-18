using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskDelegatingApp.Models;

namespace TaskDelegatingApp.Data
{
    public class TaskDelegatingAppContext : DbContext
    {
        public TaskDelegatingAppContext (DbContextOptions<TaskDelegatingAppContext> options)
            : base(options)
        {
        }

        public DbSet<TaskDelegatingApp.Models.Day> Day { get; set; } = default!;

        public DbSet<TaskDelegatingApp.Models.TaskItem> TaskItem { get; set; } = default!;
    }
}
