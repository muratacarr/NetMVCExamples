using Example01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example01.Models
{
    public class IndexViewModel
    {
        public About About { get; set; }
        public IEnumerable<Skill> Skills { get; set; }

        
    }
}