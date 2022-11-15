using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskDelegatingApp.Models
{
    

    public partial class Day
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DayId { get; set; }  
        public string? DayName { get; set; }
       

        public virtual ICollection<TaskItem>? TaskItems { get; set; }
        public virtual ICollection<Person>? Persons { get; set; }
     

       

        

    }


    
}
