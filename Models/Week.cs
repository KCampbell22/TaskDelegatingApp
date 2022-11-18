using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TaskDelegatingApp.Models
{
    public class Week
    {
        
        
        public DateTime WeekStart { get; set; }
        public DateTime WeekEnd { get; set; }
        
        public virtual  ICollection<Day> Days { get; set; }

        public Week()
        {
            Days = new HashSet<Day>();
        }

    }
}
