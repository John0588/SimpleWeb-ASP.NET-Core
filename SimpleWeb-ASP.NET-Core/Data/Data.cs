using System;
using System.Collections.Generic;
using System.Linq;
using SimpleWeb_ASP.NET_Core.Models;

namespace SimpleWeb_ASP.NET_Core.Data
{
    // Not "best practrice" for development only
    // SEED Data
    public static class Data
    {
        // Activities Collection
        public static List<Activity> Activities { get; set; }
        // Task Collection
        public static List<Webs> SimpleWeb { get; set; }
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

            var simpleWeb = new List<Webs> ()
            {
                new Webs (1, 2020, 1, 10, Activity.ActivityType.Book, 10.0),
                new Webs (2, 2020, 4, 3, Activity.ActivityType.Film, 120),
                new Webs (3, 2020, 5, 12, Activity.ActivityType.VideoGame, 320),
                new Webs (4, 2020, 6, 2, Activity.ActivityType.Education, 90),
                new Webs (5, 2020, 6, 8, Activity.ActivityType.Walking, 30),
                new Webs (6, 2020, 6, 23, Activity.ActivityType.Work, 400),
                new Webs (7, 2020, 6, 28, Activity.ActivityType.Fitness, 120),
                new Webs (8, 2020, 7, 12, Activity.ActivityType.Book, 40),
                new Webs (9, 2020, 7, 18, Activity.ActivityType.Film, 60),
                new Webs (10, 2020, 7, 29, Activity.ActivityType.TV, 30)
            };

            Activities = activities;
            SimpleWeb = simpleWeb;
        }
    }
}
