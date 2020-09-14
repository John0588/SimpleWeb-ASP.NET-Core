﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleWeb_ASP.NET_Core.Models;
using SimpleWeb_ASP.NET_Core.Data;

namespace SimpleWeb_ASP.NET_Core.Data
{
    // Test Data
    // To be migrated to a database at a later time
    // This takes place of our database
    public class SimpleWebRepository
    {
        public List<Tasks> GetTask() // Get a list of tasks
        {
            
            return Data.Tasks
                .Join(
                    Data.Activities, // The Inner Collection
                    e => e.ActrivityId, // The Outer Collection
                    a => a.id, // The inner sellector
                    (e, a) => // The result sellector
                    {
                        e.Activity = a; // Set the task's Activity
                        return e;
                    }
                    )
                .OrderByDecending(e => e.Date)
                .ThenByDecending(e => e.Id)
                .ToList();
        }

        public Task GetTask(int id) // Get a single task
        {
            Task task = Data.Tasks
                .Where(e => e.Id == id)
                    .SingleOrDefault();

            // Not Null
            if (task.Activity == null)
            {
                task.Activity = Data.Activities
                    .Where(a => a.Id == task.ActivityId)
                    .SingleOrDefault();
            }

            return task;
        }

        // ADD task
        // UPDATE task
        // DELETE task

    }
}
