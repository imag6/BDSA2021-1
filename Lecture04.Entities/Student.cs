using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lecture04.Entities
{
    public class Student
    {
        //public Degree Degree {get; set;}
        //public IPreferences? Preferences {get; set;}
        public string? Name {get; set;}
        public int Id {get; set;}
        public string? Email {get; set;}
        public DateTime DOB {get; set;}        
        //public University University {get; set;}
    }
}
