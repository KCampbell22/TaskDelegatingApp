namespace TaskDelegatingApp.Models
{
    public class Person
    {
        

        public int PersonID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }

        public virtual ICollection<TaskItem> TaskItems { get; set; }

        public Person()
        {
            TaskItems = new HashSet<TaskItem>();
         
        }
    }
}
