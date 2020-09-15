using System;
using System.Collections.Generic;
using System.Linq;
using SimpleWeb_ASP.NET_Core.Models;

namespace SimpleWeb_ASP.NET_Core.Data
{
    // Not best practice
    // Development only
    public class ActivitiesRepository
    {
        // RETURNS list of activities
        public List<Activity> GetActivity()
        {
            return Data.Activities
                .OrderBy(a => a.Name)
                .ToList();
        }
    }
}
