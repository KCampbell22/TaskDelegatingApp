using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Runtime.Serialization;
#nullable disable
namespace TaskDelegatingApp.Models
{

    public partial class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        public bool AvailableMonday { get; set; }
        public bool AvailableTuesday { get; set; }
        public bool AvailableWednsday { get; set; }
        public bool AvailableThursday { get; set; }
        public bool AvailableFriday { get; set; }
        public bool AvailableSaturday { get; set; } 
        public bool AvailableSunday { get; set; }

        public virtual TaskItem TaskItem { get; set; }
        public virtual Day Day { get; set; }    


        // Navigation properties
       
        

       
    }
}

