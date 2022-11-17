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
       
        public int TaskItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TimeofDay { get; set; }
        public int DayId { get; set; }
        public virtual Day Day { get; set; }

        public virtual Person Person { get; set; }
        




      
       


    }
}

