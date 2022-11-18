namespace TaskDelegatingApp.Models
{
    public class TaskItem
    {

        public int TaskItemID { get; set; }
        public int TimeOfDay { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }


        public virtual ICollection<Day> Days { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        

        public TaskItem()
        {
            Persons = new HashSet<Person>();
            Days = new HashSet<Day>();


        }
    }
}
