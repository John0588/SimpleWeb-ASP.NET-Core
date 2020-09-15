using System;
using System.Collections.Generic;
using System.Linq;
using SimpleWeb_ASP.NET_Core.Models;
using SimpleWeb_ASP.NET_Core.Data;

namespace SimpleWeb_ASP.NET_Core.Data
{
    // Test Data
    // To be migrated to a database at a later time
    // This takes place of our database
    public class SimpleWebRepository
    {
        public List<Webs> GetSimpleWeb() // Get a list of webs
        {
            
            return Data.SimpleWeb
                .Join(
                    Data.Activities, // The Inner Collection
                    e => e.ActivityId, // The Outer Collection
                    a => a.Id, // The inner sellector
                    (e, a) => // The result sellector
                    {
                        e.Activity = a; // Set the simple web Activity ... /a - async
                        return e; // e - else
                    }
                    )
                .OrderByDescending(e => e.Date)
                .ThenByDescending(e => e.Id)
                .ToList();
        }

        public Webs GetTask(int id) // Get a single webs
        {
            Webs webs = Data.SimpleWeb
                .Where(e => e.Id == id)
                    .SingleOrDefault();

            // Not Null
            if (webs.Activity == null)
            {
                webs.Activity = Data.Activities
                    .Where(a => a.Id == webs.ActivityId)
                    .SingleOrDefault();
            }

            return webs;
        }

        // ADD webs
        // UPDATE webs
        // DELETE webs

    }
}
