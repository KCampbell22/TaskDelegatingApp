namespace TaskDelegatingApp.Models
{
    public class Person
    {
        private string name;
        private string email;

        public int PersonID { get; set; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
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
