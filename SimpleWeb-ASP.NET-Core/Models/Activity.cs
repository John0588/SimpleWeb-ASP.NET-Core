using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWeb_ASP.NET_Core.Models
{
    public class Activity
    {
        // List of Activity Types
        public enum ActivityType // enum data type - stands for enumarations type. Allows to create sets of unchanging list. 
        {
            Fitness = 1,
            Book = 2,
            Film = 3,
            TV = 4,
            VideoGame = 5,
            Meeting = 6,
            Work = 7,
            Education = 8,
            Walking = 9,
            Party = 10,

        }

        // Activity Type and Name
        public Activity(ActivityType activityType, string name = null)
        {
            Id = (int)activityType;

            // Use string if name argument unavailable
            Name = name ?? activityType.ToString(); // ??/??=  - dealing with null values (ex. if the null values is string null values, its Convert To.String vcalues).
        }
        // ACITIVITY ID
        public int Id { get; set; }
        // ACTIVITY Name
        public string Name { get; set; }
    }
}
