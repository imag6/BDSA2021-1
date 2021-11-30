using System;

namespace Lecture04.Core
{
    public record ProjectDTO
    {
       public string? Name {get; init;}
        public int Id {get;init;}
        public string? Description { get; init; }       
        public DateTime DueDate { get; init; }
        public int IntendedWorkHours { get; init; }
        public string? SkillRequirementDescription { get; init; }
        public bool isThesis { get; init; }
    }
}
