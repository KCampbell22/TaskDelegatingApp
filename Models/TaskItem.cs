using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable
namespace TaskDelegatingApp.Models
{
    public class TaskItem
    {
        //hidden id property
        public enum TimeOfDay
        {
            morning, afternoon, night
        }
        public enum AssignedDay
        {
            Monday, Tuesday, Thursday, Wednesday, Friday, Saturday, Sunday
        }
        public int TaskItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeOfDay? TimeofDay { get; set; }
        public AssignedDay DayAssigned { get; set; }
        public int PersonId { get; set; }
        public int DayId { get; set; }

        public virtual Day Day { get; set; }
        public virtual ICollection<Person> Person { get; set; }




      
       


    }
}

