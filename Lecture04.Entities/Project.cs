using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Lecture04.Core;

namespace Lecture04.Entities
{
    public class Project
    {
        public string? Name {get; set;}
        public int Id {get;set;}
        public string? Description { get; set; }       
        public DateTime DueDate { get; set; }
        public int IntendedWorkHours { get; set; }
        //public Language Language { get; set; }        
       
        //public ICollection<ProjectKeyword>? Keywords { get; set; }
        public string? SkillRequirementDescription { get; set; }
        
        //public ISupervisor? Supervisor { get; set; }
        
        //public ISet<WorkDay>? WorkDays { get; set; }
        
        //public ISet<Location>? Locations { get; set; }        
        public bool isThesis { get; set; }
    }
}
