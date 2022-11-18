namespace TaskDelegatingApp.Models
{
    public class Day
    {
       

        public int DayID { get; set; }
        private string dayName;
        private string dayDescription;
        public string DayName { get => dayName; set => dayName = value; }
        public string DayDescription { get => dayDescription; set => dayDescription = value; }

        public virtual ICollection<TaskItem> TaskItems { get; set; }
        public virtual ICollection<Person> Persons { get; set; }


        public int WeekID { get; set; }
        public virtual Week Week { get; set; }



        public Day()
        {
            TaskItems = new HashSet<TaskItem>();
            Persons = new HashSet<Person>();
            dayName = DayName;
            dayDescription = DayDescription;
        }
    }
}
