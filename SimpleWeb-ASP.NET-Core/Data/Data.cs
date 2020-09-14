using System;
using System.Collections.Generic;
using System.Linq;
using SimpleWeb_ASP.NET_Core.Models;

namespace SimpleWeb_ASP.NET_Core.Data
{
    // Not "best practrice" for development only
    public static class Data
    {
        // Activities Collection
        public static List<Activity> Activities { get; set; }
        // Task Collection
        public static List<Task> Tasks { get; set; }
        // Inityialize the Data
        static Data()
        {
            InitData();

        }
        private static void InitData()
        {
            // a Collection of Activities that is default

            var activities = new List<Activity>()
            {
                new Activity(Activity.ActivityType.Book),
                new Activity(Activity.ActivityType.Education),
                new Activity(Activity.ActivityType.Film),
                new Activity(Activity.ActivityType.Fitness),
                new Activity(Activity.ActivityType.Meeting),
                new Activity(Activity.ActivityType.Party),
                new Activity(Activity.ActivityType.TV),
                new Activity(Activity.ActivityType.VideoGame, "Video Game"),
                new Activity(Activity.ActivityType.Walking),
                new Activity(Activity.ActivityType.Work),

            };

            var tasks = new List<Task>()
            {
                new Task(1, 2020, 1, 10, Activity.ActivityType.Book, 10.0),
                new Task(2, 2020, 4, 3, Activity.ActivityType.Film, 120),
                new Task(3, 2020, 5, 12, Activity.ActivityType.VideoGame, 320),
                new Task(4, 2020, 6, 2, Activity.ActivityType.Education, 90),
                new Task(5, 2020, 6, 8, Activity.ActivityType.Walking, 30),
                new Task(6, 2020, 6, 23, Activity.ActivityType.Work, 400),
                new Task(7, 2020, 6, 28, Activity.ActivityType.Fitness, 120),
                new Task(8, 2020, 7, 12, Activity.ActivityType.Book, 40),
                new Task(9, 2020, 7, 18, Activity.ActivityType.Film, 60),
                new Task(10, 2020, 7, 29, Activity.ActivityType.TV, 30)
            };

            Activities = activities;
            Tasks = tasks;
        }
    }
}
