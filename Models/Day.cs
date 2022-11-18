using System.ComponentModel.DataAnnotations.Schema;

namespace TaskDelegatingApp.Models
{
    public class Day
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DayID { get; set; }
        public string? DayName { get; set; }

        public virtual ICollection<TaskItem> TaskItems { get; set; }
        public virtual ICollection<Person> People { get; set; }


        public int WeekID { get; set; }
        public virtual Week? Week { get; set; }



        public Day()
        {
            TaskItems = new List<TaskItem>();
            People = new List<Person>();
        }
    }
}
