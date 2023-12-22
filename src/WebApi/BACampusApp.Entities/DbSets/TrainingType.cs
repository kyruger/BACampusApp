﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACampusApp.Entities.DbSets
{
    public class TrainingType : AuditableEntity
    {
        public TrainingType() 
        {
            Classrooms = new HashSet<Classroom>();
        }

        public string Name { get; set; }
        //Navigation Property
        public virtual ICollection<Classroom> Classrooms { get; set; }
    }
}
