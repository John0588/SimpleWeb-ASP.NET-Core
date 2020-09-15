using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;


namespace SimpleWeb_ASP.NET_Core.Models
{
    public class Webs
    {
        // Add a priority level to each Webs
        public enum PriorityLevel
        {
            Low,
            Medium,
            High
        }

        public Webs() // Method Webs
        {
        }

        public Webs(int id, 
                    int year, 
                    int month, 
                    int day, 
                    Activity.ActivityType activityType,
                    double duration, 
                    PriorityLevel priority = PriorityLevel.Medium,
                    bool exclude = false, 
                    string notes = null)
        {
            Id = id;
            Date = new DateTime(year, month, day);
            ActivityId = (int)activityType;
            Duration = duration;
            Priority = priority;
            Exclude = exclude;
            Notes = notes;
        }

        // ID of Webs
        public int Id { get; set; }
        // DATE of Webs
        public DateTime Date { get; set; }
        // ACTIVITY ID
        [Display(Name = "Activity")]
        public int ActivityId { get; set; }
        // ACTIVITY for Webs
        public Activity Activity { get; set; }
        // DURATION
        public double Duration { get; set; }
        // PRIORITY LEVEL of the Webs
        public PriorityLevel Priority { get; set; }
        // EXCLUDED from the total calculation (?)
        public bool Exclude { get; set; }
        // NOTES
        public string Notes { get; set; }


    }
}
