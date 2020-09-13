using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWeb_ASP.NET_Core.Models
{
    public class Task
    {
        // Add a priority level to each task
        public enum PriorityLevel
        {
            Low,
            Medium,
            High
        }

        public Task() // Method Task
        {
        }

        public Task(int id, 
                    int year, 
                    int month, 
                    int day, 
                    Activity.ActivityType activityType,
                    double duration, 
                    ThreadPriorityLevel priority = PriorityLevel.Medium,
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

        // ID of Task
        public int Id { get; set; }
        // DATE of task
        public DateTime Date { get; set; }
        // ACTIVITY ID
        [Display(Name = "Activity")]
        public int ActivityId { get; set; }
        // ACTIVITY for task
        public Activity Activity { get; set; }
        // DURATION
        public double Duration { get; set; }
        // PRIORITY LEVEL of the task
        public PriorityLevel Priority { get; set; }
        // EXCLUDED from the total calculation (?)
        public bool Exclude { get; set; }
        // NOTES
        public string Notes { get; set; }


    }
}
