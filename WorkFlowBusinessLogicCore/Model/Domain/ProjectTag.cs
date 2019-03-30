﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
    public class ProjectTag
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
