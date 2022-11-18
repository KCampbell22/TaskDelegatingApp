namespace TaskDelegatingApp.Models
{
    public class TaskItem
    {
        private string taskDescription;
        private string taskName;

        public int TaskItemID { get; set; }
        public string TaskName { get => taskName; set => taskName = value; }
        public string TaskDescription { get => taskDescription; set => taskDescription = value; }
        public int TimeOfDay { get; set; }

        public virtual ICollection<Day> Days { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
        

        public TaskItem()
        {
            Persons = new HashSet<Person>();
            Days = new HashSet<Day>();


        }
    }
}
