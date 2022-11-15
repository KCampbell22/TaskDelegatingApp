using TaskDelegatingApp.Models;

namespace TaskDelegatingApp.ViewModels
{
    public class Week
    {
        public IEnumerable<Day> Day { get; set; }
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<TaskItem> Tasks { get; set; }
    }
}
