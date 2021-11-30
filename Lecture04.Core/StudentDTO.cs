using System;

namespace Lecture04.Core
{
    public record StudentDTO
    {
        public string? Name {get; init;}
        public int Id {get; init;}
        public string? Email {get; init;}
        public DateTime DOB {get; init;}   
    }
}
